using EEBUS.Messages;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace EEBUS.SHIP.Messages
{
	public class DataMessage : ShipDataMessage<DataMessage>
	{
		static DataMessage()
		{
			Register( new Class() );
		}

		public DataMessage()
		{
		}

		public DataMessage( JObject payload )
		{
			this.data.payload = payload;
		}

		public DataMessage( string protocolId, JObject payload )
		{
			this.data.header.protocolId = protocolId;
			this.data.payload			= payload;
		}

		public DataMessage( SpineDatagramPayload datagram )
		{
			this.data.payload = JObject.FromObject( datagram );
		}

		public new class Class : ShipDataMessage<DataMessage>.Class
		{
			public override DataMessage Create( byte[] data, Server server )
			{
				DataMessage dm = template.FromJsonVirtual( data, server );
				return dm;
			}
		}

		public DataType		  data { get; set; } = new();
		
		static private object mutex = new();
		static private ulong  count = 1; 

		static public ulong NextCount
		{
			get
			{
				lock ( mutex )
				{
					return count++;
				}
			}
		}

		public void SetPayload( JObject payload )
		{
			this.data.payload = payload;
		}

		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForCloseInitOrData )
			{
				if ( this.data.payload.ContainsKey( "datagram" ) )
				{
					SpineDatagramPayload datagram = this.data.payload.ToObject<SpineDatagramPayload>();
					SpineDatagramPayload answer = datagram.CreateAnswer( NextCount, this.server );

					if ( null != answer )
					{
						DataMessage reply = new DataMessage( answer );
						if ( null != reply )
						{
							await reply.Send( ws ).ConfigureAwait( false );
							return (Server.State.WaitingForCloseInitOrData, Server.SubState.None);
						}
						else
						{
							GetType();
						}
					}
					else
					{
						GetType();
					}
				}
			}

			throw new Exception( "Was waiting for Data" );
		}
	}

	[System.SerializableAttribute()]
	public class DataType
	{
		public HeaderType header { get; set; } = new();

		public JObject payload { get; set; }

		[JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
		public ExtensionType extension { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class HeaderType
	{
		public string protocolId { get; set; } = "ee1.0";
	}

	[System.SerializableAttribute()]
	public partial class ExtensionType
	{
		public string extensionId { get; set; }

		public byte[] binary { get; set; }

		public string @string { get; set; }
	}
}
