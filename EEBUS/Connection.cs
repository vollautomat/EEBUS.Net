using EEBUS.Messages;
using EEBUS.Models;
using EEBUS.SHIP.Messages;
using EEBUS.SPINE.Commands;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.WebSockets;
using AddressType = EEBUS.Messages.AddressType;

namespace EEBUS
{
	public class Connection
	{
		protected HostString host;
		protected WebSocket	 ws;
		protected EState	 state;
		protected ESubState	 subState;

		private AddressType  heartbeatSource;
		private AddressType  heartbeatDestination;

		public enum EState
		{
			WaitingForInit,
			WaitingForConnectionHello,
			WaitingForProtocolHandshake,
			SendProtocolHandshakeError,
			SendProtocolHandshakeConfirm,
			WaitingForProtocolHandshakeConfirm,
			WaitingForPinCheck,
			WaitingForAccessMethodsRequest,
			WaitingForAccessMethods,
			Connected,
			Stop,
			ErrorOrTimeout
		}

		public enum ESubState
		{
			None,
			FirstPending,
			SecondPending,
			UnexpectedMessage,
			FormatMismatch
		}

		protected class Heart
		{
			// This method is called by the timer delegate.
			public async void Beat( object connectionObj )
			{
				Connection connection = (Connection) connectionObj;
				
				if ( connection.State == Connection.EState.Connected )
				{
					if ( connection is Server )
						Debug.WriteLine( "--- Heartbeat per Server senden ---" );
					else
						Debug.WriteLine( "--- Heartbeat per Client senden ---" );

					SpineDatagramPayload reply = new SpineDatagramPayload();
					reply.datagram.header.addressSource		 = connection.heartbeatSource;
					reply.datagram.header.addressDestination = connection.heartbeatDestination;
					reply.datagram.header.msgCounter		 = DataMessage.NextCount;
					reply.datagram.header.cmdClassifier		 = "notify";

					DeviceDiagnosisHeartbeatData heartbeat = new DeviceDiagnosisHeartbeatData();
					reply.datagram.payload = JObject.FromObject( heartbeat );
					
					DataMessage heartbeatMessage = new DataMessage();
					heartbeatMessage.SetPayload( JObject.FromObject( reply ) );

					await heartbeatMessage.Send( connection.ws ).ConfigureAwait( false );
				}
			}
		}

		public Connection( HostString host, WebSocket ws, Devices devices )
		{
			this.host	 = host;
			this.ws		 = ws;
			this.devices = devices;
		}

		public WebSocket   WebSocket { get { return this.ws; } }

		public EState	   State	 { get { return this.state; } }

		public ESubState   SubState	 { get { return this.subState; } }


		private Devices	   devices;

		public LocalDevice Local
		{
			get
			{
				return this.devices.Local;
			}
		}

		public void SetHeartbeatAddresses( AddressType source, AddressType destination )
		{
			this.heartbeatSource	  = source;
			this.heartbeatDestination = destination;
		}
	}
}
