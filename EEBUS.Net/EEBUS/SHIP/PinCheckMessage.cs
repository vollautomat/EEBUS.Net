﻿using System;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Text.Json.Serialization;

using Newtonsoft.Json.Converters;

using EEBUS.Messages;
using System.Net;
using System.Data;

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

		public override (Connection.EState, Connection.ESubState, string) ServerTest( Connection.EState state )
		{
			string		 error	  = null;
			Connection.EState newState = state;

			if ( this.connectionPinState.pinState != PinStateType.none )
			{
				error = "Pinstate none expected!";
				newState = Connection.EState.Stopped;
			}
			if (this.connectionPinState.inputPermissionSpecified != false)
			{
				error = "Pinstate inputPermissionSpecified expected!";
				newState = Connection.EState.Stopped;
			}

			return (newState, Connection.ESubState.None, error);
		}

		public override async Task<(Connection.EState, Connection.ESubState)> NextServerState( Connection connection )
		{
			if ( connection.State == Connection.EState.WaitingForPinCheck )
			{
				await Send( connection.WebSocket ).ConfigureAwait( false );
				return (Connection.EState.WaitingForAccessMethodsRequest, Connection.ESubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}

		public override (Connection.EState, Connection.ESubState, string) ClientTest( Connection.EState state )
		{
			string		 error	  = null;
			Connection.EState newState = state;

			if ( this.connectionPinState.pinState != PinStateType.none )
			{
				error = "Pinstate none expected!";
				newState = Connection.EState.Stopped;
			}
			if (this.connectionPinState.inputPermissionSpecified != false)
			{
				error = "Pinstate inputPermissionSpecified expected!";
				newState = Connection.EState.Stopped;
			}

			return (newState, Connection.ESubState.None, error);
		}
	
		public override async Task<(Connection.EState, Connection.ESubState)> NextClientState( Connection connection )
		{
			if ( connection.State == Connection.EState.WaitingForPinCheck )
			{
				AccessMethodsRequestMessage method = new AccessMethodsRequestMessage();
				await method.Send( connection.WebSocket ).ConfigureAwait( false );

				return (Connection.EState.WaitingForAccessMethodsRequest, Connection.ESubState.None);
			}

			throw new Exception( "Was waiting for PinCheckit" );
		}
	}

	[System.SerializableAttribute()]
	public class ConnectionPinStateType
	{
		public PinStateType	pinState				 { get; set; }

		public bool			inputPermissionSpecified { get; set; }
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
