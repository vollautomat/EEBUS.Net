using EEBUS.Messages;
using Newtonsoft.Json;

namespace EEBUS.SPINE.Commands
{
	public class ElectricalConnectionParameterDescriptionListData : SpineCmdPayload<CmdElectricalConnectionParameterDescriptionListDataType>
	{
		static ElectricalConnectionParameterDescriptionListData()
		{
			Register( "electricalConnectionParameterDescriptionListData", new Class() );
		}

		static public ulong counter = 1;

		public new class Class : SpineCmdPayload<CmdElectricalConnectionParameterDescriptionListDataType>.Class
		{
			public override SpineCmdPayloadBase CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				if ( datagram.header.cmdClassifier == "read" )
				{
					ElectricalConnectionParameterDescriptionListData payload = new ElectricalConnectionParameterDescriptionListData();
					payload.cmd = [new()];
					ElectricalConnectionParameterDescriptionListDataType data = payload.cmd[0].electricalConnectionParameterDescriptionListData = new();
					data.electricalConnectionParameterDescriptionData = [new(), new(), new(), new(), new(), new(), new(), new(), new(), new()];
					data.electricalConnectionParameterDescriptionData[0].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[0].measurementId			 = 0;
					data.electricalConnectionParameterDescriptionData[0].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[0].acMeasuredPhases		 = "abc";
					data.electricalConnectionParameterDescriptionData[0].acMeasuredInReferenceTo = "neutral";
					data.electricalConnectionParameterDescriptionData[0].acMeasurementType		 = "real";
					data.electricalConnectionParameterDescriptionData[0].acMeasurementVariant	 = "rms";

					data.electricalConnectionParameterDescriptionData[1].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[1].measurementId			 = 1;
					data.electricalConnectionParameterDescriptionData[1].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[1].acMeasurementType		 = "real";

					data.electricalConnectionParameterDescriptionData[2].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[2].measurementId			 = 2;
					data.electricalConnectionParameterDescriptionData[2].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[2].acMeasurementType		 = "real";

					data.electricalConnectionParameterDescriptionData[3].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[3].measurementId			 = 3;
					data.electricalConnectionParameterDescriptionData[3].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[3].acMeasuredPhases		 = "a";

					data.electricalConnectionParameterDescriptionData[4].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[4].measurementId			 = 4;
					data.electricalConnectionParameterDescriptionData[4].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[4].acMeasuredPhases		 = "b";

					data.electricalConnectionParameterDescriptionData[5].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[5].measurementId			 = 5;
					data.electricalConnectionParameterDescriptionData[5].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[5].acMeasuredPhases		 = "c";

					data.electricalConnectionParameterDescriptionData[6].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[6].measurementId			 = 6;
					data.electricalConnectionParameterDescriptionData[6].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[6].acMeasuredPhases		 = "a";
					data.electricalConnectionParameterDescriptionData[6].acMeasuredInReferenceTo = "neutral";
					data.electricalConnectionParameterDescriptionData[6].acMeasurementType		 = "apparent";
					data.electricalConnectionParameterDescriptionData[6].acMeasurementVariant	 = "rms";

					data.electricalConnectionParameterDescriptionData[7].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[7].measurementId			 = 7;
					data.electricalConnectionParameterDescriptionData[7].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[7].acMeasuredPhases		 = "b";
					data.electricalConnectionParameterDescriptionData[7].acMeasuredInReferenceTo = "neutral";
					data.electricalConnectionParameterDescriptionData[7].acMeasurementType		 = "apparent";
					data.electricalConnectionParameterDescriptionData[7].acMeasurementVariant	 = "rms";

					data.electricalConnectionParameterDescriptionData[8].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[8].measurementId			 = 8;
					data.electricalConnectionParameterDescriptionData[8].voltageType			 = "ac";
					data.electricalConnectionParameterDescriptionData[8].acMeasuredPhases		 = "c";
					data.electricalConnectionParameterDescriptionData[8].acMeasuredInReferenceTo = "neutral";
					data.electricalConnectionParameterDescriptionData[8].acMeasurementType		 = "apparent";
					data.electricalConnectionParameterDescriptionData[8].acMeasurementVariant	 = "rms";

					data.electricalConnectionParameterDescriptionData[9].electricalConnectionId	 = 0;    // ToDo: source??
					data.electricalConnectionParameterDescriptionData[9].measurementId			 = 9;
					data.electricalConnectionParameterDescriptionData[9].voltageType			 = "ac";

					return payload;
				}
				else if ( datagram.header.cmdClassifier == "write" )
				{
					return new ResultData();
				}
				else
				{
					return null;
				}
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdElectricalConnectionParameterDescriptionListDataType : CmdType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ElectricalConnectionParameterDescriptionListDataType electricalConnectionParameterDescriptionListData { get; set; }
	}

	[System.SerializableAttribute()]
	public class ElectricalConnectionParameterDescriptionListDataType
	{
		public ElectricalConnectionParameterDescriptionDataType[] electricalConnectionParameterDescriptionData { get; set; }
	}

	[System.SerializableAttribute()]
	public class ElectricalConnectionParameterDescriptionDataType
	{
		public uint	  electricalConnectionId  { get; set; }
		public uint	  measurementId			  { get; set; }
		public string voltageType			  { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string acMeasuredPhases		  { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string acMeasuredInReferenceTo { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string acMeasurementType		  { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string acMeasurementVariant	  { get; set; }
	}
}
