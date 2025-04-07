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
			public override ProtocolHandshakeErrorMessage Create( byte[] data, Server server )
			{
				return template.FromJsonVirtual( data, server );
			}
		}

		public MessageProtocolHandshakeErrorType messageProtocolHandshakeError { get; set; } = new();

#pragma warning disable CS1998
		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
#pragma warning restore CS1998
		{
			return (Server.State.Stop, Server.SubState.None);
		}

#pragma warning disable CS1998
		public override async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subState )
#pragma warning restore CS1998
		{
			return (Client.State.Stop, Client.SubState.None);
		}
	}

	[System.SerializableAttribute()]
	public partial class MessageProtocolHandshakeErrorType
	{
		public byte error { get; set; }
	}
}
