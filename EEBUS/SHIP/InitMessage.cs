using System;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Tasks;

using EEBUS.Enums;
using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class InitMessage : ShipInitMessage<InitMessage>
	{
		static InitMessage()
		{
			Register( new Class() );
		}

		public InitMessage()
		{
		}

		public new class Class : ShipInitMessage<InitMessage>.Class
		{
			public override InitMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			}
		}

		public override byte[] bytes { get; set; } = { SHIPMessageType.INIT, SHIPMessageValue.CMI_HEAD };


		public override (Connection.State, Connection.SubState, string) ServerTest( Connection.State state )
		{
			string		 error	  = null;
			Connection.State newState = state;

			if ( this.bytes[1] != SHIPMessageValue.CMI_HEAD )
			{
				error = "Expected SMI_HEAD payload in INIT message!";
				newState = Connection.State.Stop;
			}

			return (newState, Connection.SubState.None, error);
		}

#pragma warning disable CS1998
		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
#pragma warning restore CS1998
		{
			if ( state == Connection.State.WaitingForInit || state == Connection.State.Connected )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Connection.State.WaitingForConnectionHello, Connection.SubState.None);
			}

			throw new Exception( "Was waiting for Init" );
		}

		public override (Connection.State, Connection.SubState, string) ClientTest( Connection.State state )
		{
			string		 error	  = null;
			Connection.State newState = state;

			if ( this.bytes[1] != SHIPMessageValue.CMI_HEAD )
			{
				error = "Expected SMI_HEAD payload in INIT message!";
				newState = Connection.State.Stop;
			}

			return (newState, Connection.SubState.None, error);
		}

#pragma warning disable CS1998
		public override async Task<(Connection.State, Connection.SubState)> NextClientState( WebSocket ws, Connection.State state, Connection.SubState subSate )
#pragma warning restore CS1998
		{
			if ( state == Connection.State.WaitingForInit || state == Connection.State.Connected )
			{
				ConnectionHelloMessage message = new ConnectionHelloMessage( ConnectionHelloPhaseType.ready, 60000 );
				await message.Send( ws ).ConfigureAwait( false );

				return (Connection.State.WaitingForConnectionHello, Connection.SubState.None);
			}

			throw new Exception( "Was waiting for Init" );
		}
	}
}
