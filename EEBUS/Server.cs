using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

using EEBUS.Messages;
using EEBUS.SHIP.Messages;
using EEBUS.SPINE.Commands;
using Newtonsoft.Json.Linq;

namespace EEBUS
{
	/// <summary>
	/// Eine Server Instanz verwaltet eine Websocket Instanz, die mit einem wss:// Aufruf von einem anderen Device entstanden ist
	/// Es wird auf ankommende Nachrichten gewartet und meist mit Echo darauf reagiert
	/// </summary>
	public class Server : Connection
	{
		public Server( string host, WebSocket ws, Settings settings )
			: base( host, ws, settings )
		{
		}

		static private ConcurrentDictionary<string, Server> serverMap = new ConcurrentDictionary<string, Server>();
		
		static public Server Get( string host )
		{
			if ( ! serverMap.TryGetValue( host, out Server server ) )
				return null;

			return server;
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

					(this.state, this.subState, string error) = message.ServerTest( this.state );

					if ( this.state == State.Stop && error != null )
						throw new Exception( error );
					if ( error != null )
						Console.WriteLine( error );

					(this.state, this.subState) = await message.NextServerState( this.ws, this.state, this.subState ).ConfigureAwait( false );

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
	}
}