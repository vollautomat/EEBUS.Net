using System.Net.WebSockets;
using System.Diagnostics;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

using EEBUS.Models;
using EEBUS.SHIP.Messages;

namespace EEBUS.Controllers;

[ApiController]
[Route("[controller]")]
public class DevicesController : ControllerBase, IDisposable
{
	private readonly ILogger<DevicesController> logger;

	public DevicesController( Devices devices, MDNSClient mDNSClient, MDNSService mDNSService, ILogger<DevicesController> logger )
	{
		this.mDNSClient	 = mDNSClient;
		this.mDNSService = mDNSService;
		this.devices	 = devices;

		this.logger		 = logger;
	}

	public void Dispose()
	{
	}

	private Devices devices;

	private readonly MDNSClient	 mDNSClient;
	private readonly MDNSService mDNSService;
	private ClientWebSocket?	 wsClient;


	[HttpGet("GetLocal")]
	public JObject GetLcal()
	{
		LocalDevice? local = this.devices?.Local;

		if ( null == local )
			return new();

		return JObject.FromObject( new
		{
			name   = local.Name,
			ski	   = local.SKI.ToReadable(),
			shipId = local.ShipID
		} );
	}


	[HttpGet("GetRemotes")]
	public JArray GetRemotes()
	{
		JArray devlist = new();

		this.devices?.Remote.ForEach( rd =>
		{
			devlist.Add( JObject.FromObject( new
			{
				id			= rd.Id,
				name		= rd.Name,
				ski			= rd.SKI.ToReadable(),
				url			= rd.Url,
				serverState	= rd.serverState.ToString(),
				clientState	= rd.clientState.ToString()
			} ) );
		} );

		return devlist;
	}

	[HttpGet("Connect")]
	public async Task Connect( string ski )
	{
		SKI Ski = new SKI( ski );
		
		RemoteDevice? device = this.devices.Remote.FirstOrDefault( rd => rd.SKI == Ski );
		if ( null == device )
			return;

		try
		{
			Uri uri = new Uri( "wss://" + device.Url );

			this.wsClient = new ClientWebSocket();
			this.wsClient.Options.AddSubProtocol( "ship" );
			this.wsClient.Options.RemoteCertificateValidationCallback = ValidateServerCert;
			this.wsClient.Options.ClientCertificates.Add( this.mDNSService.Cert );
			await this.wsClient.ConnectAsync( uri, CancellationToken.None ).ConfigureAwait( false );

			if ( this.wsClient.State == WebSocketState.Open )
			{
				HostString hostString = new HostString( uri.Host, uri.Port );

				Client client = new Client( hostString, wsClient, this.devices, device );

				await client.Run().ConfigureAwait( false );
			}
			else
			{
				await Disconnect().ConfigureAwait( false );
			}

			return;
		}
		catch ( Exception ex )
		{
			Debug.WriteLine( "Connect Error: " + ex.Message );
		}
	}

	private bool ValidateServerCert( object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors )
	{
		//// extract SKI
		//foreach ( X509Extension extension in ((X509Certificate2)certificate).Extensions )
		//{
		//	if (extension.Oid.FriendlyName == "Subject Key Identifier" || extension.Oid.FriendlyName == "Schlüsselkennung des Antragstellers")
		//	{
		//		X509SubjectKeyIdentifierExtension ext = (X509SubjectKeyIdentifierExtension)extension;
		//		model.SKI = ext.SubjectKeyIdentifier.ToLowerInvariant();

		//		// add spaces every 4 hex digits (EEBUS requirement)
		//		for (int i = 4; i < model.SKI.Length; i += 4)
		//			model.SKI = model.SKI.Insert(i++, " ");

		//		break;
		//	}
		//}

		return true;
	}

	[HttpGet("Disconnect")]
	public async Task Disconnect()
	{
		try
		{
			if ( this.wsClient == null )
				return;
			
			// send close message
			CloseMessage closeMessage = new CloseMessage( ConnectionClosePhaseType.announce );
			await closeMessage.Send( this.wsClient );

			// wait for close response message from server
			closeMessage = await CloseMessage.Receive( this.wsClient );

			if ( closeMessage == null )
			{
				throw new Exception( "Close message parsing failed!" );
			}

			if ( closeMessage.connectionClose[0].phase != ConnectionClosePhaseType.confirm )
			{
				throw new Exception( "Close confirmation message expected!" );
			}

			// now close websocket
			await this.wsClient.CloseAsync (WebSocketCloseStatus.NormalClosure, null, CancellationToken.None ).ConfigureAwait( false );
			this.wsClient.Dispose();
			this.wsClient = null;
		}
		catch ( Exception ex )
		{
			Debug.WriteLine( "Disconnect Error: " + ex.Message );
		}
	}
}
