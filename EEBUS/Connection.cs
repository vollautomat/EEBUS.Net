using EEBUS.Messages;
using EEBUS.SHIP.Messages;
using EEBUS.SPINE.Commands;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.WebSockets;
using AddressType = EEBUS.Messages.AddressType;

namespace EEBUS
{
	public class Connection
	{
		protected string	host;
		protected WebSocket ws;
		protected State		state;
		protected SubState	subState;

		private AddressType heartbeatSource;
		private AddressType heartbeatDestination;

		static private Settings settings;

		public enum State
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

		public enum SubState
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
				
				if ( connection.state == Connection.State.Connected )
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

		public Connection( string host, WebSocket ws, Settings settings )
		{
			this.host = host;
			this.ws	  = ws;

			Connection.settings = settings;
		}

		public static Settings Settings { get { return settings; } }

		public void SetHeartbeatAddresses( AddressType source, AddressType destination )
		{
			this.heartbeatSource	  = source;
			this.heartbeatDestination = destination;
		}
	}
}
