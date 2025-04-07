using System;
using System.Threading.Tasks;
using System.Net.WebSockets;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class AccessMethodsRequestMessage : ShipControlMessage<AccessMethodsRequestMessage>
	{
		static AccessMethodsRequestMessage()
		{
			Register( new Class() );
		}

		public AccessMethodsRequestMessage()
		{
		}

		public new class Class : ShipControlMessage<AccessMethodsRequestMessage>.Class
		{
			public override AccessMethodsRequestMessage Create( byte[] data, Server server )
			{
				return template.FromJsonVirtual( data, server );
			}
		}

		public AccessMethodsRequestType accessMethodsRequest { get; set; } = new();
	
		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForAccessMethodsRequest )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.WaitingForAccessMethods, Server.SubState.None);
			}

			throw new Exception( "Was waiting for AccessMethodsRequest" );
		}

		public override async Task<(Client.State, Client.SubState)> NextState(WebSocket ws, Client.State state, Client.SubState subState)
		{
			if ( state == Client.State.WaitingForAccessMethodsRequest )
			{
				AccessMethodsMessage method = new AccessMethodsMessage( Client.Settings.Id );
				await method.Send( ws ).ConfigureAwait( false );

				return (Client.State.WaitingForAccessMethods, Client.SubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}
	}

	[System.SerializableAttribute()]
	public class AccessMethodsRequestType
	{
	}
}
