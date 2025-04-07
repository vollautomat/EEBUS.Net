using System;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Text.Json.Serialization;

using Newtonsoft.Json.Converters;

using EEBUS.Messages;
using System.Net;

namespace EEBUS.SHIP.Messages
{
	public class PinCheckMessage : ShipControlMessage<PinCheckMessage>
	{
		static PinCheckMessage()
		{
			Register( new Class() );
		}

		public PinCheckMessage()
		{
		}

		public PinCheckMessage( PinStateType pinState )
		{
			this.connectionPinState.pinState = pinState;
		}

		public new class Class : ShipControlMessage<PinCheckMessage>.Class
		{
			public override PinCheckMessage Create( byte[] data, Server server )
			{
				return template.FromJsonVirtual( data, server );
			}
		}

		public ConnectionPinStateType connectionPinState { get; set; } = new();

		public override (Server.State, Server.SubState, string) Test( Server.State state )
		{
			string		 error	  = null;
			Server.State newState = state;

			if ( this.connectionPinState.pinState != PinStateType.none )
			{
				error = "Pinstate none expected!";
				newState = Server.State.Stop;
			}
			if (this.connectionPinState.inputPermissionSpecified != false)
			{
				error = "Pinstate inputPermissionSpecified expected!";
				newState = Server.State.Stop;
			}

			return (newState, Server.SubState.None, error);
		}

		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForPinCheck )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.WaitingForAccessMethodsRequest, Server.SubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}

		public override (Client.State, Client.SubState, string) Test( Client.State state )
		{
			string		 error	  = null;
			Client.State newState = state;

			if ( this.connectionPinState.pinState != PinStateType.none )
			{
				error = "Pinstate none expected!";
				newState = Client.State.Stop;
			}
			if (this.connectionPinState.inputPermissionSpecified != false)
			{
				error = "Pinstate inputPermissionSpecified expected!";
				newState = Client.State.Stop;
			}

			return (newState, Client.SubState.None, error);
		}
	
		public override async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subState )
		{
			if ( state == Client.State.WaitingForPinCheck )
			{
				AccessMethodsRequestMessage method = new AccessMethodsRequestMessage();
				await method.Send( ws ).ConfigureAwait( false );

				return (Client.State.WaitingForAccessMethodsRequest, Client.SubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}
	}

	[System.SerializableAttribute()]
	public class ConnectionPinStateType
	{
		public PinStateType pinState { get; set; }

		public bool inputPermissionSpecified { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PinStateType
	{
		required,
		optional,
		pinOk,
		none,
	}
}
