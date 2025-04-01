using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP.Messages
{
	public class AccessMethodsMessage : JsonControlMessage<AccessMethodsMessage>
	{
		static AccessMethodsMessage()
		{
			Register();
		}

		public AccessMethodsMessage()
		{
		}

		public AccessMethodsMessage(string id)
		{
			this.accessMethods.id = id;
		}

		public AccessMethodsType accessMethods { get; set; } = new AccessMethodsType();
	}

	[System.SerializableAttribute()]
	public class AccessMethodsType
	{
		public string id { get; set; }

		public AccessMethodsTypeDnsSd_mDns dnsSd_mDns { get; set; }

		public AccessMethodsTypeDns dns { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class AccessMethodsTypeDnsSd_mDns
	{
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class AccessMethodsTypeDns
	{
		public string uri { get; set; }
	}
}
