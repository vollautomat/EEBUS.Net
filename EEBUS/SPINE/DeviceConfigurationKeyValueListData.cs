
using EEBUS.Messages;
using Newtonsoft.Json;
using System;

namespace EEBUS.SPINE.Commands
{
	public class DeviceConfigurationKeyValueListData : SpineCmdPayload<CmdDeviceConfigurationKeyValueListDataType>
	{
		static DeviceConfigurationKeyValueListData()
		{
			Register( "deviceConfigurationKeyValueListData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdDeviceConfigurationKeyValueListDataType>.Class
		{
			public override SpineCmdPayloadBase CreateAnswer( HeaderType header, Server server )
			{
				DeviceConfigurationKeyValueListData	    payload = new DeviceConfigurationKeyValueListData();
				DeviceConfigurationKeyValueListDataType data	= payload.cmd[0].deviceConfigurationKeyValueListData;

				data.deviceConfigurationKeyValueData = [new(), new()];
				data.deviceConfigurationKeyValueData[0].keyId					  = 0;
				data.deviceConfigurationKeyValueData[0].value.scaledNumber		  = new();
				data.deviceConfigurationKeyValueData[0].value.scaledNumber.number = 3600;
				data.deviceConfigurationKeyValueData[0].value.scaledNumber.scale  = 0;
				data.deviceConfigurationKeyValueData[0].isValueChangeable		  = true;
				data.deviceConfigurationKeyValueData[1].keyId					  = 1;
				data.deviceConfigurationKeyValueData[1].value.duration			  = "PT2H";
				data.deviceConfigurationKeyValueData[1].isValueChangeable		  = true;

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdDeviceConfigurationKeyValueListDataType : CmdType
	{
		public DeviceConfigurationKeyValueListDataType deviceConfigurationKeyValueListData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class DeviceConfigurationKeyValueListDataType
	{
		public DeviceConfigurationKeyValueDataType[] deviceConfigurationKeyValueData { get; set; }
	}

	[System.SerializableAttribute()]
	public class DeviceConfigurationKeyValueDataType
	{
		public int keyId { get; set; }

		public ValueType value { get; set; } = new();

		public bool isValueChangeable { get; set; }
	}

	[System.SerializableAttribute()]
	public class ValueType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScaledNumberType scaledNumber { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string duration { get; set; }
	}

	[System.SerializableAttribute()]
	public class ScaledNumberType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long number { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public short scale { get; set; }
	}
}
