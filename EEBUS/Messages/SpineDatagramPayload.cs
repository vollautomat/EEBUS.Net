using EEBUS.SHIP.Messages;
using EEBUS.SPINE;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EEBUS.Messages
{
	public class SpineDatagramPayload
	{
		public SpineDatagramPayload()
		{
		}

		public DatagramType datagram { get; set; } = new();

		private string GetAnswerCmdClassifier()
		{
			switch ( this.datagram.header.cmdClassifier )
			{
				case "read":
					return "reply";
				case "call":
					return "result";
				case "notify":
					return "";
				default:
					return null;
			}
		}

		public SpineDatagramPayload CreateAnswer( ulong counter, Server server )
		{
			if ( ! this.datagram.payload.TryGetValue( "cmd", out JToken cmds ) )
				return null;
			if ( ! (cmds is JArray) )
				return null;

			JObject cmd = (cmds as JArray)[0] as JObject;
			if ( null == cmd )
				return null;

			JProperty prop = cmd.Properties().FirstOrDefault();
			if ( null == prop )
				return null;

			SpineCmdPayloadBase.Class cls = SpineCmdPayloadBase.GetClass( prop.Name );
			if ( null == cls )
				return null;

			SpineDatagramPayload reply = new SpineDatagramPayload();
			reply.datagram.header.addressSource		  = this.datagram.header.addressDestination;
			reply.datagram.header.addressDestination  = this.datagram.header.addressSource;
			reply.datagram.header.msgCounter		  = counter;
			reply.datagram.header.msgCounterReference = this.datagram.header.msgCounter;
			reply.datagram.header.cmdClassifier		  = GetAnswerCmdClassifier();
			reply.datagram.header.ackRequest		  = cls.GetAnswerAckRequest();

			SpineCmdPayloadBase payload = cls.CreateAnswer( reply.datagram.header, server );
			if ( null == payload )
				return null;

			reply.datagram.payload = JObject.FromObject( payload );

			return reply;
		}

		private AddressType AddressSource
		{
			get
			{
				AddressType address = new AddressType();
				address.device  = Server.Settings.Id;
				address.entity  = [0];
				address.feature = 0;

				return address;
			}
		}
	}

	[System.SerializableAttribute()]
	public class DatagramType
	{
		public HeaderType header { get; set; } = new();

		public JObject payload { get; set; }
	}

	[System.SerializableAttribute()]
	public class HeaderType
	{
		public string specificationVersion { get; set; } = "1.3.0";

		public AddressType addressSource { get; set; }

		public AddressType addressDestination { get; set; }

		public ulong msgCounter { get; set; }

		public ulong? msgCounterReference { get; set; }

		public string cmdClassifier { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ackRequest { get; set; }
	}

	[System.SerializableAttribute()]
	public class AddressType
	{
		public string device { get; set; }

		public int[] entity { get; set; }

		public int feature { get; set; }
	}
}
