
using EEBUS.Messages;
using Newtonsoft.Json;

namespace EEBUS.SPINE.Commands
{
	public class NodeManagementBindingRequestCall : SpineCmdPayload<CmdNodeManagementBindingRequestCallType>
	{
		static NodeManagementBindingRequestCall()
		{
			Register( "nodeManagementBindingRequestCall", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdNodeManagementBindingRequestCallType>.Class
		{
			public override SpineCmdPayloadBase CreateAnswer( HeaderType header, Server server )
			{
				ResultData payload = new ResultData();

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdNodeManagementBindingRequestCallType : CmdType
	{
		public NodeManagementBindingRequestCallType nodeManagementBindingRequestCall { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class NodeManagementBindingRequestCallType
	{
		public BindingRequestType bindingRequest { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class BindingRequestType
	{
		public AddressType clientAddress { get; set; }

		public AddressType serverAddress { get; set; }

		public string serverFeatureType { get; set; }
	}
}
