using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP.Messages
{
	public class ProtocolHandshakeErrorMessage : JsonControlMessage<ProtocolHandshakeErrorMessage>
	{
		static ProtocolHandshakeErrorMessage()
		{
			Register();
		}

		public ProtocolHandshakeErrorMessage()
		{
		}

		public ProtocolHandshakeErrorMessage(byte error)
		{
			this.messageProtocolHandshakeError.error = error;
		}

		public MessageProtocolHandshakeErrorType messageProtocolHandshakeError { get; set; } = new MessageProtocolHandshakeErrorType();
	}

	[System.SerializableAttribute()]
	public partial class MessageProtocolHandshakeErrorType
	{

		/// <remarks/>
		public byte error { get; set; }
	}
}
