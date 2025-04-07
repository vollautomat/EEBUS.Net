
using EEBUS.Messages;
using Newtonsoft.Json;

namespace EEBUS.SPINE.Commands
{
	public class LoadControlLimitListData : SpineCmdPayload<CmdLoadControlLimitListDataType>
	{
		static LoadControlLimitListData()
		{
			Register( "loadControlLimitListData", new Class() );
		}

		public new class Class : SpineCmdPayload<CmdLoadControlLimitListDataType>.Class
		{
			public override SpineCmdPayloadBase CreateAnswer( HeaderType header, Server server )
			{
				LoadControlLimitListData	 payload = new LoadControlLimitListData();
				LoadControlLimitListDataType data	 = payload.cmd[0].loadControlLimitListData;

				data.loadControlLimitData = [new()];
				data.loadControlLimitData[0].limitId			= 0;
				data.loadControlLimitData[0].isLimitChangeable  = true;
				data.loadControlLimitData[0].isLimitActive		= true;
				data.loadControlLimitData[0].timePeriod.endTime = "PT2H";
				data.loadControlLimitData[0].value.number		= 4211;
				data.loadControlLimitData[0].value.scale		= 0;

				return payload;
			}
		}
	}

	[System.SerializableAttribute()]
	public class CmdLoadControlLimitListDataType : CmdType
	{
		public LoadControlLimitListDataType loadControlLimitListData { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class LoadControlLimitListDataType
	{
		public LoadControlLimitDataType[] loadControlLimitData { get; set; }
	}

	[System.SerializableAttribute()]
	public class LoadControlLimitDataType
	{
		public uint limitId { get; set; }

		public bool isLimitChangeable { get; set; }

		public bool isLimitActive { get; set; }

		public TimePeriodType timePeriod { get; set; } = new();

		public ScaledNumberType value { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class TimePeriodType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string startTime { get; set; }

		public string endTime { get; set; }
	}
}
