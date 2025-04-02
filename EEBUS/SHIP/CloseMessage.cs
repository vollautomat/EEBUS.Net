using System.Text.Json.Serialization;

using Newtonsoft.Json.Converters;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class CloseMessage : JsonEndMessage<CloseMessage>
	{
		static CloseMessage()
		{
			Register( new Class() );
		}

		public CloseMessage()
		{
		}

		public CloseMessage( ConnectionClosePhaseType phase )
		{
			this.connectionClose[0].phase = phase;
		}

		public new class Class : JsonEndMessage<CloseMessage>.Class
		{
			public override CloseMessage Create( byte[] data )
			{
				return template.FromJsonVirtual( data );
			}
		}

		public ConnectionCloseType[] connectionClose { get; set; } = new ConnectionCloseType[] { new ConnectionCloseType() };
	}

	[System.SerializableAttribute()]
	public class ConnectionCloseType
	{
		public ConnectionClosePhaseType phase { get; set; }

		public uint maxTime { get; set; }

		public bool maxTimeSpecified { get; set; }

		public ConnectionCloseReasonType reason { get; set; }

		public bool reasonSpecified { get; set; }
	}

	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConnectionClosePhaseType
	{
		announce,
		confirm,
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConnectionCloseReasonType
	{
		unspecific,
		removedConnection,
	}
}
