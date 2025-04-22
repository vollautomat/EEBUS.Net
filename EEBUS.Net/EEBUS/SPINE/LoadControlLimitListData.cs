﻿
using System.Diagnostics;
using System.Xml;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using EEBUS.DataStructures;
using EEBUS.Messages;
using EEBUS.SHIP.Messages;
using EEBUS.UseCases.ControllableSystem;

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
			public override SpineCmdPayloadBase CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				if ( datagram.header.cmdClassifier == "read" )
				{
					LoadControlLimitListData	 payload = new LoadControlLimitListData();
					LoadControlLimitListDataType data	 = payload.cmd[0].loadControlLimitListData;

					List<LoadControlLimitDataType> datas = new();
					foreach ( LoadControlLimitDataStructure structure in connection.Local.GetDataStructures<LoadControlLimitDataStructure>() )
						datas.Add( structure.Data );

					data.loadControlLimitData = datas.ToArray();

					return payload;
				}
				else if ( datagram.header.cmdClassifier == "write" )
				{
					return new ResultData();	// Alternative: send Error 7 and a text message
				}
				else
				{
					return null;
				}
			}

			public override void Evaluate( Connection connection, DatagramType datagram )
			{
				if ( datagram.header.cmdClassifier != "write" )
					return;

				LoadControlLimitListData command  = datagram.payload.ToObject<LoadControlLimitListData>();
				LoadControlLimitDataType received = command.cmd[0].loadControlLimitListData.loadControlLimitData[0];

				LoadControlLimitDataStructure data = connection.Local.GetDataStructure<LoadControlLimitDataStructure>( received.limitId );

				data.LimitActive = received.isLimitActive;
				data.Number		 = received.value.number;
				data.EndTime	 = received.timePeriod.endTime;

				data.SendEvent( connection );

				SendNotify( connection, datagram );
			}

			private void SendNotify( Connection connection, DatagramType datagram )
			{
				SpineDatagramPayload notify = new SpineDatagramPayload();
				notify.datagram.header.addressSource	  = datagram.header.addressDestination;
				notify.datagram.header.addressDestination = datagram.header.addressSource;
				notify.datagram.header.msgCounter		  = DataMessage.NextCount;
				notify.datagram.header.cmdClassifier	  = "notify";

				LoadControlLimitListData	 limitData = new LoadControlLimitListData();
				LoadControlLimitListDataType data	   = limitData.cmd[0].loadControlLimitListData;

				List<LoadControlLimitDataType> datas = new();
				foreach (LoadControlLimitDataStructure structure in connection.Local.GetDataStructures<LoadControlLimitDataStructure>())
					datas.Add(structure.Data);

				data.loadControlLimitData = datas.ToArray();

				notify.datagram.payload = JObject.FromObject( limitData );

				DataMessage limitMessage = new DataMessage();
				limitMessage.SetPayload( JObject.FromObject( notify ) );

				connection.PushDataMessage( limitMessage );
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
		public uint				limitId			  { get; set; }

		public bool				isLimitChangeable { get; set; }

		public bool				isLimitActive	  { get; set; }

		public TimePeriodType	timePeriod		  { get; set; } = new();

		public ScaledNumberType	value			  { get; set; } = new();
	}

	[System.SerializableAttribute()]
	public class TimePeriodType
	{
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string startTime	{ get; set; }

		public string endTime	{ get; set; }
	}
}
