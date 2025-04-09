
using EEBUS.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace EEBUS.SPINE.Commands
{
	public class NodeManagementDetailedDiscoveryData : SpineCmdPayload<CmdNodeManagementDetailedDiscoveryDataType>
	{
		static NodeManagementDetailedDiscoveryData()
		{
			Register( "nodeManagementDetailedDiscoveryData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdNodeManagementDetailedDiscoveryDataType>.Class
		{
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				NodeManagementDetailedDiscoveryData		payload = new NodeManagementDetailedDiscoveryData();
				NodeManagementDetailedDiscoveryDataType data	= payload.cmd[0].nodeManagementDetailedDiscoveryData;

				data.deviceInformation.description.deviceAddress.device								= Server.Settings.Id;
				data.deviceInformation.description.deviceType										= "EnergyManagementSystem";
				data.deviceInformation.description.networkFeatureSet								= "smart";

				data.entityInformation = [new(), new()];
				data.entityInformation[0].description.entityAddress.device							= Server.Settings.Id;
				data.entityInformation[0].description.entityAddress.entity							= [0];
				data.entityInformation[0].description.entityType									= "DeviceInformation";
				data.entityInformation[1].description.entityAddress.device							= Server.Settings.Id;
				data.entityInformation[1].description.entityAddress.entity							= [1];
				data.entityInformation[1].description.entityType									= "CEM";

				data.featureInformation = [new(), new(), new(), new(), new(), new(), new()];
				data.featureInformation[0].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[0].description.featureAddress.entity						= [0];
				data.featureInformation[0].description.featureAddress.feature						= 0;
				data.featureInformation[0].description.featureType									= "NodeManagement";
				data.featureInformation[0].description.role											= "special";
				data.featureInformation[0].description.supportedFunction = [new(), new(), new(), new(), new(), new(), new(), new(), new()];
				data.featureInformation[0].description.supportedFunction[0].function				= "nodeManagementBindingData";
				data.featureInformation[0].description.supportedFunction[0].possibleOperations.read	= new();

				data.featureInformation[0].description.supportedFunction[1].function				= "nodeManagementDetailedDiscoveryData";
				data.featureInformation[0].description.supportedFunction[1].possibleOperations.read	= new();

				data.featureInformation[0].description.supportedFunction[2].function				= "nodeManagementUseCaseData";
				data.featureInformation[0].description.supportedFunction[2].possibleOperations.read = new();

				data.featureInformation[0].description.supportedFunction[3].function				= "nodeManagementSubscriptionDeleteCall";

				data.featureInformation[0].description.supportedFunction[4].function				= "nodeManagementBindingDeleteCall";

				data.featureInformation[0].description.supportedFunction[5].function				= "nodeManagementDestinationListData";
				data.featureInformation[0].description.supportedFunction[5].possibleOperations.read = new();

				data.featureInformation[0].description.supportedFunction[6].function				= "nodeManagementSubscriptionData";
				data.featureInformation[0].description.supportedFunction[6].possibleOperations.read = new();

				data.featureInformation[0].description.supportedFunction[7].function				= "nodeManagementSubscriptionRequestCall";

				data.featureInformation[0].description.supportedFunction[8].function				= "nodeManagementBindingRequestCall";

				data.featureInformation[1].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[1].description.featureAddress.entity						= [0];
				data.featureInformation[1].description.featureAddress.feature						= 1;
				data.featureInformation[1].description.featureType									= "DeviceClassification";
				data.featureInformation[1].description.role											= "server";
				data.featureInformation[1].description.supportedFunction = [new()];
				data.featureInformation[1].description.supportedFunction[0].function				= "deviceClassificationManufacturerData";
				data.featureInformation[1].description.supportedFunction[0].possibleOperations.read = new();

				data.featureInformation[2].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[2].description.featureAddress.entity						= [1];
				data.featureInformation[2].description.featureAddress.feature						= 1;
				data.featureInformation[2].description.featureType									= "DeviceDiagnosis";
				data.featureInformation[2].description.role											= "client";
				data.featureInformation[2].description.description									= "DeviceDiagnosis Client";

				data.featureInformation[3].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[3].description.featureAddress.entity						= [1];
				data.featureInformation[3].description.featureAddress.feature						= 2;
				data.featureInformation[3].description.featureType									= "LoadControl";
				data.featureInformation[3].description.role											= "server";
				data.featureInformation[3].description.supportedFunction = [new(), new()];
				data.featureInformation[3].description.supportedFunction[0].function				 = "loadControlLimitDescriptionListData";
				data.featureInformation[3].description.supportedFunction[0].possibleOperations.read  = new();
				data.featureInformation[3].description.supportedFunction[1].function				 = "loadControlLimitListData";
				data.featureInformation[3].description.supportedFunction[1].possibleOperations.read  = new();
				data.featureInformation[3].description.supportedFunction[1].possibleOperations.write = new { partial = new {} };
				data.featureInformation[3].description.description									 = "LoadControl Server";

				data.featureInformation[4].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[4].description.featureAddress.entity						= [1];
				data.featureInformation[4].description.featureAddress.feature						= 3;
				data.featureInformation[4].description.featureType									= "DeviceConfiguration";
				data.featureInformation[4].description.role											= "server";
				data.featureInformation[4].description.supportedFunction = [new(), new()];
				data.featureInformation[4].description.supportedFunction[0].function				 = "deviceConfigurationKeyValueDescriptionListData";
				data.featureInformation[4].description.supportedFunction[0].possibleOperations.read	 = new object();
				data.featureInformation[4].description.supportedFunction[1].function				 = "deviceConfigurationKeyValueListData";
				data.featureInformation[4].description.supportedFunction[1].possibleOperations.read	 = new();
				data.featureInformation[4].description.supportedFunction[1].possibleOperations.write = new { partial = new {} };
				data.featureInformation[4].description.description									 = "DeviceConfiguration Server";

				data.featureInformation[5].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[5].description.featureAddress.entity						= [1];
				data.featureInformation[5].description.featureAddress.feature						= 4;
				data.featureInformation[5].description.featureType									= "DeviceDiagnosis";
				data.featureInformation[5].description.role											= "server";
				data.featureInformation[5].description.supportedFunction = [new()];
				data.featureInformation[5].description.supportedFunction[0].function				= "deviceDiagnosisHeartbeatData";
				data.featureInformation[5].description.supportedFunction[0].possibleOperations.read	= new();
				data.featureInformation[5].description.description									= "DeviceDiagnosis Server";

				data.featureInformation[6].description.featureAddress.device						= Server.Settings.Id;
				data.featureInformation[6].description.featureAddress.entity						= [1];
				data.featureInformation[6].description.featureAddress.feature						= 5;
				data.featureInformation[6].description.featureType									= "ElectricalConnection";
				data.featureInformation[6].description.role											= "server";
				data.featureInformation[6].description.supportedFunction = [new()];
				data.featureInformation[6].description.supportedFunction[0].function				= "electricalConnectionCharacteristicListData";
				data.featureInformation[6].description.supportedFunction[0].possibleOperations.read = new();
				data.featureInformation[6].description.description									= "ElectricalConnection Server";

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdNodeManagementDetailedDiscoveryDataType : CmdType
	{
		public NodeManagementDetailedDiscoveryDataType nodeManagementDetailedDiscoveryData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class NodeManagementDetailedDiscoveryDataType
	{
		public SpecificationVersionListType specificationVersionList { get; set; } = new();

		public DeviceInformationType		deviceInformation { get; set; } = new();

		public EntityInformationType[]		entityInformation { get; set; }

		public FeatureInformationType[]		featureInformation { get; set; }
	}

	[System.SerializableAttribute()]
	public class SpecificationVersionListType
	{
		public string[] specificationVersion { get; set; } = ["1.3.0"];
	}

	[System.SerializableAttribute()]
	public class DeviceInformationType
	{
		public DeviceInformationDescriptionType description { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class DeviceInformationDescriptionType
	{
		public DeviceAddressType deviceAddress { get; set; } = new();
		
		public string			 deviceType { get; set; }
		
		public string			 networkFeatureSet { get; set; }
	}

	[System.SerializableAttribute()]
	public class DeviceAddressType
	{
		public string device { get; set; }
	}

	[System.SerializableAttribute()]
	public class EntityInformationType
	{
		public EntityInformationDescriptionType description { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class EntityInformationDescriptionType
	{
		public EntityAddressType entityAddress { get; set; } = new();
		
		public string			 entityType { get; set; }
	}

	[System.SerializableAttribute()]
	public class EntityAddressType
	{
		public string device { get; set; }
		
		public int[]  entity { get; set; }
	}

	[System.SerializableAttribute()]
	public class FeatureInformationType
	{
		public FeatureInformationDescriptionType description { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class FeatureInformationDescriptionType
	{
		public FeatureAddressType	   featureAddress { get; set; } = new();
		
		public string				   featureType { get; set; }
		
		public string role { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SupportedFunctionType[] supportedFunction { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string				   description { get; set; }
	}

	[System.SerializableAttribute()]
	public class FeatureAddressType
	{
		public string device { get; set; }
		
		public int[]  entity { get; set; }
		
		public int	  feature { get; set; }
	}

	[System.SerializableAttribute()]
	public class SupportedFunctionType
	{
		public string				  function { get; set; }
		
		public PossibleOperationsType possibleOperations { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class PossibleOperationsType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object read { get; set; }
		
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object write { get; set; }
	}
}
