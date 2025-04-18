
using EEBUS.Messages;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

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
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				DeviceConfigurationKeyValueListData	    payload = new DeviceConfigurationKeyValueListData();
				DeviceConfigurationKeyValueListDataType data	= payload.cmd[0].deviceConfigurationKeyValueListData;

				List<DeviceConfigurationKeyValueDataType> datas = new();
				foreach ( var keyValue in connection.Local.KeyValues )
					datas.Add( keyValue.Data);

				data.deviceConfigurationKeyValueData = datas.ToArray();

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
		public int		 keyId			   { get; set; }

		public ValueType value			   { get; set; } = new();

		public bool		 isValueChangeable { get; set; }
	}

	[System.SerializableAttribute()]
	public class ValueType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScaledNumberType	scaledNumber { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string			duration	 { get; set; }
	}

	[System.SerializableAttribute()]
	public class ScaledNumberType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long  number	{ get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public short scale	{ get; set; }
	}
}
