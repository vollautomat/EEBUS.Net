
using EEBUS.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace EEBUS.SPINE.Commands
{
	public class NodeManagementSubscriptionRequestCall : SpineCmdPayload<CmdNodeManagementSubscriptionRequestCallType>
	{
		static NodeManagementSubscriptionRequestCall()
		{
			Register( "nodeManagementSubscriptionRequestCall", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdNodeManagementSubscriptionRequestCallType>.Class
		{
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				ResultData payload = new ResultData();

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdNodeManagementSubscriptionRequestCallType : CmdType
	{
		public NodeManagementSubscriptionRequestCallType nodeManagementSubscriptionRequestCall { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class NodeManagementSubscriptionRequestCallType
	{
		public SubscriptionRequestType subscriptionRequest { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class SubscriptionRequestType
	{
		public AddressType clientAddress { get; set; }

		public AddressType serverAddress { get; set; }

		public string serverFeatureType { get; set; }
	}

	[System.SerializableAttribute()]
	public class AddressType
	{
		public string device { get; set; }

		public int[] entity { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string feature { get; set; }
	}
}
