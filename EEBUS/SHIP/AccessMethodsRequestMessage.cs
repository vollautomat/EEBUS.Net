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
			public override AccessMethodsRequestMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			}
		}

		public AccessMethodsRequestType accessMethodsRequest { get; set; } = new();
	
		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForAccessMethodsRequest )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Connection.State.WaitingForAccessMethods, Connection.SubState.None);
			}

			throw new Exception( "Was waiting for AccessMethodsRequest" );
		}

		public override async Task<(Connection.State, Connection.SubState)> NextClientState(WebSocket ws, Connection.State state, Connection.SubState subState)
		{
			if ( state == Connection.State.WaitingForAccessMethodsRequest )
			{
				AccessMethodsMessage method = new AccessMethodsMessage( Client.Settings.Id );
				await method.Send( ws ).ConfigureAwait( false );

				return (Connection.State.WaitingForAccessMethods, Connection.SubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}
	}

	[System.SerializableAttribute()]
	public class AccessMethodsRequestType
	{
	}
}
