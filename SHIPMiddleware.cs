
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

using EEBUS.Enums;
using EEBUS.SHIP.Messages;

namespace EEBUS
{
	//[EnableCors]
	public class SHIPMiddleware
    {
        private readonly RequestDelegate _next;
        private ConcurrentDictionary<string, WebSocket> connectedNodes = new ConcurrentDictionary<string, WebSocket>();


        public SHIPMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                if (!httpContext.WebSockets.IsWebSocketRequest)
                {
                    // passed on to next middleware
                    await _next(httpContext).ConfigureAwait(false);
                }

                if (!ProtocolSupported(httpContext))
                {
                    // passed on to next middleware
                    await _next(httpContext).ConfigureAwait(false);
                }

                string connectedNodeName = httpContext.Request.Host.Host;
                if (connectedNodes.ContainsKey(connectedNodeName))
                {
                    // we only allow 1 connection per host, so close any existing ones
                    WebSocket existingSocket = connectedNodes[connectedNodeName];
                    if (existingSocket != null)
                    {
                        Console.WriteLine($"New websocket request received for existing connection {connectedNodeName}, closing old websocket!");
                        await CloseConnectionAsync(connectedNodeName, existingSocket).ConfigureAwait(false);
                    }
                }

                var socket = await httpContext.WebSockets.AcceptWebSocketAsync("ship").ConfigureAwait(false);
                if (socket == null || socket.State != WebSocketState.Open)
                {
                    Console.WriteLine("Failed to accept socket from " + httpContext.Request.Host.Host);
                    return;
                }

                connectedNodes.TryAdd(connectedNodeName, socket);
                Console.WriteLine($"Now connected to {connectedNodeName}. Number of active connections: {connectedNodes.Count}");

                await SendAndReceive(connectedNodeName, socket).ConfigureAwait(false);
                                
