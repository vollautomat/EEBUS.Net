
namespace EEBUS.Controllers
{
    using EEBUS.Enums;
    using EEBUS.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Net.Security;
    using System.Net.WebSockets;
	using System.Security.Cryptography;
	using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class BrowserController : Controller
    {
        private readonly MDNSClient _mDNSClient;
        private static ClientWebSocket _wsClient;
        private static X509Certificate2 cert;

		private ServerNode _model = new ServerNode();

        public BrowserController(MDNSClient mDNSClient)
        {
            _mDNSClient = mDNSClient;

            if (null == cert)
                cert = CertificateGenerator.GenerateCert(Dns.GetHostName());

			byte[] hash = SHA1.Create().ComputeHash(cert.GetPublicKey());
			_model.LocalSKI = Convert.ToHexString(hash);
			// add spaces every 4 hex digits (EEBUS requirement)
			for (int i = 4; i < _model.LocalSKI.Length; i += 4)
			{
				_model.LocalSKI = _model.LocalSKI.Insert(i, " ");
				i++;
			}
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
				_wsClient.Options.ClientCertificates.Add(cert);
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
                    SHIPDataMessage dataMessage = new SHIPDataMessage();
                    dataMessage.data.header = new HeaderType();
                    dataMessage.data.header.protocolId = "spine";
                    dataMessage.data.payload = payload;
                    
                    byte[] dataMessageSerialized = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dataMessage));
                    byte[] dataMessageBuffer = new byte[dataMessageSerialized.Length + 1];

                    dataMessageBuffer[0] = SHIPMessageType.DATA;
                    Buffer.BlockCopy(dataMessageSerialized, 0, dataMessageBuffer, 1, dataMessageSerialized.Length);

                    await _wsClient.SendAsync(dataMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

                    // wait for data response message from server
                    byte[] dataResponse = new byte[1024];
                    WebSocketReceiveResult result = await _wsClient.ReceiveAsync(dataResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        return await Disconnect().ConfigureAwait(false);
                    }

                    if ((result.Count < 2) || (dataResponse[0] != SHIPMessageType.DATA))
                    {
                        throw new Exception("Data message expected!");
                    }

                    byte[] dataResponseMessageBuffer = new byte[result.Count - 1];
                    Buffer.BlockCopy(dataResponse, 1, dataResponseMessageBuffer, 0, result.Count - 1);

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Include,
                        MissingMemberHandling = MissingMemberHandling.Error
                    };

