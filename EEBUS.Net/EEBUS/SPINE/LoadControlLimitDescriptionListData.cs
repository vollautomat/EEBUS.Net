
using EEBUS.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;

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
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				LoadControlLimitDescriptionListData	    payload = new LoadControlLimitDescriptionListData();
				LoadControlLimitDescriptionListDataType data	= payload.cmd[0].loadControlLimitDescriptionListData;

				data.loadControlLimitDescriptionData = [new()];
				data.loadControlLimitDescriptionData[0].limitId		   = 0;
				data.loadControlLimitDescriptionData[0].limitType	   = "signDependentAbsValueLimit";
				data.loadControlLimitDescriptionData[0].limitCategory  = "obligation";
				data.loadControlLimitDescriptionData[0].limitDirection = "consume";
				data.loadControlLimitDescriptionData[0].measurementId  = 0;
				data.loadControlLimitDescriptionData[0].unit		   = "W";
				data.loadControlLimitDescriptionData[0].scopeType	   = "activePowerLimit";

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
		public uint	  limitId		 { get; set; }

		public string limitType		 { get; set; }

		public string limitCategory	 { get; set; }

		public string limitDirection { get; set; }

		public uint	  measurementId	 { get; set; }
		
		public string unit			 { get; set; }
		
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
		public string scopeType		 { get; set; }
		
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
		public string label			 { get; set; }
	}
}
