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
			public override AccessMethodsMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			} 			
		}

		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForAccessMethods )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Connection.State.Connected, Connection.SubState.None);
			}

			throw new Exception( "Was waiting for AccessMethods" );
		}

#pragma warning disable CS1998
		public override async Task<(Connection.State, Connection.SubState)> NextClientState( WebSocket ws, Connection.State state, Connection.SubState subState )
#pragma warning restore CS1998
		{
			if ( state == Connection.State.WaitingForAccessMethods )
			{
				return (Connection.State.Connected, Connection.SubState.None);
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