                    string dataResponseMsg = Encoding.UTF8.GetString(dataResponseMessageBuffer);
                    dataResponseMsg = JsonFromEEBUSJson(dataResponseMsg);
					SHIPDataMessage dataMessageReceived = JsonConvert.DeserializeObject<SHIPDataMessage>(dataResponseMsg, settings);
                    if ((dataMessageReceived == null) || (dataMessageReceived.data == null) || (dataMessageReceived.data.payload == null))
                    {
                        throw new Exception("Data message parsing failed!");
                    }
                    else
                    {
                        _model.LatestDataReceived = dataMessageReceived.data.payload.ToString();
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

                SHIPHelloMessage helloMessage = new SHIPHelloMessage();
                helloMessage.connectionHello.phase = ConnectionHelloPhaseType.ready;
                helloMessage.connectionHello.waiting = 60000;

				byte[] helloMessageSerialized = helloMessage.ToJson();
				var helloMsg = System.Text.Encoding.Default.GetString(helloMessageSerialized);
				Console.WriteLine("helloMessage: " + helloMsg);
				byte[] helloMessageBuffer = new byte[helloMessageSerialized.Length + 1];

                helloMessageBuffer[0] = SHIPMessageType.CONTROL;
                Buffer.BlockCopy(helloMessageSerialized, 0, helloMessageBuffer, 1, helloMessageSerialized.Length);

                await _wsClient.SendAsync(helloMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

                // wait for hello response message from server
                int numProlongsReceived = 0;
                while (helloPhase)
                {
                    byte[] helloResponse = new byte[256];
                    WebSocketReceiveResult result = await _wsClient.ReceiveAsync(helloResponse, new CancellationTokenSource(SHIPMessageTimeout.T_HELLO_INIT).Token).ConfigureAwait(false);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        return false;
                    }

                    if ((result.Count < 2) || (helloResponse[0] != SHIPMessageType.CONTROL))
                    {
                        throw new Exception("Expected hello message!");
                    }

                    byte[] helloResponseMessageBuffer = new byte[result.Count - 1];
                    Buffer.BlockCopy(helloResponse, 1, helloResponseMessageBuffer, 0, result.Count - 1);

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Include,
                    //    MissingMemberHandling = MissingMemberHandling.Error
                    };

                    string helloResponseMessage = Encoding.UTF8.GetString(helloResponseMessageBuffer);
                    Console.WriteLine("helloResponseMessage: " + helloResponseMessage);
					SHIPHelloResponse helloMessageReceived = JsonConvert.DeserializeObject<SHIPHelloResponse>(helloResponseMessage, settings);
                    if (helloMessageReceived == null)
                    {
                        throw new Exception("Hello message response parsing failed!");
                    }
                    else if (helloMessageReceived.connectionHello.Length == 0)
                    {
						throw new Exception("Hello message response without data!");
					}
                    //int indx = helloMessageReceived.connectionHello.Length - 1;

					switch (helloMessageReceived.connectionHello[0].phase)
                    {
                        case ConnectionHelloPhaseType.ready:
                            // all good, we can move on
                            helloPhase = false;
                            break;

                        case ConnectionHelloPhaseType.aborted:
                            // server aborted
                            return false;

                        case ConnectionHelloPhaseType.pending:

                            if (helloMessageReceived.connectionHello[0].prolongationRequest)
                            {
                                // the server needs more time, send a hello update message
                                numProlongsReceived++;
                                if (helloMessageReceived.connectionHello.Length > 2)
                                {
                                    throw new Exception("More than 2 prolong requests received, aborting!");
                                }

                                await _wsClient.SendAsync(helloMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.T_HELLO_PROLONG_WAITING_GAP).Token).ConfigureAwait(false);
                            }

                            break;

                        default: throw new Exception("Invalid hello sub-state received!");
                    }
                }

                return true;
            }
            catch (Exception _ex)
            {
                try
                {
                    // send hello abort message
                    SHIPHelloMessage helloMessage = new SHIPHelloMessage();
                    helloMessage.connectionHello.phase = ConnectionHelloPhaseType.aborted;

                    byte[] helloMessageSerialized = helloMessage.ToJson();
					byte[] helloMessageBuffer = new byte[helloMessageSerialized.Length + 1];

                    helloMessageBuffer[0] = SHIPMessageType.CONTROL;
                    Buffer.BlockCopy(helloMessageSerialized, 0, helloMessageBuffer, 1, helloMessageSerialized.Length);
                    
                    await _wsClient.SendAsync(helloMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
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
                SHIPHandshakeMessage handshakeMessage = new SHIPHandshakeMessage();
                handshakeMessage.messageProtocolHandshake.handshakeType = ProtocolHandshakeTypeType.announceMax;
                handshakeMessage.messageProtocolHandshake.version = new MessageProtocolHandshakeTypeVersion
                {
                    major = 1,
                    minor = 0
                };
                handshakeMessage.messageProtocolHandshake.formats.format = new string[] { SHIPMessageFormat.JSON_UTF8 };

                byte[] handshakeMessageSerialized = handshakeMessage.ToJson();
                byte[] handshakeMessageBuffer = new byte[handshakeMessageSerialized.Length + 1];

                handshakeMessageBuffer[0] = SHIPMessageType.CONTROL;
                Buffer.BlockCopy(handshakeMessageSerialized, 0, handshakeMessageBuffer, 1, handshakeMessageSerialized.Length);

                await _wsClient.SendAsync(handshakeMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

                // wait for handshake response message from server
                byte[] handshakeResponse = new byte[256];
                WebSocketReceiveResult result = await _wsClient.ReceiveAsync(handshakeResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    return false;
                }

                if ((result.Count < 2) || (handshakeResponse[0] != SHIPMessageType.CONTROL))
                {
                    throw new Exception("Handshake message expected!");
                }

                byte[] handshakeResponseMessageBuffer = new byte[result.Count - 1];
                Buffer.BlockCopy(handshakeResponse, 1, handshakeResponseMessageBuffer, 0, result.Count - 1);

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    MissingMemberHandling = MissingMemberHandling.Error
                };

                string handshakeResponseMsg = Encoding.UTF8.GetString(handshakeResponseMessageBuffer);
                handshakeResponseMsg = JsonFromEEBUSJson(handshakeResponseMsg);

				SHIPHandshakeMessage handshakeMessageReceived = JsonConvert.DeserializeObject<SHIPHandshakeMessage>(handshakeResponseMsg, settings);
                if (handshakeMessageReceived == null)
                {
                    throw new Exception("Handshake message parsing failed!");
                }

                if (handshakeMessageReceived.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.select)
                {
                    throw new Exception("Protocol version selection expected!");
                }

                if (handshakeMessageReceived.messageProtocolHandshake.version.major != 1 && handshakeMessageReceived.messageProtocolHandshake.version.minor != 0)
                {
                    throw new Exception("Protocol version mismatch!");
                }

                if ((handshakeMessageReceived.messageProtocolHandshake.formats.format.Length > 0) && (handshakeMessageReceived.messageProtocolHandshake.formats.format[0] == SHIPMessageFormat.JSON_UTF8))
                {
                    // send the message back
                    byte[] handshakeReturn = new byte[result.Count];
                    Buffer.BlockCopy(handshakeResponse, 0, handshakeReturn, 0, result.Count);
                    await _wsClient.SendAsync(handshakeReturn, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

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
                    SHIPHandshakeErrorMessage handshakeErrorMessage = new SHIPHandshakeErrorMessage();

                    if (ex.Message.Contains("mismatch"))
                    {
                        handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
                    }
                    else
                    {
                        handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;
                    }
                    
                    byte[] handshakeMessageSerialized = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(handshakeErrorMessage));
                    byte[] handshakeMessageBuffer = new byte[handshakeMessageSerialized.Length + 1];

                    handshakeMessageBuffer[0] = SHIPMessageType.CONTROL;
                    Buffer.BlockCopy(handshakeMessageSerialized, 0, handshakeMessageBuffer, 1, handshakeMessageSerialized.Length);

                    await _wsClient.SendAsync(handshakeMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
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
				SHIPPinCheckMessage pincheckMessage = new SHIPPinCheckMessage();
				pincheckMessage.connectionPinState.pinState = PinStateType.none;

				byte[] pincheckMessageSerialized = pincheckMessage.ToJson();
				byte[] pincheckMessageBuffer = new byte[pincheckMessageSerialized.Length + 1];

				pincheckMessageBuffer[0] = SHIPMessageType.CONTROL;
				Buffer.BlockCopy(pincheckMessageSerialized, 0, pincheckMessageBuffer, 1, pincheckMessageSerialized.Length);

				await _wsClient.SendAsync(pincheckMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

				// wait for handshake response message from server
				byte[] pincheckResponse = new byte[256];
				WebSocketReceiveResult result = await _wsClient.ReceiveAsync(pincheckResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
				if (result.MessageType == WebSocketMessageType.Close)
				{
					return false;
				}

				if ((result.Count < 2) || (pincheckResponse[0] != SHIPMessageType.CONTROL))
				{
					throw new Exception("Pincheck message expected!");
				}

				byte[] pincheckResponseMessageBuffer = new byte[result.Count - 1];
				Buffer.BlockCopy(pincheckResponse, 1, pincheckResponseMessageBuffer, 0, result.Count - 1);

				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Include,
					MissingMemberHandling = MissingMemberHandling.Error
				};

				string pincheckResponseMsg = Encoding.UTF8.GetString(pincheckResponseMessageBuffer);
				pincheckResponseMsg = JsonFromEEBUSJson(pincheckResponseMsg);

				SHIPPinCheckMessage pincheckMessageReceived = JsonConvert.DeserializeObject<SHIPPinCheckMessage>(pincheckResponseMsg, settings);
				if (pincheckMessageReceived == null)
				{
					throw new Exception("Pincheck message parsing failed!");
				}

				if (pincheckMessageReceived.connectionPinState.pinState != PinStateType.none)
				{
					throw new Exception("Pinstate none expected!");
				}

				if (pincheckMessageReceived.connectionPinState.inputPermissionSpecified != false)
				{
					throw new Exception("Pinstate none expected!");
				}

				return true;
			}
			catch (Exception ex)
			{
				try
				{
					// send handshake error message
					SHIPHandshakeErrorMessage handshakeErrorMessage = new SHIPHandshakeErrorMessage();

					if (ex.Message.Contains("mismatch"))
					{
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
					}
					else
					{
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;
					}

					byte[] handshakeMessageSerialized = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(handshakeErrorMessage));
					byte[] handshakeMessageBuffer = new byte[handshakeMessageSerialized.Length + 1];

					handshakeMessageBuffer[0] = SHIPMessageType.CONTROL;
					Buffer.BlockCopy(handshakeMessageSerialized, 0, handshakeMessageBuffer, 1, handshakeMessageSerialized.Length);

					await _wsClient.SendAsync(handshakeMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
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
				AccessMethodsRequestMessage accessMethodsRequestMessage = new AccessMethodsRequestMessage();

				byte[] accessMethodsRequestMessageSerialized = accessMethodsRequestMessage.ToJson();
				byte[] accessMethodsRequestBuffer = new byte[accessMethodsRequestMessageSerialized.Length + 1];

				accessMethodsRequestBuffer[0] = SHIPMessageType.CONTROL;
				Buffer.BlockCopy(accessMethodsRequestMessageSerialized, 0, accessMethodsRequestBuffer, 1, accessMethodsRequestMessageSerialized.Length);

				await _wsClient.SendAsync(accessMethodsRequestBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

				// wait for handshake response message from server
				byte[] accessMethodsRequestResponse = new byte[256];
				WebSocketReceiveResult result = await _wsClient.ReceiveAsync(accessMethodsRequestResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
				if (result.MessageType == WebSocketMessageType.Close)
				{
					return false;
				}

				if ((result.Count < 2) || (accessMethodsRequestResponse[0] != SHIPMessageType.CONTROL))
				{
					throw new Exception("Pincheck message expected!");
				}

				byte[] accessMethodsRequestMessageBuffer = new byte[result.Count - 1];
				Buffer.BlockCopy(accessMethodsRequestResponse, 1, accessMethodsRequestMessageBuffer, 0, result.Count - 1);

				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Include,
					MissingMemberHandling = MissingMemberHandling.Error
				};

				string accessMethodsRequestMsg = Encoding.UTF8.GetString(accessMethodsRequestMessageBuffer);
				accessMethodsRequestMsg = JsonFromEEBUSJson(accessMethodsRequestMsg);

				AccessMethodsRequestMessage accessMethodsRequestReceived = JsonConvert.DeserializeObject<AccessMethodsRequestMessage>(accessMethodsRequestMsg, settings);
				if (accessMethodsRequestReceived == null)
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
					SHIPHandshakeErrorMessage handshakeErrorMessage = new SHIPHandshakeErrorMessage();

					if (ex.Message.Contains("mismatch"))
					{
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
					}
					else
					{
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;
					}

					byte[] handshakeMessageSerialized = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(handshakeErrorMessage));
					byte[] handshakeMessageBuffer = new byte[handshakeMessageSerialized.Length + 1];

					handshakeMessageBuffer[0] = SHIPMessageType.CONTROL;
					Buffer.BlockCopy(handshakeMessageSerialized, 0, handshakeMessageBuffer, 1, handshakeMessageSerialized.Length);

					await _wsClient.SendAsync(handshakeMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
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
				AccessMethodsMessage accessMethodsMessage = new AccessMethodsMessage();
                accessMethodsMessage.accessMethods.id = "Demo-CSharp-987654321";

				byte[] accessMethodsMessageSerialized = accessMethodsMessage.ToJson();
				byte[] accessMethodsBuffer = new byte[accessMethodsMessageSerialized.Length + 1];

				accessMethodsBuffer[0] = SHIPMessageType.CONTROL;
				Buffer.BlockCopy(accessMethodsMessageSerialized, 0, accessMethodsBuffer, 1, accessMethodsMessageSerialized.Length);

				await _wsClient.SendAsync(accessMethodsBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

				// wait for handshake response message from server
				byte[] accessMethodsResponse = new byte[256];
				WebSocketReceiveResult result = await _wsClient.ReceiveAsync(accessMethodsResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
				if (result.MessageType == WebSocketMessageType.Close)
				{
					return false;
				}

				if ((result.Count < 2) || (accessMethodsResponse[0] != SHIPMessageType.CONTROL))
				{
					throw new Exception("Access methods message expected!");
				}

				byte[] accessMethodsMessageBuffer = new byte[result.Count - 1];
				Buffer.BlockCopy(accessMethodsResponse, 1, accessMethodsMessageBuffer, 0, result.Count - 1);

				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Include,
					MissingMemberHandling = MissingMemberHandling.Error
				};

				string accessMethodsMsg = Encoding.UTF8.GetString(accessMethodsMessageBuffer);
				accessMethodsMsg = JsonFromEEBUSJson(accessMethodsMsg);

				AccessMethodsMessage accessMethodsReceived = JsonConvert.DeserializeObject<AccessMethodsMessage>(accessMethodsMsg, settings);
				if (accessMethodsReceived == null)
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
					SHIPHandshakeErrorMessage handshakeErrorMessage = new SHIPHandshakeErrorMessage();

					if (ex.Message.Contains("mismatch"))
					{
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.SELECTION_MISMATCH;
					}
					else
					{
						handshakeErrorMessage.messageProtocolHandshakeError.error = SHIPHandshakeError.UNEXPECTED_MESSAGE;
					}

					byte[] handshakeMessageSerialized = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(handshakeErrorMessage));
					byte[] handshakeMessageBuffer = new byte[handshakeMessageSerialized.Length + 1];

					handshakeMessageBuffer[0] = SHIPMessageType.CONTROL;
					Buffer.BlockCopy(handshakeMessageSerialized, 0, handshakeMessageBuffer, 1, handshakeMessageSerialized.Length);

					await _wsClient.SendAsync(handshakeMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
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
                    SHIPCloseMessage closeMessage = new SHIPCloseMessage();
                    closeMessage.connectionClose[0].phase = ConnectionClosePhaseType.announce;

                    byte[] closeMessageSerialized = closeMessage.ToJson();
                    byte[] closeMessageBuffer = new byte[closeMessageSerialized.Length + 1];

                    closeMessageBuffer[0] = SHIPMessageType.END;
                    Buffer.BlockCopy(closeMessageSerialized, 0, closeMessageBuffer, 1, closeMessageSerialized.Length);

                    await _wsClient.SendAsync(closeMessageBuffer, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);

                    // wait for close response message from server
                    byte[] closeResponse = new byte[1024];
                    WebSocketReceiveResult result = await _wsClient.ReceiveAsync(closeResponse, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        return await Disconnect().ConfigureAwait(false);
                    }

                    if ((result.Count < 2) || (closeResponse[0] != SHIPMessageType.END))
                    {
                        throw new Exception("Close message expected!");
                    }

                    byte[] closeResponseMessageBuffer = new byte[result.Count - 1];
                    Buffer.BlockCopy(closeResponse, 1, closeResponseMessageBuffer, 0, result.Count - 1);

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Include,
                        MissingMemberHandling = MissingMemberHandling.Error
                    };

                    string closeResponseMessage = Encoding.UTF8.GetString(closeResponseMessageBuffer);
					SHIPCloseMessage closeMessageReceived = JsonConvert.DeserializeObject<SHIPCloseMessage>(closeResponseMessage, settings);
                    if (closeMessageReceived == null)
                    {
                        throw new Exception("Close message parsing failed!");
                    }

                    if (closeMessageReceived.connectionClose[0].phase != ConnectionClosePhaseType.confirm)
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
