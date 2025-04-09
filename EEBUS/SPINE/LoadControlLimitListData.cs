
using EEBUS.Messages;
using EEBUS.SHIP.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

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
			public override async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				if ( datagram.header.cmdClassifier == "read" )
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
				else if ( datagram.header.cmdClassifier == "write" )
				{
					LoadControlLimitListData command = datagram.payload.ToObject<LoadControlLimitListData>();

					Debug.WriteLine( "Limit active:   " + command.cmd[0].loadControlLimitListData.loadControlLimitData[0].isLimitActive.ToString() );
					Debug.WriteLine( "Limit duration: " + command.cmd[0].loadControlLimitListData.loadControlLimitData[0].timePeriod.endTime );
					Debug.WriteLine( "Limit value:    " + command.cmd[0].loadControlLimitListData.loadControlLimitData[0].value.number.ToString() );

					SpineDatagramPayload notify = new SpineDatagramPayload();
					notify.datagram.header.addressSource	  = datagram.header.addressDestination;
					notify.datagram.header.addressDestination = datagram.header.addressSource;
					notify.datagram.header.msgCounter		  = header.msgCounter;
					notify.datagram.header.cmdClassifier	  = "notify";

					header.msgCounter = DataMessage.NextCount;

					LoadControlLimitListData	 limitData = new LoadControlLimitListData();					
					LoadControlLimitListDataType data	   = limitData.cmd[0].loadControlLimitListData;

					data.loadControlLimitData = [new()];
					data.loadControlLimitData[0].limitId			= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].limitId;
					data.loadControlLimitData[0].isLimitChangeable	= true;
					data.loadControlLimitData[0].isLimitActive		= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].isLimitActive;
					data.loadControlLimitData[0].timePeriod.endTime = command.cmd[0].loadControlLimitListData.loadControlLimitData[0].timePeriod.endTime;
					data.loadControlLimitData[0].value.number		= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].value.number;
					data.loadControlLimitData[0].value.scale		= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].value.scale;

					notify.datagram.payload = JObject.FromObject( limitData );

					DataMessage limitMessage = new DataMessage();
					limitMessage.SetPayload( JObject.FromObject( notify ) );

					await limitMessage.Send( connection.WebSocket ).ConfigureAwait( false );

					return new ResultData();
				}
				else
				{
					return null;
				}
			}
					
			//public override SpineCmdPayloadBase CreateNotify( DatagramType datagram )
			//{
			//	LoadControlLimitListData	 payload = new LoadControlLimitListData();
			//	LoadControlLimitListDataType data	 = payload.cmd[0].loadControlLimitListData;

			//	LoadControlLimitListData	 command = datagram.payload.ToObject<LoadControlLimitListData>();

			//	Debug.WriteLine($"Limit active:   {0}", command.cmd[0].loadControlLimitListData.loadControlLimitData[0].isLimitActive);
			//	Debug.WriteLine($"Limit duration: {0}", command.cmd[0].loadControlLimitListData.loadControlLimitData[0].timePeriod.endTime);
			//	Debug.WriteLine($"Limit value:    {0}", command.cmd[0].loadControlLimitListData.loadControlLimitData[0].value.number);

			//	data.loadControlLimitData = [new()];
			//	data.loadControlLimitData[0].limitId			= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].limitId;
			//	data.loadControlLimitData[0].isLimitChangeable	= true;
			//	data.loadControlLimitData[0].isLimitActive		= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].isLimitActive;
			//	data.loadControlLimitData[0].timePeriod.endTime = command.cmd[0].loadControlLimitListData.loadControlLimitData[0].timePeriod.endTime;
			//	data.loadControlLimitData[0].value.number		= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].value.number;
			//	data.loadControlLimitData[0].value.scale		= command.cmd[0].loadControlLimitListData.loadControlLimitData[0].value.scale;
				
			//	return payload;
			//}
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
