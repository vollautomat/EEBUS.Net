using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP
{
	public class ProtocolHandshakeMessage : JsonControlMessage<ProtocolHandshakeMessage>
	{
		public ProtocolHandshakeMessage()
		{
		}

		public ProtocolHandshakeMessage(ProtocolHandshakeTypeType handshakeType, ushort major, ushort minor)
		{
			this.messageProtocolHandshake.handshakeType = handshakeType;
			this.messageProtocolHandshake.version = new MessageProtocolHandshakeTypeVersion(major, minor);
		}

		public MessageProtocolHandshakeType messageProtocolHandshake { get; set; } = new MessageProtocolHandshakeType();

		public bool IsEqual(ProtocolHandshakeMessage other)
		{
			return this.messageProtocolHandshake.IsEqual(other.messageProtocolHandshake);
		}
	}

	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeType
	{
		public ProtocolHandshakeTypeType handshakeType { get; set; } = new ProtocolHandshakeTypeType();

		public MessageProtocolHandshakeTypeVersion version { get; set; } = new MessageProtocolHandshakeTypeVersion();

		public MessageProtocolHandshakeTypeFormats formats { get; set; } = new MessageProtocolHandshakeTypeFormats(SHIPMessageFormat.JSON_UTF8);

		public bool IsEqual(MessageProtocolHandshakeType other)
		{
			if (this.handshakeType != other.handshakeType)
				return false;

			if (!this.version.IsEqual(other.version))
				return false;

			if (!this.formats.IsEqual(other.formats))
				return false;

			return true;
		}
	}

	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProtocolHandshakeTypeType
	{
		announceMax,
		select,
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeTypeVersion
	{
		public MessageProtocolHandshakeTypeVersion()
		{
		}

		public MessageProtocolHandshakeTypeVersion(ushort major, ushort minor)
		{
			this.major = major;
			this.minor = minor;
		}

		public ushort major { get; set; }

		public ushort minor { get; set; }

		public bool IsEqual(MessageProtocolHandshakeTypeVersion other)
		{
			if (this.major != other.major)
				return false;

			if (this.minor != other.minor)
				return false;

			return true;
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeTypeFormats
	{
		public MessageProtocolHandshakeTypeFormats()
		{
		}

		public MessageProtocolHandshakeTypeFormats( string format )
		{
			this.format = new string[] { format };
		}

		public string[] format { get; set; }

		public bool IsEqual(MessageProtocolHandshakeTypeFormats other)
		{
			if ( this.format.Length != other.format.Length)
				return false;

			for (int i=0; i< this.format.Length; i++)
				if (this.format[i] != other.format[i])
					return false;

			return true;
		}
	}
}
