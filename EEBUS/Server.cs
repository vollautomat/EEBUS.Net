using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

using EEBUS.Enums;
using EEBUS.Messages;
using EEBUS.SHIP.Messages;
using EEBUS.SPINE.Commands;
using Microsoft.AspNetCore.Hosting.Server;
using Newtonsoft.Json.Linq;
using AddressType = EEBUS.Messages.AddressType;

namespace EEBUS
{
	/// <summary>
	/// Eine Server Instanz verwaltet eine Websocket Instanz, die mit einem wss:// Aufruf von einem anderen Device entstanden ist
	/// Es wird auf ankommende Nachrichten gewartet und meist mit Echo darauf reagiert
	/// </summary>
	public class Server
	{
		public Server( string host, WebSocket ws, Settings settings )
		{
			this.host  = host;
			this.ws	   = ws;
			this.state = State.WaitingForInit;

			Server.settings = settings;
		}

		static private ConcurrentDictionary<string, Server> serverMap = new ConcurrentDictionary<string, Server>();
		
		private string	  host;
		private WebSocket ws;
		private State	  state;
		private SubState  subState;

		private AddressType heartbeatSource;
		private AddressType heartbeatDestination;

		static private Settings settings;

		public enum State
		{
			WaitingForInit,
			WaitingForConnectionHello,
			WaitingForProtocolHandshake,
			SendProtocolHandshakeError,
			SendProtocolHandshakeConfirm,
			WaitingForProtocolHandshakeConfirm,
			WaitingForPinCheck,
			WaitingForAccessMethodsRequest,
			WaitingForAccessMethods,
			WaitingForCloseInitOrData,
			Stop,
			ErrorOrTimeout
		}

		public enum SubState
		{
			None,
			FirstPending,
			SecondPending,
			UnexpectedMessage,
			FormatMismatch
		}

		public static Settings Settings { get { return settings; } }

		static public Server Get( string host )
		{
			if ( ! serverMap.TryGetValue( host, out Server server ) )
				return null;

			return server;
		}

		class Heart
		{
			// This method is called by the timer delegate.
			public async void Beat( object serverObj )
			{
				Server server = (Server) serverObj;
				
				if ( server.state == Server.State.WaitingForCloseInitOrData )
				{
					Debug.WriteLine( "--- Heartbeat senden ---" );

					SpineDatagramPayload reply = new SpineDatagramPayload();
					reply.datagram.header.addressSource		 = server.heartbeatSource;
					reply.datagram.header.addressDestination = server.heartbeatDestination;
					reply.datagram.header.msgCounter		 = DataMessage.NextCount;
					reply.datagram.header.cmdClassifier		 = "notify";

					DeviceDiagnosisHeartbeatData heartbeat = new DeviceDiagnosisHeartbeatData();
					reply.datagram.payload = JObject.FromObject( heartbeat );
					
					DataMessage heartbeatMessage = new DataMessage();
					heartbeatMessage.SetPayload( JObject.FromObject( reply ) );

					await heartbeatMessage.Send( server.ws ).ConfigureAwait( false );
				}
			}
		}

		public async Task Do()
		{
			var heart = new Heart();
			var beat  = new System.Threading.Timer( heart.Beat, this, 4000, 4000 );
			
			try
			{
                while ( this.ws.State == WebSocketState.Open )
                {
					byte[] receiveBuffer = new byte[10240];
					WebSocketReceiveResult result = await this.ws.ReceiveAsync( receiveBuffer, new CancellationTokenSource( /*SHIPMessageTimeout.CMI_TIMEOUT*/ ).Token ).ConfigureAwait( false );

					if ( result.CloseStatus.HasValue )						
						break; // close received
					else if ( result.Count < 2 )
						throw new Exception( "Invalid EEBUS payload received, expected message size of at least 2!" );

					ShipMessageBase message = ShipMessageBase.Create( receiveBuffer, this );					
					if ( message == null )
						throw new Exception( "Message couldn't be recognized" );

					Debug.WriteLine( "===> " + message.ToString() );

					(this.state, this.subState, string error) = message.Test( this.state );

					if ( this.state == State.Stop && error != null )
						throw new Exception( error );
					if ( error != null )
						Console.WriteLine( error );

					(this.state, this.subState) = await message.NextState( this.ws, this.state, this.subState ).ConfigureAwait( false );

					if ( this.state == State.Stop )
						throw new Exception( "Communication stopped!" );
				}
			}
			catch ( Exception ex )
			{
				Debug.WriteLine( "Exception: " + ex.Message );
			}

			beat.Change( Timeout.Infinite, Timeout.Infinite );
			await Close().ConfigureAwait( false );
		}

		public async Task Close()
		{
			try
			{
				await this.ws.CloseOutputAsync( WebSocketCloseStatus.NormalClosure, "Closing!", CancellationToken.None ).ConfigureAwait( false );
			}
			catch ( Exception ex )
			{
				Console.WriteLine( "Exception: " + ex.Message );
			}

			serverMap.TryRemove( this.host, out _ );

			Debug.WriteLine( $"Closed websocket for connectedNode {this.host}. Remaining active connectedNodes : {serverMap.Count}" );
		}

		public void SetHeartbeatAddresses( AddressType source, AddressType destination )
		{
			this.heartbeatSource	  = source;
			this.heartbeatDestination = destination;
		}
	}
}