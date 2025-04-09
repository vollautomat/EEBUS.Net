
using EEBUS.Messages;
using Newtonsoft.Json;
using System;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace EEBUS.SPINE.Commands
{
	public class DeviceDiagnosisHeartbeatData : SpineCmdPayload<CmdDeviceDiagnosisHeartbeatDataType>
	{
		static DeviceDiagnosisHeartbeatData()
		{
			Register( "deviceDiagnosisHeartbeatData", new Class() );
		}

		static public ulong counter = 1;

		public new class Class : SpineCmdPayload<CmdDeviceDiagnosisHeartbeatDataType>.Class
		{
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				connection.SetHeartbeatAddresses( header.addressSource, header.addressDestination );

				DeviceDiagnosisHeartbeatData	 payload = new DeviceDiagnosisHeartbeatData();
				DeviceDiagnosisHeartbeatDataType data	 = payload.cmd[0].deviceDiagnosisHeartbeatData;

				data.heartbeatCounter = DeviceDiagnosisHeartbeatData.counter++;

				return payload;
			}

			public override SpineCmdPayloadBase CreateNotify( DatagramType datagram )
			{
				DeviceDiagnosisHeartbeatData	 payload = new DeviceDiagnosisHeartbeatData();
				DeviceDiagnosisHeartbeatDataType data	 = payload.cmd[0].deviceDiagnosisHeartbeatData;

				data.heartbeatCounter = DeviceDiagnosisHeartbeatData.counter++;

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdDeviceDiagnosisHeartbeatDataType : CmdType
	{
		public DeviceDiagnosisHeartbeatDataType deviceDiagnosisHeartbeatData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class DeviceDiagnosisHeartbeatDataType
	{
		public string timestamp { get; set; } = DateTime.UtcNow.ToString( "s" ) + "Z";

		public ulong heartbeatCounter { get; set; }

		public string heartbeatTimeout { get; set; } = "PT4S";
	}
}
