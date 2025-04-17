﻿using System.Net.WebSockets;
using System.Text;

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

using EEBUS.Models;

namespace EEBUS.Controllers
{
	[Route( "[controller]" )]
	[ApiController]
	public class PushDataController : ControllerBase, IDisposable
	{
		public PushDataController( Devices devices )
		{
			this.devices = devices;
			//this.timer = new Timer( PushTimer, null, 3000, 3000 );

			this.devices.RemoteDeviceFound  += OnRemoteDeviceFound;
			this.devices.ServerStateChanged += OnServerStateChanged;
			this.devices.ClientStateChanged += OnClientStateChanged;
		}

		public void Dispose()
		{
			this.devices.RemoteDeviceFound  -= OnRemoteDeviceFound;
			this.devices.ServerStateChanged -= OnServerStateChanged;
			this.devices.ClientStateChanged -= OnClientStateChanged;
		}

		static private List<WebSocket> webSockets = new List<WebSocket>();
		//private Timer timer;

		private Devices devices;

		private void OnRemoteDeviceFound( RemoteDevice device )
		{
			using var _ = Push( new RemoteDeviceFound( device ) );
		}

		private void OnServerStateChanged( Connection.EState state, RemoteDevice device )
		{
			using var _ = Push( new ServerStateChanged( device, state ) );
		}

		private void OnClientStateChanged( Connection.EState state, RemoteDevice device )
		{
			using var _ = Push( new ClientStateChanged( device, state ) );
		}

		//private async void PushTimer( object? state )
		//{
		//	JObject test = JObject.FromObject( new { msg = "hello", status = "ok" } );
		//	await Push( test );
		//}

		static public bool HasListeners()
		{
			return 0 < webSockets.Count;
		}

		[HttpGet( "/ws/register" )]
		public async Task Register()
		{
			if ( HttpContext.WebSockets.IsWebSocketRequest )
			{
				var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
				webSockets.Add( webSocket );
				Console.WriteLine( "Listener eingetragen" );

				//this.host.ListenerAdded();

				await Echo( HttpContext, webSocket );
			}
			else
			{
				HttpContext.Response.StatusCode = 400;
			}
		}

		private async Task Echo( HttpContext context, WebSocket webSocket )
		{
			var buffer = new byte[1024 * 4];
			WebSocketReceiveResult? result = null;
			try
			{
				result = await webSocket.ReceiveAsync( new ArraySegment<byte>( buffer ), CancellationToken.None );
			}
			catch ( Exception ex )
			{
				webSockets.Remove( webSocket );
				Console.WriteLine( "Listener wieder ausgetragen, Error: " + ex.Message );
				return;
			}

			Console.WriteLine( "Echoschleife Start" );

			while ( ! result.CloseStatus.HasValue )
			{
				string msg = Encoding.UTF8.GetString( buffer ).Substring( 0, result.Count );
				int count = result.Count;

				Console.WriteLine( "Nachricht empfangen: " + msg );

				var responseMsg = Encoding.UTF8.GetBytes( msg );
				Array.Copy( responseMsg, buffer, count );

				await webSocket.SendAsync( new ArraySegment<byte>( buffer, 0, count ), result.MessageType, result.EndOfMessage, CancellationToken.None );
				Console.WriteLine( "Antwort gesendet: " + msg );

				result = await webSocket.ReceiveAsync( new ArraySegment<byte>( buffer ), CancellationToken.None );
			}

			await webSocket.CloseAsync( result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None );

			webSockets.Remove( webSocket );
			Console.WriteLine( "Listener ausgetragen" );
		}

		static public async Task Push( JToken data )
		{
			if ( 0 == webSockets.Count )
				return;

			string json   = data.ToString();
			byte[] buffer = Encoding.UTF8.GetBytes( json );
			int	   count  = buffer.Length;

			foreach ( WebSocket webSocket in webSockets.ToArray() )
			{
				try
				{
					await webSocket.SendAsync( new ArraySegment<byte>( buffer, 0, count ), WebSocketMessageType.Text, true, CancellationToken.None );
				}
				catch ( Exception ex )
				{
					webSockets.Remove( webSocket );
					Console.WriteLine( "Listener ausgetragen, Error: " + ex.Message );
				}
			}
		}
	}
}
