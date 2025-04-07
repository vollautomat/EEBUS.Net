
using System;
using System.Net.Security;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using EEBUS.Models;
using EEBUS.SHIP.Messages;
using Newtonsoft.Json.Linq;

namespace EEBUS.Controllers
{
	public class BrowserController : Controller
    {
        private readonly MDNSClient      mDNSClient;
		private readonly MDNSService     mDNSService;
		private readonly Settings        settings;
		private static   ClientWebSocket wsClient;

		private ServerNode model = new ServerNode();

        public BrowserController( MDNSClient mDNSClient, MDNSService mDNSService, IOptions<Settings> options )
        {
            this.mDNSClient     = mDNSClient;
            this.mDNSService    = mDNSService;
            this.settings       = options.Value;

			this.model.LocalSKI = this.mDNSService.LocalSKI;
		}

		public IActionResult Index()
        {
            try
            {
                return View( "Index", new ServerNodes() { Nodes = mDNSClient.getEEBUSNodes(), LocalSKI = model.LocalSKI } );
            }
            catch (Exception ex)
            {
                model.Error = "Error: " + ex.Message;
                return View( "Index", new ServerNodes() { Nodes = new ServerNode[] { model }, LocalSKI = model.LocalSKI } );
            }
        }

        private bool ValidateServerCert( object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors )
        {
            // extract SKI
            foreach ( X509Extension extension in ((X509Certificate2) certificate).Extensions )
            {
                if ( extension.Oid.FriendlyName == "Subject Key Identifier" || extension.Oid.FriendlyName == "Schlüsselkennung des Antragstellers" )
                {
                    X509SubjectKeyIdentifierExtension ext = (X509SubjectKeyIdentifierExtension) extension;
                    model.SKI = ext.SubjectKeyIdentifier.ToLowerInvariant();

                    // add spaces every 4 hex digits (EEBUS requirement)
                    for ( int i = 4; i < model.SKI.Length; i += 4 )
                        model.SKI = model.SKI.Insert( i++, " " );

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
                foreach ( string key in Request.Form.Keys )
                {
                    if (key.Contains("EEBUS:"))
                    {
                        string[] parts = key.Split('|');
                        model.Name = parts[1];
                        model.Id   = parts[2];
                        model.Url  = parts[3];
                        break;
                    }
                }

                wsClient = new ClientWebSocket();
                wsClient.Options.AddSubProtocol( "ship" );
                wsClient.Options.RemoteCertificateValidationCallback = ValidateServerCert;
				wsClient.Options.ClientCertificates.Add( mDNSService.Cert );
                await wsClient.ConnectAsync( new Uri( "wss://" + model.Url ), CancellationToken.None ).ConfigureAwait( false );
                
                return View( "Accept", model );
            }
            catch ( Exception ex )
            {
                model.Error = "Error: " + ex.Message;
                return View( "Index", new ServerNodes() { Nodes = new ServerNode[] { model }, LocalSKI = model.LocalSKI } );
            }
        }

        [HttpPost]
        public async Task<IActionResult> Accept()
        {
            try
            {
                foreach ( string key in Request.Form.Keys )
                {
                    if ( key.Contains( "EEBUS:" ) )
                    {
                        string[] parts = key.Split( '|' );
                        model.Name = parts[1];
                        model.Id   = parts[2];
                        model.Url  = parts[3];
                        break;
                    }
                }

                if ( wsClient.State == WebSocketState.Open )
                {
                    Client client = new Client( model.Url, wsClient, this.settings );

                    await client.Connect().ConfigureAwait( false );
					
                    return View( "Connected", model );
                }
                else
                {
                    return await Disconnect().ConfigureAwait( false );
                }
            }
            catch ( Exception ex )
            {
                return await Disconnect( ex.Message ).ConfigureAwait( false );
            }
        }

        [HttpPost]
        public async Task<IActionResult> SendTestData()
        {
            return await SendData( "SPINE test data" ).ConfigureAwait( false );
        }

        //[HttpPost]
        //public async Task<IActionResult> SendSPINEData( SPINE spine )
        //{
        //    foreach (string key in Request.Form.Keys)
        //    {
        //        if (key.Contains("EEBUS:"))
        //        {
        //            string[] parts = key.Split('|');
        //            model.Name = parts[1];
        //            model.Id = parts[2];
        //            model.Url = parts[3];
        //            break;
        //        }
        //    }

        //    return await SendData(spine.GenerateDatagram(model.Url)).ConfigureAwait(false);
        //}


        private async Task<IActionResult> SendData( object payload )
        {
            try
            {
                foreach ( string key in Request.Form.Keys )
                {
                    if ( key.Contains( "EEBUS:" ) )
                    {
                        string[] parts = key.Split('|');
                        model.Name = parts[1];
                        model.Id   = parts[2];
                        model.Url  = parts[3];
                        break;
                    }
                }

                if ( wsClient.State == WebSocketState.Open )
                {
                    // send data message
                    DataMessage dataMessage = new DataMessage( "spine", JObject.FromObject( payload ) );
                    await dataMessage.Send( wsClient );

                    // wait for data response message from server
                    dataMessage = await DataMessage.Receive( wsClient );

                    if ( dataMessage == null )
						return await Disconnect().ConfigureAwait( false );

					if ( (dataMessage.data == null) || (dataMessage.data.payload == null) )
                    {
                        throw new Exception( "Data message parsing failed!" );
                    }
                    else
                    {
                        model.LatestDataReceived = dataMessage.data.payload.ToString();
                    }

                    return View( "Connected", model );
                }
                else
                {
                    return await Disconnect().ConfigureAwait( false );
                }
            }
            catch ( Exception ex )
            {
                return await Disconnect( ex.Message ).ConfigureAwait( false );
            }
        }

		[HttpPost]
        public async Task<IActionResult> Disconnect( string errorMessage = null )
        {
            try
            {
                if ( wsClient != null )
                {
                    // send close message
                    CloseMessage closeMessage = new CloseMessage( ConnectionClosePhaseType.announce );
                    await closeMessage.Send( wsClient );

                    // wait for close response message from server
                    closeMessage = await CloseMessage.Receive( wsClient );

                    if ( closeMessage == null )
                    {
                        throw new Exception( "Close message parsing failed!" );
                    }

                    if ( closeMessage.connectionClose[0].phase != ConnectionClosePhaseType.confirm )
                    {
                        throw new Exception( "Close confirmation message expected!" );
                    }

                    // now close websocket
                    await wsClient.CloseAsync( WebSocketCloseStatus.NormalClosure, null, CancellationToken.None ).ConfigureAwait( false );
                    wsClient.Dispose();
                    wsClient = null;
                }

                if ( string.IsNullOrEmpty(errorMessage ) )
                {
                    return View( "Index", new ServerNodes() { Nodes = mDNSClient.getEEBUSNodes(), LocalSKI = model.LocalSKI } );
                }
                else
                {
                    model.Error = "Error: " + errorMessage;
                    return View( "Index", new ServerNodes() { Nodes = new ServerNode[] { model }, LocalSKI = model.LocalSKI } );
                }
            }
            catch ( Exception )
            {
                return View( "Index", new ServerNodes() { Nodes = mDNSClient.getEEBUSNodes(), LocalSKI = model.LocalSKI } );
            }
        }
    }
}
