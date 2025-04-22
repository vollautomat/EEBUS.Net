using EEBUS.Messages;

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
			//public override SpineCmdPayloadBase CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			//{
			//	connection.SetHeartbeatAddresses( header.addressSource, header.addressDestination );

			//	DeviceDiagnosisHeartbeatData	 payload = new DeviceDiagnosisHeartbeatData();
			//	DeviceDiagnosisHeartbeatDataType data	 = payload.cmd[0].deviceDiagnosisHeartbeatData;

			//	data.heartbeatCounter = DeviceDiagnosisHeartbeatData.counter++;

			//	return payload;
			//}

			public override SpineCmdPayloadBase CreateNotify( Connection connection )
			{
				ElectricalConnectionCharacteristicListData payload = new ElectricalConnectionCharacteristicListData();
				payload.cmd = [new()];
				payload.cmd[0].function = "electricalConnectionCharacteristicListData";
				payload.cmd[0].filter = [new()];
				payload.cmd[0].electricalConnectionCharacteristicListData = new();

				List<ElectricalConnectionCharacteristicDataType> eccs = new();

				uint id = 0;

				if ( connection.Local.HasUseCase( typeof( UseCases.ControllableSystem.LimitationOfPowerConsumption ) ) )
				{
					ElectricalConnectionCharacteristicDataType ecc = new();
					ecc.electricalConnectionId = 0;
					ecc.parameterId			   = 0;
					ecc.characteristicId	   = id++;
					ecc.characteristicContext  = "entity";
					ecc.characteristicType	   = "contractualConsumptionNominalMax";
					ecc.value.number		   = connection.Local.GetSettings().GetConsumptionNominalMax();
					ecc.value.scale			   = 0;
					ecc.unit				   = "W";

					eccs.Add( ecc );
				}

				if ( connection.Local.HasUseCase( typeof( UseCases.ControllableSystem.LimitationOfPowerProduction ) ) )
				{
					ElectricalConnectionCharacteristicDataType ecc = new();
					ecc.electricalConnectionId = 0;
					ecc.parameterId			   = 0;
					ecc.characteristicId	   = id++;
					ecc.characteristicContext  = "entity";
					ecc.characteristicType	   = "contractualProductionNominalMax";
					ecc.value.number		   = connection.Local.GetSettings().GetProductionNominalMax();
					ecc.value.scale			   = 0;
					ecc.unit				   = "W";

					eccs.Add( ecc );
				}

				payload.cmd[0].electricalConnectionCharacteristicListData.electricalConnectionCharacteristicData = eccs.ToArray();

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
