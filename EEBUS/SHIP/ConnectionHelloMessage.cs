using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP
{
	public class ConnectionHelloMessage : JsonControlMessage<ConnectionHelloMessage>
	{
		public ConnectionHelloMessage()
		{
		}

		public ConnectionHelloMessage(ConnectionHelloPhaseType phase)
		{
			this.connectionHello.phase = phase;
		}

		public ConnectionHelloMessage(ConnectionHelloPhaseType phase, uint waiting)
		{
			this.connectionHello.phase = phase;
			this.connectionHello.waiting = waiting;
		}

		public ConnectionHelloType connectionHello { get; set; } = new ConnectionHelloType();
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
