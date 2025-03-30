﻿
using Newtonsoft.Json;
using System.Text;

namespace EEBUS.Enums
{
    public class SHIPHelloMessage
    {
        public ConnectionHelloType connectionHello { get; set; } = new ConnectionHelloType();

        public byte[] ToJson()
        {
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, jsonSerializerSettings));
		}
	}

	public class SHIPHelloResponse
	{
		public ConnectionHelloType[] connectionHello { get; set; }
	}
	
    public class SHIPHandshakeMessage
    {
        public MessageProtocolHandshakeType messageProtocolHandshake { get; set; } = new MessageProtocolHandshakeType();

		public byte[] ToJson()
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, jsonSerializerSettings));
		}
	}

	public class SHIPHandshakeErrorMessage
    {
        public MessageProtocolHandshakeErrorType messageProtocolHandshakeError { get; set; } = new MessageProtocolHandshakeErrorType();
    }

    public class SHIPDataMessage
    {
        public DataType data { get; set; } = new DataType();
    }

    public class SHIPCloseMessage
    {
        public ConnectionCloseType[] connectionClose { get; set; } = new ConnectionCloseType[] { new ConnectionCloseType() };

		public byte[] ToJson()
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, jsonSerializerSettings));
		}
	}

	public class SHIPAccessMethodsMessage
    {
        public AccessMethodsType accessMethodsRequest { get; set; } = new AccessMethodsType();
    }

    public class SHIPMessageType
    {
        public const byte INIT = 0;
        public const byte CONTROL = 1;
        public const byte DATA = 2;
        public const byte END = 3;
    }

    public class SHIPMessageTimeout
    {
        public const int CMI_TIMEOUT = 30 * 1000; // maximum allowed are 30 seconds, according to spec
        public const int T_HELLO_INIT = 240 * 1000; // maximum alowed are 240 seconds, according to the spec
        public const int T_HELLO_INC = T_HELLO_INIT;
        public const int T_HELLO_PROLONG_THR_INC = 30 * 1000;// maximum allowed are 30 seconds, according to spec
        public const int T_HELLO_PROLONG_WAITING_GAP = 15 * 1000;// maximum allowed are 15 seconds, according to spec
        public const int T_HELLO_PROLONG_MIN = 1000;// maximum allowed is 1 second, according to spec
    }

    public class SHIPMessageValue
    {
        public const byte CMI_HEAD = 0;
    }

    public class SHIPMessageFormat
    {
        public const string JSON_UTF8 = "JSON-UTF8";
    }

    public class SHIPHandshakeError
    {
        public const byte RFU = 0;
        public const byte TIMEOUT = 1;
        public const byte UNEXPECTED_MESSAGE = 2;
        public const byte SELECTION_MISMATCH = 3;
    }

	public class SHIPPinCheckMessage
	{
		public ConnectionPinStateType connectionPinState { get; set; } = new ConnectionPinStateType();

		public byte[] ToJson()
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, jsonSerializerSettings));
		}
	}

    public class AccessMethodsRequestMessage
	{
        public AccessMethodsRequestType accessMethodsRequest { get; set; } = new AccessMethodsRequestType();

		public byte[] ToJson()
		{
			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
		}
	}

	public class AccessMethodsMessage
	{
		public AccessMethodsType accessMethods { get; set; } = new AccessMethodsType();

		public byte[] ToJson()
		{
			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
		}
	}
}