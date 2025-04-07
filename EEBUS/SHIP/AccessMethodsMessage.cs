using System;
using System.Threading.Tasks;
using System.Net.WebSockets;

using EEBUS.Messages;
using Newtonsoft.Json;

namespace EEBUS.SHIP.Messages
{
	public class AccessMethodsMessage : ShipControlMessage<AccessMethodsMessage>
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

		public AccessMethodsType accessMethods { get; set; } = new();
		
		public new class Class : ShipControlMessage<AccessMethodsMessage>.Class
		{
			public override AccessMethodsMessage Create( byte[] data, Server server )
			{
				return template.FromJsonVirtual( data, server );
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

#pragma warning disable CS1998
		public override async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subState )
#pragma warning restore CS1998
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
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
		public string id { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
		public AccessMethodsTypeDnsSd_mDns dnsSd_mDns { get; set; }

		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
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
