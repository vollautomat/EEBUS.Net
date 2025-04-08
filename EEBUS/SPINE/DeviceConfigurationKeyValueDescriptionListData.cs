
using EEBUS.Messages;
using Newtonsoft.Json;

namespace EEBUS.SPINE.Commands
{
	public class DeviceConfigurationKeyValueDescriptionListData : SpineCmdPayload<CmdDeviceConfigurationKeyValueDescriptionListDataType>
	{
		static DeviceConfigurationKeyValueDescriptionListData()
		{
			Register( "deviceConfigurationKeyValueDescriptionListData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdDeviceConfigurationKeyValueDescriptionListDataType>.Class
		{
			public override SpineCmdPayloadBase CreateAnswer( HeaderType header, Connection connection )
			{
				DeviceConfigurationKeyValueDescriptionListData	   payload = new DeviceConfigurationKeyValueDescriptionListData();
				DeviceConfigurationKeyValueDescriptionListDataType data	   = payload.cmd[0].deviceConfigurationKeyValueDescriptionListData;

				data.deviceConfigurationKeyValueDescriptionData				 = [new(), new()];
				data.deviceConfigurationKeyValueDescriptionData[0].keyId	 = 0;
				data.deviceConfigurationKeyValueDescriptionData[0].keyName	 = "failsafeConsumptionActivePowerLimit";
				data.deviceConfigurationKeyValueDescriptionData[0].valueType = "scaledNumber";
				data.deviceConfigurationKeyValueDescriptionData[0].unit		 = "W";
				data.deviceConfigurationKeyValueDescriptionData[1].keyId	 = 1;
				data.deviceConfigurationKeyValueDescriptionData[1].keyName	 = "failsafeDurationMinimum";
				data.deviceConfigurationKeyValueDescriptionData[1].valueType = "duration";

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdDeviceConfigurationKeyValueDescriptionListDataType : CmdType
	{
		public DeviceConfigurationKeyValueDescriptionListDataType deviceConfigurationKeyValueDescriptionListData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class DeviceConfigurationKeyValueDescriptionListDataType
	{
		public DeviceConfigurationKeyValueDescriptionDataType[] deviceConfigurationKeyValueDescriptionData { get; set; }
	}

	[System.SerializableAttribute()]
	public class DeviceConfigurationKeyValueDescriptionDataType
	{
		public int keyId { get; set; }

		public string keyName { get; set; }

		public string valueType { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string unit { get; set; }
	}
}
