using System.Net.WebSockets;
using System.Threading.Tasks;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class ProtocolHandshakeErrorMessage : ShipControlMessage<ProtocolHandshakeErrorMessage>
	{
		static ProtocolHandshakeErrorMessage()
		{
			Register( new Class() );
		}

		public ProtocolHandshakeErrorMessage()
		{
		}

		public ProtocolHandshakeErrorMessage( byte error )
		{
			this.messageProtocolHandshakeError.error = error;
		}

		public new class Class : ShipControlMessage<ProtocolHandshakeErrorMessage>.Class
		{
			public override ProtocolHandshakeErrorMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			}
		}

		public MessageProtocolHandshakeErrorType messageProtocolHandshakeError { get; set; } = new();

		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			return (Connection.State.Stop, Connection.SubState.None);
		}

		public override async Task<(Connection.State, Connection.SubState)> NextClientState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			return (Connection.State.Stop, Connection.SubState.None);
		}
	}

	[System.SerializableAttribute()]
	public partial class MessageProtocolHandshakeErrorType
	{
		public byte error { get; set; }
	}
}
