using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

using EEBUS.Enums;
using EEBUS.Messages;
using EEBUS.SHIP.Messages;

namespace EEBUS
{
	public class Client : Connection
	{
		public Client( string host, WebSocket ws, Settings settings )
			: base( host, ws, settings )
		{
		}

		public async Task<bool> Run()
		{
			this.state	  = State.WaitingForInit;
			this.subState = SubState.None;

			InitMessage initMessage = new InitMessage();
			await initMessage.Send( this.ws ).ConfigureAwait( false );

			var heart = new Heart();
			var beat  = new System.Threading.Timer( heart.Beat, this, 4000, 4000 );

			try
			{
				while ( this.state != State.Stop )
				{
					byte[] receiveBuffer = new byte[10240];
					WebSocketReceiveResult result = await this.ws.ReceiveAsync( receiveBuffer, new CancellationTokenSource( SHIPMessageTimeout.CMI_TIMEOUT ).Token ).ConfigureAwait( false );

					if ( result.CloseStatus.HasValue )						
						break; // close received
					else if ( result.Count < 2 )
						throw new Exception( "Invalid EEBUS payload received, expected message size of at least 2!" );

					ShipMessageBase message = ShipMessageBase.Create( receiveBuffer, this );					
					if ( message == null )
						throw new Exception( "Message couldn't be recognized" );

					(this.state, this.subState, string error) = message.ClientTest( this.state );

					if ( this.state == State.Stop && error != null )
						throw new Exception( error );
					if ( error != null )
						Console.WriteLine( error );

					(this.state, this.subState) = await message.NextClientState( this.ws, this.state, this.subState ).ConfigureAwait( false );

					//if ( this.state == State.Stop )
					//	throw new Exception( "Communication stopped!" );
					//else if ( this.state == State.Connected )
					//	break;
				}
			}
			finally
			{
				beat.Change( Timeout.Infinite, Timeout.Infinite );
			}

			return true;
		}
	}
}
