
using EEBUS.Messages;
using EEBUS.Models;
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

				data.deviceInformation = connection.Local.DeviceInformation;
				data.entityInformation = connection.Local.EntityInformations;

				List<FeatureInformationType> features = new();
				foreach ( Entity entity in connection.Local.Entities )
					foreach ( Feature feature in entity.Features )
						features.Add( feature.FeatureInformation );

				data.featureInformation = features.ToArray();

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

		public DeviceInformationType		deviceInformation		 { get; set; } = new();

		public EntityInformationType[]		entityInformation		 { get; set; }

		public FeatureInformationType[]		featureInformation		 { get; set; }
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
		public DeviceAddressType deviceAddress	   { get; set; } = new();
		
		public string			 deviceType		   { get; set; }
		
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
		
		public string			 entityType	   { get; set; }
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
		public FeatureAddressType	   featureAddress	 { get; set; } = new();
		
		public string				   featureType		 { get; set; }
		
		public string				   role				 { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SupportedFunctionType[] supportedFunction { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string				   description		 { get; set; }
	}

	[System.SerializableAttribute()]
	public class FeatureAddressType
	{
		public string device  { get; set; }
		
		public int[]  entity  { get; set; }
		
		public int	  feature { get; set; }
	}

	[System.SerializableAttribute()]
	public class SupportedFunctionType
	{
		public string				  function			 { get; set; }
		
		public PossibleOperationsType possibleOperations { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class PossibleOperationsType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object read  { get; set; }
		
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object write { get; set; }
	}
}
