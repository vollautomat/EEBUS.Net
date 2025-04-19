using EEBUS.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace EEBUS.SPINE.Commands
{
	public class ElectricalConnectionCharacteristicListData : SpineCmdPayload<CmdElectricalConnectionCharacteristicListDataType>
	{
		static ElectricalConnectionCharacteristicListData()
		{
			Register( "electricalConnectionCharacteristicListData", new Class() );
		}

		static public ulong counter = 1;

		public new class Class : SpineCmdPayload<CmdElectricalConnectionCharacteristicListDataType>.Class
		{
			//public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			//{
			//	connection.SetHeartbeatAddresses( header.addressSource, header.addressDestination );

			//	DeviceDiagnosisHeartbeatData	 payload = new DeviceDiagnosisHeartbeatData();
			//	DeviceDiagnosisHeartbeatDataType data	 = payload.cmd[0].deviceDiagnosisHeartbeatData;

			//	data.heartbeatCounter = DeviceDiagnosisHeartbeatData.counter++;

			//	return payload;
			//}

			public override SpineCmdPayloadBase CreateNotify()
			{
				ElectricalConnectionCharacteristicListData payload = new ElectricalConnectionCharacteristicListData();
				payload.cmd = [new()];
				payload.cmd[0].function = "electricalConnectionCharacteristicListData";
				payload.cmd[0].filter = [new()];
				payload.cmd[0].electricalConnectionCharacteristicListData = new();
				
				ElectricalConnectionCharacteristicDataType data0 = new();
				data0.electricalConnectionId = 0;
				data0.parameterId			 = 0;
				data0.characteristicId		 = 0;
				data0.characteristicContext	 = "entity";
				data0.characteristicType	 = "contractualConsumptionNominalMax";
				data0.value.number			 = 11111;
				data0.value.scale			 = 0;
				data0.unit					 = "W";

				ElectricalConnectionCharacteristicDataType data1 = new();
				data1.electricalConnectionId = 0;
				data1.parameterId			 = 0;
				data1.characteristicId		 = 1;
				data1.characteristicContext	 = "entity";
				data1.characteristicType	 = "contractualProductionNominalMax";
				data1.value.number			 = 5555;
				data1.value.scale			 = 0;
				data1.unit					 = "W";

				payload.cmd[0].electricalConnectionCharacteristicListData.electricalConnectionCharacteristicData = [data0, data1];

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdElectricalConnectionCharacteristicListDataType : CmdType
	{
		public string										  function									 { get; set; }
		public FilterType[]									  filter									 { get; set; }
		public ElectricalConnectionCharacteristicListDataType electricalConnectionCharacteristicListData { get; set; }
	}

	[System.SerializableAttribute()]
	public class FilterType
	{
		public object cmdControl { get; set; } = new { partial = new { } };
	}

	[System.SerializableAttribute()]
	public class ElectricalConnectionCharacteristicListDataType
	{
		public ElectricalConnectionCharacteristicDataType[] electricalConnectionCharacteristicData { get; set; }
	}

	[System.SerializableAttribute()]
	public class ElectricalConnectionCharacteristicDataType
	{
		public uint				electricalConnectionId { get; set; }
		public uint				parameterId			   { get; set; }
		public uint				characteristicId	   { get; set; }
		public string			characteristicContext  { get; set; }
		public string			characteristicType	   { get; set; }
		public ScaledNumberType	value				   { get; set; } = new();
		public string			unit				   { get; set; }
	}
}
