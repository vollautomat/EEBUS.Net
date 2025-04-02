using System;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

using EEBUS.Enums;
using EEBUS.Messages;

namespace EEBUS
{
	/// <summary>
	/// Eine Server Instanz verwaltet eine Websocket Instanz, die mit einem wss:// Aufruf von einem anderen Device entstanden ist
	/// Es wird auf ankommende Nachrichten gewartet und meist mit Echo darauf reagiert
	/// </summary>
	public class Server
	{
		public Server( string host, WebSocket ws )
		{
			this.host  = host;
			this.ws	   = ws;
			this.state = State.WaitingForInit;
		}

		static private ConcurrentDictionary<string, Server> serverMap = new ConcurrentDictionary<string, Server>();
		
		private string	  host;
		private WebSocket ws;
		private State	  state;
		private SubState  subState;

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

		static public Server Get( string host )
		{
			if ( ! serverMap.TryGetValue( host, out Server server ) )
				return null;

			return server;
		}

		public async Task Do()
		{
			try
			{
                while ( this.ws.State == WebSocketState.Open )
                {
					byte[] receiveBuffer = new byte[1024];
					WebSocketReceiveResult result = await this.ws.ReceiveAsync( receiveBuffer, new CancellationTokenSource( SHIPMessageTimeout.CMI_TIMEOUT ).Token ).ConfigureAwait( false );

					if ( result.CloseStatus.HasValue )						
						break; // close received
					else if ( result.Count < 2 )
						throw new Exception( "Invalid EEBUS payload received, expected message size of at least 2!" );

					JsonMessageBase message = JsonMessageBase.Create( receiveBuffer );					
					if ( message == null )
						throw new Exception( "Message couldn't be recognized" );

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
				Console.WriteLine( "Exception: " + ex.Message );
			}

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

			Console.WriteLine( $"Closed websocket for connectedNode {this.host}. Remaining active connectedNodes : {serverMap.Count}" );
		}
	}
}