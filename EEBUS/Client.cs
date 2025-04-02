using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

using EEBUS.Enums;
using EEBUS.Messages;
using EEBUS.SHIP.Messages;

namespace EEBUS
{
	public class Client
	{
		public Client( string host, WebSocket ws )
		{
			this.host = host;
			this.ws	  = ws;
		}

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
			Connected,
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

		public async Task<bool> Connect()
		{
			this.state	  = State.WaitingForInit;
			this.subState = SubState.None;

			InitMessage initMessage = new InitMessage();
			await initMessage.Send( this.ws ).ConfigureAwait( false );

			while ( this.state != State.Connected )
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
				else if ( this.state == State.Connected )
					break;
			}

			return true;
		}
	}
}
