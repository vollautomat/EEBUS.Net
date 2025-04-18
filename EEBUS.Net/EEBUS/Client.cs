﻿using System.Net.WebSockets;

using Microsoft.AspNetCore.Http;

using EEBUS.Enums;
using EEBUS.Messages;
using EEBUS.Models;
using EEBUS.SHIP.Messages;

namespace EEBUS
{
	public class Client : Connection
	{
		public Client( HostString host, WebSocket ws, Devices devices, RemoteDevice remoteDevice )
			: base( host, ws, devices )
		{
			this.remoteDevice = remoteDevice;
		}

		private RemoteDevice remoteDevice;

		public async Task<bool> Run()
		{
			this.state	  = EState.Unconnected;
			this.subState = ESubState.None;

			InitMessage initMessage = new InitMessage();
			await initMessage.Send( this.ws ).ConfigureAwait( false );

			var heart = new Heart();
			var beat  = new System.Threading.Timer( heart.Beat, this, 4000, 4000 );

			var ecc		= new ElectricalConnectionCharacteristic();
			var eccSend = new System.Threading.Timer( ecc.SendData, this, 5000, Timeout.Infinite );

			try
			{
				while ( this.state != EState.Stopped )
				{
					byte[] receiveBuffer = new byte[10240];
					WebSocketReceiveResult result = await this.ws.ReceiveAsync( receiveBuffer, new CancellationTokenSource( SHIPMessageTimeout.CMI_TIMEOUT ).Token ).ConfigureAwait( false );

					if ( result.CloseStatus.HasValue )						
						break; // close received
					else if ( result.Count < 2 )
						throw new Exception( "Invalid EEBUS payload received, expected message size of at least 2!" );

					ShipMessageBase message = ShipMessageBase.Create( receiveBuffer, this );					
					if ( message == null )
						throw new Exception( "Message couldn't be recognized" );

					(this.state, this.subState, string error) = message.ClientTest( this.state );

					if ( this.state == EState.Stopped && error != null )
						throw new Exception( error );
					if ( error != null )
						Console.WriteLine( error );

					(this.state, this.subState) = await message.NextClientState( this ).ConfigureAwait( false );

					if ( null != this.remoteDevice )
						this.remoteDevice.SetClientState( this.state );

					//if ( this.state == State.Stopped )
					//	throw new Exception( "Communication stopped!" );
					//else if ( this.state == State.Connected )
					//	break;
				}
			}
			finally
			{
				beat.Change( Timeout.Infinite, Timeout.Infinite );
				eccSend.Change( Timeout.Infinite, Timeout.Infinite );

				if ( null != this.remoteDevice )
					this.remoteDevice.SetClientState( EState.Stopped );
			}

			return true;
		}
	}
}
