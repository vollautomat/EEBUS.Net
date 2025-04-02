using System;
using System.Net.WebSockets;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Newtonsoft.Json.Converters;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class ConnectionHelloMessage : JsonControlMessage<ConnectionHelloMessage>
	{
		static ConnectionHelloMessage()
		{
			Register( new Class() );
		}

		public ConnectionHelloMessage()
		{
		}

		public ConnectionHelloMessage( ConnectionHelloPhaseType phase )
		{
			this.connectionHello.phase = phase;
		}

		public ConnectionHelloMessage( ConnectionHelloPhaseType phase, uint waiting )
		{
			this.connectionHello.phase   = phase;
			this.connectionHello.waiting = waiting;
		}

		public new class Class : JsonControlMessage<ConnectionHelloMessage>.Class
		{
			public override ConnectionHelloMessage Create( byte[] data )
			{
				return template.FromJsonVirtual( data );
			}
		}

		public ConnectionHelloType connectionHello { get; set; } = new ConnectionHelloType();

		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.ready )
			{
				await Send( ws ).ConfigureAwait( false ) ;
				return (Server.State.WaitingForProtocolHandshake, Server.SubState.None);
			}
			
			if ( state == Server.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Server.SubState.None )
			{
				await Send( ws ).ConfigureAwait( false ) ;
				return (Server.State.WaitingForProtocolHandshake, Server.SubState.FirstPending);
			}

			if ( state == Server.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Server.SubState.FirstPending )
			{
				await Send( ws).ConfigureAwait( false );
				return (Server.State.WaitingForProtocolHandshake, Server.SubState.SecondPending);
			}

			if ( state == Server.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Server.SubState.SecondPending )
			{
				this.connectionHello.phase = ConnectionHelloPhaseType.aborted;
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.Stop, Server.SubState.None);
			}

			if ( state == Server.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.aborted )
				return (Server.State.Stop, Server.SubState.None);

			throw new Exception( "Hello aborted!" );
		}

		//public override (Client.State, Client.SubState, string) Test( Client.State state )
		//{
		//	string		 error	  = null;
		//	Client.State newState = state;

		//	//if ( this.bytes[1] != SHIPMessageValue.CMI_HEAD )
		//	//{
		//	//	error = "Expected SMI_HEAD payload in INIT message!";
		//	//	newState = Client.State.Stop;
		//	//}

		//	return (newState, Client.SubState.None, error);
		//}

#pragma warning disable CS1998
		public override async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subState )
#pragma warning restore CS1998
		{
			if ( state == Client.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.ready )
			{

				ProtocolHandshakeMessage message = new ProtocolHandshakeMessage( ProtocolHandshakeTypeType.announceMax, 1, 0 );
				await message.Send( ws ).ConfigureAwait( false );
				return (Client.State.WaitingForProtocolHandshake, Client.SubState.None);
			}

			if ( state == Client.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && this.connectionHello.prolongationRequest && subState == Client.SubState.None )
			{
				await Resend( ws ).ConfigureAwait( false ) ;
				return (Client.State.WaitingForConnectionHello, Client.SubState.FirstPending);
			}

			if ( state == Client.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && this.connectionHello.prolongationRequest && subState == Client.SubState.FirstPending )
			{
				await Resend( ws).ConfigureAwait( false );
				return (Client.State.WaitingForConnectionHello, Client.SubState.SecondPending);
			}

			if ( state == Client.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Client.SubState.SecondPending )
				return (Client.State.Stop, Client.SubState.None);

			if ( state == Client.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.aborted )
				return (Client.State.Stop, Client.SubState.None);

			throw new Exception( "Was waiting for Init" );
		}
	}

	[System.SerializableAttribute()]
	public partial class ConnectionHelloType
	{
		public ConnectionHelloPhaseType phase { get; set; }

		public uint waiting { get; set; }

		public bool prolongationRequest { get; set; }
	}

	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConnectionHelloPhaseType
	{
		pending,
		ready,
		aborted,
	}
}
