
using EEBUS.Messages;
using Newtonsoft.Json;

namespace EEBUS.SPINE.Commands
{
	public class LoadControlLimitDescriptionListData : SpineCmdPayload<CmdLoadControlLimitDescriptionListDataType>
	{
		static LoadControlLimitDescriptionListData()
		{
			Register( "loadControlLimitDescriptionListData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdLoadControlLimitDescriptionListDataType>.Class
		{
			public override SpineCmdPayloadBase CreateAnswer( HeaderType header, Connection connection )
			{
				LoadControlLimitDescriptionListData	    payload = new LoadControlLimitDescriptionListData();
				LoadControlLimitDescriptionListDataType data	= payload.cmd[0].loadControlLimitDescriptionListData;

				data.loadControlLimitDescriptionData = [new(), new()];
				data.loadControlLimitDescriptionData[0].limitId		   = 0;
				data.loadControlLimitDescriptionData[0].limitType	   = "signDependentAbsValueLimit";
				data.loadControlLimitDescriptionData[0].limitCategory  = "obligation";
				data.loadControlLimitDescriptionData[0].limitDirection = "consume";
				data.loadControlLimitDescriptionData[1].measurementId  = 0;
				data.loadControlLimitDescriptionData[1].unit		   = "W";
				data.loadControlLimitDescriptionData[1].scopeType	   = "activePowerLimit";

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdLoadControlLimitDescriptionListDataType : CmdType
	{
		public LoadControlLimitDescriptionListDataType loadControlLimitDescriptionListData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class LoadControlLimitDescriptionListDataType
	{
		public LoadControlLimitDescriptionDataType[] loadControlLimitDescriptionData { get; set; }
	}

	[System.SerializableAttribute()]
	public class LoadControlLimitDescriptionDataType
	{
		public uint limitId { get; set; }

		public string limitType { get; set; }

		public string limitCategory { get; set; }

		public string limitDirection { get; set; }

		public uint measurementId { get; set; }
		
		public string unit { get; set; }
		
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
		public string scopeType { get; set; }
		
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
		public string label { get; set; }
	}
}
