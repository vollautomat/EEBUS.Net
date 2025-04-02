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
