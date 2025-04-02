using System;
using System.Threading.Tasks;
using System.Net.WebSockets;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class AccessMethodsRequestMessage : JsonControlMessage<AccessMethodsRequestMessage>
	{
		static AccessMethodsRequestMessage()
		{
			Register( new Class() );
		}

		public AccessMethodsRequestMessage()
		{
		}

		public new class Class : JsonControlMessage<AccessMethodsRequestMessage>.Class
		{
			public override AccessMethodsRequestMessage Create( byte[] data )
			{
				return template.FromJsonVirtual( data );
			}
		}

		public AccessMethodsRequestType accessMethodsRequest { get; set; } = new AccessMethodsRequestType();
	
		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForAccessMethodsRequest )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.WaitingForAccessMethods, Server.SubState.None);
			}

			throw new Exception( "Was waiting for AccessMethodsRequest" );
		}
	}

	[System.SerializableAttribute()]
	public class AccessMethodsRequestType
	{
	}
}
