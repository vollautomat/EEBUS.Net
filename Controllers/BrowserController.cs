
namespace EEBUS.Controllers
{
    using EEBUS.Enums;
    using EEBUS.Models;
	using EEBUS.SHIP;
	using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Net.Security;
    using System.Net.WebSockets;
	using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class BrowserController : Controller
    {
        private readonly MDNSClient _mDNSClient;
		private readonly MDNSService _mDNSService;
		private static ClientWebSocket _wsClient;

		private ServerNode _model = new ServerNode();

        public BrowserController(MDNSClient mDNSClient, MDNSService mDNSService)
        {
            _mDNSClient = mDNSClient;
            _mDNSService = mDNSService;

            _model.LocalSKI = _mDNSService.LocalSKI;
		}

		public IActionResult Index()
        {
            try
            {
                return View("Index", new ServerNodes() { Nodes = _mDNSClient.getEEBUSNodes(), LocalSKI = _model.LocalSKI });
            }
            catch (Exception ex)
            {
                _model.Error = "Error: " + ex.Message;
                return View("Index", new ServerNodes() { Nodes = new ServerNode[] { _model }, LocalSKI = _model.LocalSKI });
            }
        }

        private bool ValidateServerCert(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // extract SKI
            foreach (X509Extension extension in ((X509Certificate2)certificate).Extensions)
            {
                if (extension.Oid.FriendlyName == "Subject Key Identifier" || extension.Oid.FriendlyName == "Schlüsselkennung des Antragstellers")
                {
                    X509SubjectKeyIdentifierExtension ext = (X509SubjectKeyIdentifierExtension)extension;
                    _model.SKI = ext.SubjectKeyIdentifier;

                    // add spaces every 4 hex digits (EEBUS requirement)
                    for (int i = 4; i < _model.SKI.Length; i += 4)
                    {
                        _model.SKI = _model.SKI.Insert(i, " ");
                        i++;
                    }

                    break;
                }
            }

            return true;
        }

        [HttpPost]
        public async Task<IActionResult> Connect()
        {
            try
            {
                foreach (string key in Request.Form.Keys)
                {
                    if (key.Contains("EEBUS:"))
                    {
                        string[] parts = key.Split('|');
                        _model.Name = parts[1];
                        _model.Id = parts[2];
                        _model.Url = parts[3];
                        break;
                    }
                }

                _wsClient = new ClientWebSocket();
                _wsClient.Options.AddSubProtocol("ship");
                _wsClient.Options.RemoteCertificateValidationCallback = ValidateServerCert;
				_wsClient.Options.ClientCertificates.Add(_mDNSService.Cert);
                await _wsClient.ConnectAsync(new Uri("wss://" + _model.Url), CancellationToken.None).ConfigureAwait(false);
                
                return View("Accept", _model);
            }
            catch (Exception ex)
            {
                _model.Error = "Error: " + ex.Message;
                return View("Index", new ServerNodes() { Nodes = new ServerNode[] { _model }, LocalSKI = _model.LocalSKI });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Accept()
        {
            try
            {
                foreach (string key in Request.Form.Keys)
                {
                    if (key.Contains("EEBUS:"))
                    {
                        string[] parts = key.Split('|');
                        _model.Name = parts[1];
                        _model.Id = parts[2];
                        _model.Url = parts[3];
                        break;
                    }
                }

                if (_wsClient.State == WebSocketState.Open)
                {
                    if (!await InitPhase().ConfigureAwait(false))
                    {
                        return await Disconnect().ConfigureAwait(false);
                    }

                    if (!await HelloPhase().ConfigureAwait(false))
                    {
                        return await Disconnect().ConfigureAwait(false);
                    }

                    if (!await HandshakePhase().ConfigureAwait(false))
                    {
                        return await Disconnect().ConfigureAwait(false);
                    }

					if (!await PinCheckPhase().ConfigureAwait(false))
					{
						return await Disconnect().ConfigureAwait(false);
					}

					if (!await AccessMethodsRequestPhase().ConfigureAwait(false))
					{
						return await Disconnect().ConfigureAwait(false);
					}

					if (!await AccessMethodsPhase().ConfigureAwait(false))
					{
						return await Disconnect().ConfigureAwait(false);
					}

					return View("Connected", _model);
                }
                else
                {
                    return await Disconnect().ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                return await Disconnect(ex.Message).ConfigureAwait(false);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SendTestData()
        {
            return await SendData("SPINE test data").ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<IActionResult> SendSPINEData(SPINE spine)
        {
            foreach (string key in Request.Form.Keys)
            {
                if (key.Contains("EEBUS:"))
                {
                    string[] parts = key.Split('|');
                    _model.Name = parts[1];
                    _model.Id = parts[2];
                    _model.Url = parts[3];
                    break;
                }
            }

            return await SendData(spine.GenerateDatagram(_model.Url)).ConfigureAwait(false);
        }


        private async Task<IActionResult> SendData(object payload)
        {
            try
            {
                foreach (string key in Request.Form.Keys)
                {
                    if (key.Contains("EEBUS:"))
                    {
                        string[] parts = key.Split('|');
                        _model.Name = parts[1];
                        _model.Id = parts[2];
                        _model.Url = parts[3];
                        break;
                    }
                }

                if (_wsClient.State == WebSocketState.Open)
                {
                    // send data message
                    SHIP.DataMessage dataMessage = new SHIP.DataMessage("spine", payload);
                    await dataMessage.Send(_wsClient);

                    // wait for data response message from server
                    dataMessage = await SHIP.DataMessage.Receive(_wsClient);

                    if (dataMessage == null)
						return await Disconnect().ConfigureAwait(false);

					if ((dataMessage.data == null) || (dataMessage.data.payload == null))
                    {
                        throw new Exception("Data message parsing failed!");
                    }
                    else
                    {
                        _model.LatestDataReceived = dataMessage.data.payload.ToString();
                    }

                    return View("Connected", _model);
                }
                else
                {
                    return await Disconnect().ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                return await Disconnect(ex.Message).ConfigureAwait(false);
            }
        }

        private async Task<bool> InitPhase()
        {
            // send init request message
            byte[] initRequest = new byte[2];
            initRequest[0] = SHIPMessageType.INIT;
            initRequest[1] = SHIPMessageValue.CMI_HEAD;

            await _wsClient.SendAsync(initRequest, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

            // wait for init response message from server
            byte[] initResponse = new byte[2];
            WebSocketReceiveResult result = await _wsClient.ReceiveAsync(initResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
            if (result.MessageType == WebSocketMessageType.Close)
            {
                return false;
            }

            if ((initResponse[0] != SHIPMessageType.INIT) || (initResponse[1] != SHIPMessageValue.CMI_HEAD))
            {
                throw new Exception("Expected init response message!");
            }

            return true;
        }

        private async Task<bool> HelloPhase()
        {
            try
            {
                // send connection data preparation ("hello" message)
                bool helloPhase = true;

                SHIP.ConnectionHelloMessage helloMessage = new SHIP.ConnectionHelloMessage(SHIP.ConnectionHelloPhaseType.ready, 60000);
                await helloMessage.Send(_wsClient);

                // wait for hello response message from server
                int numProlongsReceived = 0;
                while (helloPhase)
                {
                    SHIP.ConnectionHelloMessage helloResponse = await SHIP.ConnectionHelloMessage.Receive(_wsClient, SHIPMessageTimeout.T_HELLO_INIT);

					switch (helloResponse.connectionHello.phase)
                    {
                        case SHIP.ConnectionHelloPhaseType.ready:
                            // all good, we can move on
                            helloPhase = false;
                            break;

                        case SHIP.ConnectionHelloPhaseType.aborted:
                            // server aborted
                            return false;

                        case SHIP.ConnectionHelloPhaseType.pending:

                            if (helloResponse.connectionHello.prolongationRequest)
                            {
                                // the server needs more time, send a hello update message
                                numProlongsReceived++;
                                if (numProlongsReceived > 2)
                                    throw new Exception("More than 2 prolong requests received, aborting!");

                                await helloMessage.Resend(_wsClient);
                            }

                            break;

                        default: throw new Exception("Invalid hello sub-state received!");
                    }
                }

                return true;
            }
            catch (Exception)
            {
                try
                {
					// send hello abort message
					SHIP.ConnectionHelloMessage helloMessage = new SHIP.ConnectionHelloMessage(SHIP.ConnectionHelloPhaseType.aborted);
                    await helloMessage.Send(_wsClient);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }

                throw;
            }
        }

		private async Task<bool> HandshakePhase()
        {
            try
            {
                // send protocol handshake message
                SHIP.ProtocolHandshakeMessage handshakeMessage = new SHIP.ProtocolHandshakeMessage(SHIP.ProtocolHandshakeTypeType.announceMax, 1, 0);
                await handshakeMessage.Send(_wsClient);

				// wait for handshake response message from server
				handshakeMessage = await SHIP.ProtocolHandshakeMessage.Receive(_wsClient);

                if (handshakeMessage.messageProtocolHandshake.handshakeType != SHIP.ProtocolHandshakeTypeType.select)
                    throw new Exception("Protocol version selection expected!");

                if (handshakeMessage.messageProtocolHandshake.version.major != 1 && handshakeMessage.messageProtocolHandshake.version.minor != 0)
                    throw new Exception("Protocol version mismatch!");

                if ((handshakeMessage.messageProtocolHandshake.formats.format.Length > 0) && (handshakeMessage.messageProtocolHandshake.formats.format[0] == SHIPMessageFormat.JSON_UTF8))
                {
                    // send the message back
                    await handshakeMessage.Send(_wsClient);

                    return true;
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
                    // send handshake error message
                    SHIP.ProtocolHandshakeErrorMessage handshakeErrorMessage = new SHIP.ProtocolHandshakeErrorMessage();

                    if (ex.Message.Contains("mismatch"))
                        handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
                    else
                        handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;

                    await handshakeErrorMessage.Send(_wsClient);
                }
                catch (Exception innerEx)
                {
                    Console.WriteLine("Exception: " + innerEx.Message);
                }

                throw;
            }
        }

		private async Task<bool> PinCheckPhase()
		{
			try
			{
				// send protocol pincheck message
				SHIP.PinCheckMessage pincheckMessage = new SHIP.PinCheckMessage(PinStateType.none);
                await pincheckMessage.Send(_wsClient);

                // wait for handshake response message from server
                pincheckMessage = await SHIP.PinCheckMessage.Receive(_wsClient);

				if (pincheckMessage.connectionPinState.pinState != PinStateType.none)
					throw new Exception("Pinstate none expected!");

				if (pincheckMessage.connectionPinState.inputPermissionSpecified != false)
					throw new Exception("Pinstate inputPermissionSpecified expected!");

				return true;
			}
			catch (Exception ex)
			{
				try
				{
					// send handshake error message
					SHIP.ProtocolHandshakeErrorMessage handshakeErrorMessage = new SHIP.ProtocolHandshakeErrorMessage();

					if (ex.Message.Contains("mismatch"))
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
					else
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;

                    await handshakeErrorMessage.Send(_wsClient);
				}
				catch (Exception innerEx)
				{
					Console.WriteLine("Exception: " + innerEx.Message);
				}

				throw;
			}
		}

		private async Task<bool> AccessMethodsRequestPhase()
		{
			try
			{
				// send access methods request message
				SHIP.AccessMethodsRequestMessage accessMethodsRequestMessage = new SHIP.AccessMethodsRequestMessage();
                await accessMethodsRequestMessage.Send(_wsClient);

                // wait for handshake response message from server
                accessMethodsRequestMessage = await SHIP.AccessMethodsRequestMessage.Receive(_wsClient);
                if (accessMethodsRequestMessage == null)
                {
                    throw new Exception("Access methods request parsing failed!");
                }

                return true;
			}
			catch (Exception ex)
			{
				try
				{
					// send handshake error message
					SHIP.ProtocolHandshakeErrorMessage handshakeErrorMessage = new SHIP.ProtocolHandshakeErrorMessage();

					if (ex.Message.Contains("mismatch"))
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
					else
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;

					await handshakeErrorMessage.Send(_wsClient);
				}
				catch (Exception innerEx)
				{
					Console.WriteLine("Exception: " + innerEx.Message);
				}

				throw;
			}
		}

		private async Task<bool> AccessMethodsPhase()
		{
			try
			{
				// send access methods request message
				SHIP.AccessMethodsMessage accessMethodsMessage = new SHIP.AccessMethodsMessage("Demo-CSharp-987654321");

                await accessMethodsMessage.Send(_wsClient);

                // wait for handshake response message from server
                accessMethodsMessage = await SHIP.AccessMethodsMessage.Receive(_wsClient);

				return true;
			}
			catch (Exception ex)
			{
				try
				{
					// send handshake error message
					SHIP.ProtocolHandshakeErrorMessage handshakeErrorMessage = new SHIP.ProtocolHandshakeErrorMessage();

					if (ex.Message.Contains("mismatch"))
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
					else
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;

                    await handshakeErrorMessage.Send(_wsClient);
				}
				catch (Exception innerEx)
				{
					Console.WriteLine("Exception: " + innerEx.Message);
				}

				throw;
			}
		}

		[HttpPost]
        public async Task<IActionResult> Disconnect(string errorMessage = null)
        {
            try
            {
                if (_wsClient != null)
                {
                    // send close message
                    SHIP.CloseMessage closeMessage = new SHIP.CloseMessage(ConnectionClosePhaseType.announce);
                    await closeMessage.Send(_wsClient);

                    // wait for close response message from server
                    closeMessage = await SHIP.CloseMessage.Receive(_wsClient);

                    if (closeMessage == null)
                    {
                        throw new Exception("Close message parsing failed!");
                    }

                    if (closeMessage.connectionClose[0].phase != ConnectionClosePhaseType.confirm)
                    {
                        throw new Exception("Close confirmation message expected!");
                    }

                    // now close websocket
                    await _wsClient.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None).ConfigureAwait(false);
                    _wsClient.Dispose();
                    _wsClient = null;
                }

                if (string.IsNullOrEmpty(errorMessage))
                {
                    return View("Index", new ServerNodes() { Nodes = _mDNSClient.getEEBUSNodes(), LocalSKI = _model.LocalSKI });
                }
                else
                {
                    _model.Error = "Error: " + errorMessage;
                    return View("Index", new ServerNodes() { Nodes = new ServerNode[] { _model }, LocalSKI = _model.LocalSKI });
                }
            }
            catch (Exception _ex)
            {
                return View("Index", new ServerNodes() { Nodes = _mDNSClient.getEEBUSNodes(), LocalSKI = _model.LocalSKI });
            }
        }

        private string JsonFromEEBUSJson( string json )
        {
			json = json.Replace("[{", "{");
			json = json.Replace("},{", ",");
			json = json.Replace("}]", "}");
			json = json.Replace("[]", "{}");
            return json;
	    }
    }
}
