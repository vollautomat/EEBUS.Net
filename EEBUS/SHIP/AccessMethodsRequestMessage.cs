using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP
{
	public class AccessMethodsRequestMessage : JsonControlMessage<AccessMethodsRequestMessage>
	{
		public AccessMethodsRequestMessage()
		{
		}

		public AccessMethodsRequestType accessMethodsRequest { get; set; } = new AccessMethodsRequestType();
	}

	[System.SerializableAttribute()]
	public class AccessMethodsRequestType
	{
	}
}
