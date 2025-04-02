using System;
using System.Threading.Tasks;
using System.Net.WebSockets;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class AccessMethodsMessage : JsonControlMessage<AccessMethodsMessage>
	{
		static AccessMethodsMessage()
		{
			Register( new Class() );
		}

		public AccessMethodsMessage()
		{
		}

		public AccessMethodsMessage( string id )
		{
			this.accessMethods.id = id;
		}

		public AccessMethodsType accessMethods { get; set; } = new AccessMethodsType();
		
		public new class Class : JsonControlMessage<AccessMethodsMessage>.Class
		{
			public override AccessMethodsMessage Create( byte[] data )
			{
				return template.FromJsonVirtual( data );
			} 			
		}

		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForAccessMethods )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.WaitingForCloseInitOrData, Server.SubState.None);
			}

			throw new Exception( "Was waiting for AccessMethods" );
		}

		public override async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subState )
		{
			if ( state == Client.State.WaitingForAccessMethods )
			{
				return (Client.State.Connected, Client.SubState.None);
			}

			throw new Exception( "Was waiting for AccessMethods" );
		}
	}

	[System.SerializableAttribute()]
	public class AccessMethodsType
	{
		public string id { get; set; }

		public AccessMethodsTypeDnsSd_mDns dnsSd_mDns { get; set; }

		public AccessMethodsTypeDns dns { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class AccessMethodsTypeDnsSd_mDns
	{
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class AccessMethodsTypeDns
	{
		public string uri { get; set; }
	}
}
