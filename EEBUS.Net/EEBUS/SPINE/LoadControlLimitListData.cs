
using EEBUS.Messages;
using EEBUS.SHIP.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using System.Xml;

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
					LoadControlLimitListData command  = datagram.payload.ToObject<LoadControlLimitListData>();
					LoadControlLimitDataType received = command.cmd[0].loadControlLimitListData.loadControlLimitData[0];

					bool	 active	  = received.isLimitActive;
					TimeSpan timeSpan = XmlConvert.ToTimeSpan( received.timePeriod.endTime );
					long	 value	  = received.value.number;

					Debug.WriteLine( "----------- Limit received -----------" );
					Debug.WriteLine( "Limit active:   " + active );
					Debug.WriteLine( "Limit duration: " + timeSpan );
					Debug.WriteLine( "Limit value:    " + value );
					Debug.WriteLine( "--------------------------------------" );

					SpineDatagramPayload notify = CreateNotifyMessage( datagram, header.msgCounter );

					DataMessage limitMessage = new DataMessage();
					limitMessage.SetPayload( JObject.FromObject( notify ) );

					await limitMessage.Send( connection.WebSocket ).ConfigureAwait( false );

					header.msgCounter = DataMessage.NextCount;
					return new ResultData();
				}
				else
				{
					return null;
				}
			}

			public SpineDatagramPayload CreateNotifyMessage( DatagramType datagram, ulong msgCounter )
			{
				LoadControlLimitListData command  = datagram.payload.ToObject<LoadControlLimitListData>();
				LoadControlLimitDataType received = command.cmd[0].loadControlLimitListData.loadControlLimitData[0];

				SpineDatagramPayload notify = new SpineDatagramPayload();
				notify.datagram.header.addressSource	  = datagram.header.addressDestination;
				notify.datagram.header.addressDestination = datagram.header.addressSource;
				notify.datagram.header.msgCounter		  = msgCounter;
				notify.datagram.header.cmdClassifier	  = "notify";

				LoadControlLimitListData	 limitData = new LoadControlLimitListData();
				LoadControlLimitListDataType data	   = limitData.cmd[0].loadControlLimitListData;

				data.loadControlLimitData = [new()];
				data.loadControlLimitData[0].limitId			= received.limitId;
				data.loadControlLimitData[0].isLimitChangeable	= true;
				data.loadControlLimitData[0].isLimitActive		= received.isLimitActive;
				data.loadControlLimitData[0].timePeriod.endTime	= received.timePeriod.endTime;
				data.loadControlLimitData[0].value.number		= received.value.number;
				data.loadControlLimitData[0].value.scale		= received.value.scale;

				notify.datagram.payload = JObject.FromObject( limitData );

				return notify;
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
