using System;
using System.Net.WebSockets;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Newtonsoft.Json.Converters;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class ConnectionHelloMessage : ShipControlMessage<ConnectionHelloMessage>
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

		public new class Class : ShipControlMessage<ConnectionHelloMessage>.Class
		{
			public override ConnectionHelloMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			}
		}

		public ConnectionHelloType connectionHello { get; set; } = new();

		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.ready )
			{
				await Send( ws ).ConfigureAwait( false ) ;
				return (Connection.State.WaitingForProtocolHandshake, Connection.SubState.None);
			}
			
			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Connection.SubState.None )
			{
				await Send( ws ).ConfigureAwait( false ) ;
				return (Connection.State.WaitingForProtocolHandshake, Connection.SubState.FirstPending);
			}

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Connection.SubState.FirstPending )
			{
				await Send( ws).ConfigureAwait( false );
				return (Connection.State.WaitingForProtocolHandshake, Connection.SubState.SecondPending);
			}

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Connection.SubState.SecondPending )
			{
				this.connectionHello.phase = ConnectionHelloPhaseType.aborted;
				await Send( ws ).ConfigureAwait( false );
				return (Connection.State.Stop, Connection.SubState.None);
			}

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.aborted )
				return (Connection.State.Stop, Connection.SubState.None);

			throw new Exception( "Hello aborted!" );
		}

		public override async Task<(Connection.State, Connection.SubState)> NextClientState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.ready )
			{

				ProtocolHandshakeMessage message = new ProtocolHandshakeMessage( ProtocolHandshakeTypeType.announceMax, 1, 0 );
				await message.Send( ws ).ConfigureAwait( false );
				return (Connection.State.WaitingForProtocolHandshake, Connection.SubState.None);
			}

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && this.connectionHello.prolongationRequest && subState == Connection.SubState.None )
			{
				await Resend( ws ).ConfigureAwait( false ) ;
				return (Connection.State.WaitingForConnectionHello, Connection.SubState.FirstPending);
			}

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && this.connectionHello.prolongationRequest && subState == Connection.SubState.FirstPending )
			{
				await Resend( ws).ConfigureAwait( false );
				return (Connection.State.WaitingForConnectionHello, Connection.SubState.SecondPending);
			}

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.pending && subState == Connection.SubState.SecondPending )
				return (Connection.State.Stop, Connection.SubState.None);

			if ( state == Connection.State.WaitingForConnectionHello && this.connectionHello.phase == ConnectionHelloPhaseType.aborted )
				return (Connection.State.Stop, Connection.SubState.None);

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
