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
			public override PinCheckMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			}
		}

		public ConnectionPinStateType connectionPinState { get; set; } = new();

		public override (Connection.State, Connection.SubState, string) ServerTest( Connection.State state )
		{
			string		 error	  = null;
			Connection.State newState = state;

			if ( this.connectionPinState.pinState != PinStateType.none )
			{
				error = "Pinstate none expected!";
				newState = Connection.State.Stop;
			}
			if (this.connectionPinState.inputPermissionSpecified != false)
			{
				error = "Pinstate inputPermissionSpecified expected!";
				newState = Connection.State.Stop;
			}

			return (newState, Connection.SubState.None, error);
		}

		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForPinCheck )
			{
				await Send( ws ).ConfigureAwait( false );
				return (Connection.State.WaitingForAccessMethodsRequest, Connection.SubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}

		public override (Connection.State, Connection.SubState, string) ClientTest( Connection.State state )
		{
			string		 error	  = null;
			Connection.State newState = state;

			if ( this.connectionPinState.pinState != PinStateType.none )
			{
				error = "Pinstate none expected!";
				newState = Connection.State.Stop;
			}
			if (this.connectionPinState.inputPermissionSpecified != false)
			{
				error = "Pinstate inputPermissionSpecified expected!";
				newState = Connection.State.Stop;
			}

			return (newState, Connection.SubState.None, error);
		}
	
		public override async Task<(Connection.State, Connection.SubState)> NextClientState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForPinCheck )
			{
				AccessMethodsRequestMessage method = new AccessMethodsRequestMessage();
				await method.Send( ws ).ConfigureAwait( false );

				return (Connection.State.WaitingForAccessMethodsRequest, Connection.SubState.None);
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
