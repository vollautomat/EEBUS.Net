using System;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Text.Json.Serialization;

using Newtonsoft.Json.Converters;

using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class PinCheckMessage : JsonControlMessage<PinCheckMessage>
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

		public new class Class : JsonControlMessage<PinCheckMessage>.Class
		{
			public override PinCheckMessage Create( byte[] data )
			{
				return template.FromJsonVirtual(data);
			}
		}

		public ConnectionPinStateType connectionPinState { get; set; } = new ConnectionPinStateType();

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

			throw new Exception( "Was waiting for inPinCheckit" );
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
