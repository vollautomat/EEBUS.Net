using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP.Messages
{
	public class PinCheckMessage : JsonControlMessage<PinCheckMessage>
	{
		static PinCheckMessage()
		{
			Register();
		}

		public PinCheckMessage()
		{
		}

		public PinCheckMessage(PinStateType pinState)
		{
			this.connectionPinState.pinState = pinState;
		}

		public ConnectionPinStateType connectionPinState { get; set; } = new ConnectionPinStateType();
	}

	[System.SerializableAttribute()]
	public class ConnectionPinStateType
	{
		public PinStateType pinState { get; set; }

		public bool inputPermissionSpecified { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PinStateType
	{
		required,
		optional,
		pinOk,
		none,
	}
}
