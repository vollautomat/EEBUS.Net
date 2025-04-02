using System;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Tasks;

using EEBUS.Enums;
using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class InitMessage : JsonInitMessage<InitMessage>
	{
		static InitMessage()
		{
			Register( new Class() );
		}

		public InitMessage()
		{
		}

		public new class Class : JsonInitMessage<InitMessage>.Class
		{
			public override InitMessage Create( byte[] data )
			{
				return template.FromJsonVirtual( data );
			}
		}

		public override byte[] bytes { get; set; } = { SHIPMessageType.INIT, SHIPMessageValue.CMI_HEAD };


		public override (Server.State, Server.SubState, string) Test( Server.State state )
		{
			string		 error	  = null;
			Server.State newState = state;

			if ( this.bytes[1] != SHIPMessageValue.CMI_HEAD )
			{
				error = "Expected SMI_HEAD payload in INIT message!";
				newState = Server.State.Stop;
			}

			return (newState, Server.SubState.None, error);
		}

#pragma warning disable CS1998
		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
#pragma warning restore CS1998
		{
			if ( state == Server.State.WaitingForInit || state == Server.State.WaitingForCloseInitOrData )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.WaitingForConnectionHello, Server.SubState.None);
			}

			throw new Exception( "Was waiting for Init" );
		}

		public override (Client.State, Client.SubState, string) Test( Client.State state )
		{
			string		 error	  = null;
			Client.State newState = state;

			if ( this.bytes[1] != SHIPMessageValue.CMI_HEAD )
			{
				error = "Expected SMI_HEAD payload in INIT message!";
				newState = Client.State.Stop;
			}

			return (newState, Client.SubState.None, error);
		}

#pragma warning disable CS1998
		public override async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subSate )
#pragma warning restore CS1998
		{
			if ( state == Client.State.WaitingForInit || state == Client.State.WaitingForCloseInitOrData )
			{
				ConnectionHelloMessage message = new ConnectionHelloMessage( ConnectionHelloPhaseType.ready, 60000 );
				await message.Send( ws ).ConfigureAwait( false );

				return (Client.State.WaitingForConnectionHello, Client.SubState.None);
			}

			throw new Exception( "Was waiting for Init" );
		}
	}
}
