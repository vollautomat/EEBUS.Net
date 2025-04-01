using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP.Messages
{
	public class AccessMethodsRequestMessage : JsonControlMessage<AccessMethodsRequestMessage>
	{
		static AccessMethodsRequestMessage()
		{
			Register();
		}

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
