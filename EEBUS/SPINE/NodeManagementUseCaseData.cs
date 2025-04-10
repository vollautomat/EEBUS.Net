
using EEBUS.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace EEBUS.SPINE.Commands
{
	public class NodeManagementUseCaseData : SpineCmdPayload<CmdNodeManagementUseCaseDataType>
	{
		static NodeManagementUseCaseData()
		{
			Register( "nodeManagementUseCaseData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdNodeManagementUseCaseDataType>.Class
		{
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				NodeManagementUseCaseData	  payload = new NodeManagementUseCaseData();
				NodeManagementUseCaseDataType data	  = payload.cmd[0].nodeManagementUseCaseData;

				data.useCaseInformation[0].address.device								= Server.Settings.Device.Id;
				data.useCaseInformation[0].address.entity								= [1];
				data.useCaseInformation[0].actor										= "ControllableSystem";
				data.useCaseInformation[0].useCaseSupport[0].useCaseName				= "limitationOfPowerConsumption";
				data.useCaseInformation[0].useCaseSupport[0].useCaseVersion				= "1.0.0";
				data.useCaseInformation[0].useCaseSupport[0].useCaseAvailable			= true;
				data.useCaseInformation[0].useCaseSupport[0].scenarioSupport			= [1,2,3,4];
				data.useCaseInformation[0].useCaseSupport[0].useCaseDocumentSubRevision = "release";

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdNodeManagementUseCaseDataType : CmdType
	{
		public NodeManagementUseCaseDataType nodeManagementUseCaseData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class NodeManagementUseCaseDataType
	{
		public UseCaseInformationType[] useCaseInformation { get; set; } = [new()];
	}

	[System.SerializableAttribute()]
	public class UseCaseInformationType
	{
		public AddressType address { get; set; } = new();

		public string actor { get; set; }

		public UseCaseSupportType[] useCaseSupport { get; set; } = [new()];
	}

	[System.SerializableAttribute()]
	public class UseCaseSupportType
	{
		public string useCaseName { get; set; }

		public string useCaseVersion { get; set; }

		public bool useCaseAvailable { get; set; }

		public int[] scenarioSupport { get; set; }

		public string useCaseDocumentSubRevision { get; set; }
	}
}
