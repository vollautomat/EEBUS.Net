using System.Net.WebSockets;
using System.Threading.Tasks;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class ProtocolHandshakeErrorMessage : JsonControlMessage<ProtocolHandshakeErrorMessage>
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

		public new class Class : JsonControlMessage<ProtocolHandshakeErrorMessage>.Class
		{
			public override ProtocolHandshakeErrorMessage Create( byte[] data )
			{
				return template.FromJsonVirtual(data);
			}
		}

		public MessageProtocolHandshakeErrorType messageProtocolHandshakeError { get; set; } = new MessageProtocolHandshakeErrorType();

#pragma warning disable CS1998
		public override async Task<(Server.State, Server.SubState)> NextState(WebSocket ws, Server.State state, Server.SubState subState)
#pragma warning restore CS1998
		{
			return (Server.State.Stop, Server.SubState.None);
		}
	}

	[System.SerializableAttribute()]
	public partial class MessageProtocolHandshakeErrorType
	{
		public byte error { get; set; }
	}
}