                // we're done, close and return
                await CloseConnectionAsync(connectedNodeName, socket).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);

                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsync("Error while processing websocket: " + ex.Message).ConfigureAwait(false);
            }
        }

        private bool ProtocolSupported(HttpContext httpContext)
        {
            IList<string> requestedProtocols = httpContext.WebSockets.WebSocketRequestedProtocols;
            if ((requestedProtocols.Count == 0) || !requestedProtocols.Contains("ship"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private async Task SendAndReceive(string connectedNodeName, WebSocket webSocket)
        {
            try
            {
                while (webSocket.State == WebSocketState.Open)
                {
                    byte[] receiveBuffer = new byte[1024];
                    WebSocketReceiveResult result = await webSocket.ReceiveAsync(receiveBuffer, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
                    if (result.CloseStatus.HasValue)
                    {
                        // close received
                        break;
                    }
                    if (result.Count < 2)
                    {
                        throw new Exception("Invalid EEBUS payload received, expected message size of at least 2!");
                    }

					switch (receiveBuffer[0])
                    {
                        case SHIPMessageType.INIT:

                            Console.WriteLine($"Init message received from {connectedNodeName}.");

							InitMessage initMessageReceived = InitMessage.FromJson(receiveBuffer);

							if (initMessageReceived.bytes[0] != SHIPMessageValue.CMI_HEAD)
                                throw new Exception("Expected SMI_HEAD payload in INIT message!");

							// set response payload
							InitMessage initMessage = new InitMessage();
							await initMessage.Send(webSocket);

                            break;

                        case SHIPMessageType.CONTROL:

                            // there are 6 control messages defined: Hello, ProtocolHandshake, ProtocolHandShakeError, AccessMethodsRequest, PINVerification and PINVerificationError
                            // Note: We ignore PINVerification and PINVerificationError messages
                            bool controlMessageHandled = false;

                            Type commandType = JsonMessageBase.GetType(receiveBuffer);

                            if (commandType == typeof(ConnectionHelloMessage))
                            {
                                ConnectionHelloMessage helloMessageReceived = ConnectionHelloMessage.FromJson(receiveBuffer);
                                
                                if ((helloMessageReceived != null) && (helloMessageReceived.connectionHello != null))
                                {
                                    Console.WriteLine($"Hello message received from {connectedNodeName}.");

                                    if (!await HandleHelloMessage(webSocket, helloMessageReceived.connectionHello).ConfigureAwait(false))
                                        throw new Exception("Hello aborted!");

                                    controlMessageHandled = true;
                                }
                            }
                            else if (commandType == typeof(ProtocolHandshakeMessage))
							{
                                ProtocolHandshakeMessage handshakeMessageReceived = ProtocolHandshakeMessage.FromJson(receiveBuffer);

                                if ((handshakeMessageReceived != null) && (handshakeMessageReceived.messageProtocolHandshake != null))
                                {
                                    Console.WriteLine($"Handshake message received from {connectedNodeName}.");

                                    if (!await HandleHandshakeMessage(webSocket, handshakeMessageReceived.messageProtocolHandshake).ConfigureAwait(false))
                                        throw new Exception("Handshake aborted!");

                                    controlMessageHandled = true;
                                }
                            }
							else if (commandType == typeof(ProtocolHandshakeErrorMessage))
							{
								ProtocolHandshakeErrorMessage handshakeErrorMessageReceived = ProtocolHandshakeErrorMessage.FromJson(receiveBuffer);
                                
                                if ((handshakeErrorMessageReceived != null) && (handshakeErrorMessageReceived.messageProtocolHandshakeError != null))
                                {
                                    Console.WriteLine($"Handshake error message received from {connectedNodeName} due to {handshakeErrorMessageReceived.messageProtocolHandshakeError.error}.");

                                    controlMessageHandled = true;

                                    throw new Exception("Handshake aborted!");
                                }
                            }
							else if (commandType == typeof(PinCheckMessage))
							{
								PinCheckMessage pinCheckMessageReceived = PinCheckMessage.FromJson(receiveBuffer);

								if ((pinCheckMessageReceived != null) && (pinCheckMessageReceived.connectionPinState != null))
								{
									Console.WriteLine($"Handshake message received from {connectedNodeName}.");

									if (!await HandlePinCheckMessage(webSocket, pinCheckMessageReceived.connectionPinState).ConfigureAwait(false))
										throw new Exception("Handshake aborted!");

									controlMessageHandled = true;
								}
							}
							else if (commandType == typeof(AccessMethodsRequestMessage))
							{
								AccessMethodsRequestMessage accessMethodsMessageReceived = AccessMethodsRequestMessage.FromJson(receiveBuffer);

                                if ((accessMethodsMessageReceived != null) && (accessMethodsMessageReceived.accessMethodsRequest != null))
                                {
                                    Console.WriteLine($"Access Methods message received from {connectedNodeName}.");

                                    if (!await HandleAccessMethodsRequestMessage(connectedNodeName, webSocket, accessMethodsMessageReceived.accessMethodsRequest).ConfigureAwait(false))
										throw new Exception("Access methods request received message aborted!");

                                    controlMessageHandled = true;
                                }
                            }
							else if (commandType == typeof(AccessMethodsMessage))
							{
								AccessMethodsMessage accessMethodsMessageReceived = AccessMethodsMessage.FromJson(receiveBuffer);

								if ((accessMethodsMessageReceived != null) && (accessMethodsMessageReceived.accessMethods != null))
								{
									Console.WriteLine($"Access Methods message received from {connectedNodeName}.");

									if (!await HandleAccessMethodsMessage(connectedNodeName, webSocket, accessMethodsMessageReceived.accessMethods).ConfigureAwait(false))
										throw new Exception("Access methods received message aborted!");

									controlMessageHandled = true;
								}
							}
							
                            if (!controlMessageHandled)
                            {
                                Console.WriteLine($"Control message from {connectedNodeName} ignored!");
                            }

                            break;

                        case SHIPMessageType.DATA:

                            Console.WriteLine($"Data message received from {connectedNodeName}.");

							DataMessage dataMessageReceived = DataMessage.FromJson(receiveBuffer);

                            if ((dataMessageReceived != null) && (dataMessageReceived.data != null))
                            {
                                if (!await HandleDataMessage(webSocket, dataMessageReceived.data).ConfigureAwait(false))
                                {
                                    throw new Exception("Data message aborted!");
                                }
                            }

                            break;

                        case SHIPMessageType.END:

                            Console.WriteLine($"Close message received from {connectedNodeName}.");

							CloseMessage closeMessageReceived = CloseMessage.FromJson(receiveBuffer);
                            
                            if ((closeMessageReceived != null) && (closeMessageReceived.connectionClose != null))
                            {
                                if (!await HandleCloseMessage(webSocket, closeMessageReceived.connectionClose[0]).ConfigureAwait(false))
                                {
                                    throw new Exception("Close message aborted!");
                                }
                            }
                            break;

                        default:
                            throw new Exception("Invalid EEBUS message type received!");
                    }
                 }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private async Task<bool> HandleHelloMessage(WebSocket webSocket, ConnectionHelloType helloMessageReceived)
        {
			ConnectionHelloMessage helloReadyMessage = new ConnectionHelloMessage(ConnectionHelloPhaseType.ready);
			int numProlongsReceived = 0;
            while (true)
            {
                switch (helloMessageReceived.phase)
                {
                    case ConnectionHelloPhaseType.ready:
						// send "ready" message back
						
                        await helloReadyMessage.Send(webSocket);

                        // all good, we can move on
                        return true;

                    case ConnectionHelloPhaseType.aborted:
                        // client aborted
                        return false;

                    case ConnectionHelloPhaseType.pending:
                        if (helloMessageReceived.prolongationRequest)
                        {
                            // the client needs more time, send a hello update message
                            numProlongsReceived++;

                            if (numProlongsReceived > 2)
                            {
                                Console.WriteLine("More than 2 prolong requests received, aborting!");
								ConnectionHelloMessage helloAbortMessage = new ConnectionHelloMessage(ConnectionHelloPhaseType.aborted);
								await helloAbortMessage.Send(webSocket);

                                return false;
                            }

							// send "ready" message
							await helloReadyMessage.Send(webSocket);
                        }
                        else
                        {
							// send "ready" message
							await helloReadyMessage.Send(webSocket);
                        }

                        break;

                    default: throw new Exception("Invalid hello sub-state received!");
                }

                // receive the next hello message
                ConnectionHelloMessage helloMessage = await ConnectionHelloMessage.Receive(webSocket);
                helloMessageReceived = helloMessage.connectionHello;
			}
        }

        private async Task<bool> HandleHandshakeMessage(WebSocket webSocket, MessageProtocolHandshakeType handshakeMessageReceived)
        {
            try
            {
                if (handshakeMessageReceived.handshakeType != ProtocolHandshakeTypeType.announceMax)
                {
                    throw new Exception("Protocol version max announcement expected!");
                }

                if (handshakeMessageReceived.version.major != 1 && handshakeMessageReceived.version.minor != 0)
                {
                    throw new Exception("Protocol version mismatch!");
                }

                if ((handshakeMessageReceived.formats.format.Length > 0) && (handshakeMessageReceived.formats.format[0] == SHIPMessageFormat.JSON_UTF8))
                {
                    // send protocol handshake response message
                    ProtocolHandshakeMessage handshakeMessage = new ProtocolHandshakeMessage(ProtocolHandshakeTypeType.select, 1, 0);
					await handshakeMessage.Send(webSocket);

					// wait for final confirmation from client
					ProtocolHandshakeMessage handshakeResponse = await ProtocolHandshakeMessage.Receive(webSocket);

                    return handshakeResponse.IsEqual(handshakeMessage);
                }
                else
                {
                    throw new Exception("Protocol format mismatch!");
                }
            }
            catch (Exception ex)
            {
                try
                {
                    ProtocolHandshakeErrorMessage handshakeErrorMessage = new ProtocolHandshakeErrorMessage();

                    if (ex.Message.Contains("mismatch"))
                        handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
                    else
                        handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;

                    await handshakeErrorMessage.Send(webSocket);
                }
                catch (Exception innerEx)
                {
                    Console.WriteLine("Exception: " + innerEx.Message);
                }

                throw;
            }
        }

		private async Task<bool> HandlePinCheckMessage(WebSocket webSocket, ConnectionPinStateType pinCheckReceived)
		{
			try
            {
			    if (pinCheckReceived.pinState != PinStateType.none)
				    throw new Exception("Pinstate none expected!");

			    if (pinCheckReceived.inputPermissionSpecified != false)
				    throw new Exception("Pinstate inputPermissionSpecified expected!");
			}
			catch (Exception innerEx)
			{
				Console.WriteLine("Exception: " + innerEx.Message);
			}

			PinCheckMessage pinCheckMessage = new PinCheckMessage(PinStateType.none);
			await pinCheckMessage.Send(webSocket);

			return true;
		}

		private async Task<bool> HandleAccessMethodsRequestMessage(string connectedNodeName, WebSocket webSocket, AccessMethodsRequestType accessMethodsRequest)
		{
			AccessMethodsRequestMessage accessMethodsRequestResponse = new AccessMethodsRequestMessage();
			await accessMethodsRequestResponse.Send(webSocket);

			return true;
		}

		private async Task<bool> HandleAccessMethodsMessage(string connectedNodeName, WebSocket webSocket, AccessMethodsType accessMethods)
        {
            try
            {
                // simply print the access methods to the console
                if (accessMethods.dnsSd_mDns != null)
                {
                    Console.WriteLine($"Received access method mDNS from {connectedNodeName} with ID {accessMethods.id} at {accessMethods.dns.uri}.");
                }

                if (accessMethods.dns != null)
                {
                    Console.WriteLine($"Received access method DNS from {connectedNodeName} with ID {accessMethods.id} at {accessMethods.dns.uri}.");
                }

				AccessMethodsMessage accessMethodsResponse = new AccessMethodsMessage(accessMethods.id);
				await accessMethodsResponse.Send(webSocket);
			}
			catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
                
            return true;
        }

        private async Task<bool> HandleDataMessage(WebSocket webSocket, DataType data)
        {
            try
            {
                //if (data.header.protocolId != "spine")
                //{
                //    throw new Exception("SPINE protocol expected!");
                //}

                // handle SPINE payload
                if (!await HandleSpineMessage(webSocket, data.payload).ConfigureAwait(false))
                {
                    throw new Exception("Handle SPINE message failed!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return true;
        }

        public async Task<bool> SendDataMessage(WebSocket webSocket, object payload)
        {
            try
            {
                // send data payload
                DataMessage dataMessage = new DataMessage(payload);
                await dataMessage.Send(webSocket);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
        }

        private async Task<bool> HandleSpineMessage(WebSocket webSocket, object payload)
        {
            Console.WriteLine($"SPINE data received: {payload}.");

            // TODO: Send the same message back for now
            return await SendDataMessage(webSocket, payload).ConfigureAwait(false);
        }

        private async Task<bool> HandleCloseMessage(WebSocket webSocket, ConnectionCloseType connectionClose)
        {
            try
            {
                if (connectionClose.phase != ConnectionClosePhaseType.announce)
                {
                    throw new Exception("Close connection announcement expected!");
                }

                if (connectionClose.reasonSpecified && connectionClose.reason == ConnectionCloseReasonType.removedConnection)
                {
                    Console.WriteLine($"Received close connection request with removed connection reason");
                }

                if (connectionClose.reasonSpecified && connectionClose.reason == ConnectionCloseReasonType.unspecific)
                {
                    Console.WriteLine($"Received close connection request with unspecific reason");
                }

                // send confirmation back
                CloseMessage closeMessage = new CloseMessage(ConnectionClosePhaseType.confirm);
                await closeMessage.Send(webSocket);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return true;
        }

        private async Task CloseConnectionAsync(string connectedNodeName, WebSocket webSocket)
        {
            try
            {
                await webSocket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Closing!", CancellationToken.None).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            connectedNodes.TryRemove(connectedNodeName, out _);

            Console.WriteLine($"Closed websocket for connectedNode {connectedNodeName}. Remaining active connectedNodes : {connectedNodes.Count}");
        }
    }
}
