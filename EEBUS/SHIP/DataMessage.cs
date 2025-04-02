using EEBUS.Messages;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System;

namespace EEBUS.SHIP.Messages
{
	public class DataMessage : JsonDataMessage<DataMessage>
	{
		static DataMessage()
		{
			Register( new Class() );
		}

		public DataMessage()
		{
		}

		public DataMessage( object payload )
		{
			this.data.payload = payload;
		}

		public DataMessage( string protocolId, object payload )
		{
			this.data.header.protocolId = protocolId;
			this.data.payload = payload;
		}

		public new class Class : JsonDataMessage<DataMessage>.Class
		{
			public override DataMessage Create( byte[] data )
			{
				return template.FromJsonVirtual(data);
			}
		}

		public DataType data { get; set; } = new DataType();

		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForCloseInitOrData )
			{
				await Send(ws).ConfigureAwait( false );
				return (Server.State.WaitingForCloseInitOrData, Server.SubState.None);
			}

			throw new Exception( "Was waiting for Data" );
		}
	}

	[System.SerializableAttribute()]
	public class DataType
	{
		public HeaderType header { get; set; } = new HeaderType();

		public object payload { get; set; }

		public ExtensionType extension { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class HeaderType
	{
		public string protocolId { get; set; }
	}

	[System.SerializableAttribute()]
	public partial class ExtensionType
	{
		public string extensionId { get; set; }

		public byte[] binary { get; set; }

		public string @string { get; set; }
	}
}
