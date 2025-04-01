using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP
{
	public class DataMessage : JsonDataMessage<DataMessage>
	{
		public DataMessage()
		{
		}

		public DataMessage(object payload)
		{
			this.data.payload = payload;
		}

		public DataMessage(string protocolId, object payload)
		{
			this.data.header.protocolId = protocolId;
			this.data.payload = payload;
		}

		public DataType data { get; set; } = new DataType();
	}

	[System.SerializableAttribute()]
	public class DataType
	{
		public HeaderType header { get; set; } = new HeaderType();

		public object payload { get; set; }

		public ExtensionType extension { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class HeaderType
	{
		public string protocolId { get; set; }
	}

	[System.SerializableAttribute()]
	public partial class ExtensionType
	{
		public string extensionId { get; set; }

		public byte[] binary { get; set; }

		public string @string { get; set; }
	}
}
