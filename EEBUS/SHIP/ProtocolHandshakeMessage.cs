using System;
using System.Net.WebSockets;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Newtonsoft.Json.Converters;

using EEBUS;
using EEBUS.Enums;
using EEBUS.Messages;

namespace EEBUS.SHIP.Messages
{
	public class ProtocolHandshakeMessage : ShipControlMessage<ProtocolHandshakeMessage>
	{
		static ProtocolHandshakeMessage()
		{
			Register( new Class() );
		}

		public ProtocolHandshakeMessage()
		{
		}

		public ProtocolHandshakeMessage( ProtocolHandshakeTypeType handshakeType, ushort major, ushort minor ) 
		{
			this.messageProtocolHandshake.handshakeType = handshakeType;
			this.messageProtocolHandshake.version = new MessageProtocolHandshakeTypeVersion( major, minor );
		}

		public new class Class : ShipControlMessage<ProtocolHandshakeMessage>.Class
		{
			public override ProtocolHandshakeMessage Create( byte[] data, Connection connection )
			{
				return template.FromJsonVirtual( data, connection );
			}
		}

		public MessageProtocolHandshakeType messageProtocolHandshake { get; set; } = new();

		public bool IsEqual( ProtocolHandshakeMessage other )
		{
			return this.messageProtocolHandshake.IsEqual( other.messageProtocolHandshake );
		}

		public override (Connection.State, Connection.SubState, string) ServerTest( Connection.State state )
		{
			string			error		= null;
			Connection.State	newState	= state;
			Connection.SubState	newSubState = Connection.SubState.None;

			if ( state == Connection.State.WaitingForProtocolHandshake && this.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.announceMax )
			{
				error		= "Protocol version max announcement expected!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.UnexpectedMessage;
			}
			else if ( state == Connection.State.WaitingForProtocolHandshakeConfirm && this.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.select )
			{
				error		= "Protocol format mismatch!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.FormatMismatch;
			}
			else if ( this.messageProtocolHandshake.version.major != 1 && this.messageProtocolHandshake.version.minor != 0 )
			{
				error		= "Protocol version mismatch!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.FormatMismatch;
			}
			else if ( (this.messageProtocolHandshake.formats.format.Length == 0) || (this.messageProtocolHandshake.formats.format[0] != SHIPMessageFormat.JSON_UTF8) )
			{
				error		= "Protocol format mismatch!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.FormatMismatch;
			}

			return (newState, newSubState, error);
		}

		public override async Task<(Connection.State, Connection.SubState)> NextServerState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.WaitingForProtocolHandshake )
			{
				this.messageProtocolHandshake.handshakeType = ProtocolHandshakeTypeType.select;
				await Send( ws ).ConfigureAwait( false );
				return (Connection.State.SendProtocolHandshakeConfirm, Connection.SubState.None);
			}
			else if ( state == Connection.State.SendProtocolHandshakeConfirm )
			{
				return (Connection.State.WaitingForPinCheck, Connection.SubState.None);
			}
			else if ( state == Connection.State.SendProtocolHandshakeError && subState == Connection.SubState.FormatMismatch )
			{
				ProtocolHandshakeErrorMessage message = new ProtocolHandshakeErrorMessage( SHIPHandshakeError.SELECTION_MISMATCH );
				await message.Send( ws ).ConfigureAwait( false );
				return await message.NextServerState( ws, state, subState ).ConfigureAwait( false );
			}
			else if ( state == Connection.State.SendProtocolHandshakeError &&  subState == Connection.SubState.UnexpectedMessage )
			{
				ProtocolHandshakeErrorMessage message = new ProtocolHandshakeErrorMessage( SHIPHandshakeError.UNEXPECTED_MESSAGE );
				await message.Send( ws ).ConfigureAwait( false );
				return await message.NextServerState( ws, state, subState ).ConfigureAwait( false );
			}

			throw new Exception( "ProtocolHandshake aborted!" );
		}

		public override (Connection.State, Connection.SubState, string) ClientTest( Connection.State state )
		{
			string			error		= null;
			Connection.State	newState	= state;
			Connection.SubState newSubState	= Connection.SubState.None;

			if ( state == Connection.State.WaitingForProtocolHandshake && this.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.select )
			{
				error		= "Protocol version selection expected!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.UnexpectedMessage;
			}
			else if (state == Connection.State.WaitingForProtocolHandshakeConfirm && this.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.select)
			{
				error		= "Protocol format mismatch!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.FormatMismatch;
			}
			else if ( this.messageProtocolHandshake.version.major != 1 && this.messageProtocolHandshake.version.minor != 0 )
			{
				error		= "Protocol version mismatch!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.FormatMismatch;
			}
			else if ((this.messageProtocolHandshake.formats.format.Length == 0) || (this.messageProtocolHandshake.formats.format[0] != SHIPMessageFormat.JSON_UTF8))
			{
				error		= "Protocol format mismatch!";
				newState	= Connection.State.SendProtocolHandshakeError;
				newSubState	= Connection.SubState.FormatMismatch;
			}
			else
			{
				newState	= Connection.State.SendProtocolHandshakeConfirm;
			}
			
			return (newState, newSubState, error);
		}

		public override async Task<(Connection.State, Connection.SubState)> NextClientState( WebSocket ws, Connection.State state, Connection.SubState subState )
		{
			if ( state == Connection.State.SendProtocolHandshakeConfirm)
			{
				this.messageProtocolHandshake.handshakeType = ProtocolHandshakeTypeType.select;
				await Send( ws ).ConfigureAwait( false );

				PinCheckMessage message = new PinCheckMessage( PinStateType.none );
				await message.Send( ws ).ConfigureAwait( false );
				return (Connection.State.WaitingForPinCheck, Connection.SubState.None);
			}
			else if ( state == Connection.State.SendProtocolHandshakeError && subState == Connection.SubState.FormatMismatch )
			{
				ProtocolHandshakeErrorMessage message = new ProtocolHandshakeErrorMessage( SHIPHandshakeError.SELECTION_MISMATCH );
				await message.Send( ws ).ConfigureAwait( false );
				return await message.NextClientState( ws, state, subState ).ConfigureAwait( false );
			}
			else if ( state == Connection.State.SendProtocolHandshakeError &&  subState == Connection.SubState.UnexpectedMessage )
			{
				ProtocolHandshakeErrorMessage message = new ProtocolHandshakeErrorMessage( SHIPHandshakeError.UNEXPECTED_MESSAGE );
				await message.Send( ws ).ConfigureAwait( false );
				return await message.NextClientState( ws, state, subState ).ConfigureAwait( false );
			}

			throw new Exception( "ProtocolHandshake aborted!" );
		}
	}

	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeType
	{
		public ProtocolHandshakeTypeType handshakeType { get; set; } = new();

		public MessageProtocolHandshakeTypeVersion version { get; set; } = new();

		public MessageProtocolHandshakeTypeFormats formats { get; set; } = new( SHIPMessageFormat.JSON_UTF8 );

		public bool IsEqual( MessageProtocolHandshakeType other )
		{
			if ( this.handshakeType != other.handshakeType )
				return false;

			if ( ! this.version.IsEqual( other.version ) )
				return false;

			if ( ! this.formats.IsEqual( other.formats ) )
				return false;

			return true;
		}
	}

	[System.SerializableAttribute()]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProtocolHandshakeTypeType
	{
		announceMax,
		select,
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeTypeVersion
	{
		public MessageProtocolHandshakeTypeVersion()
		{
		}

		public MessageProtocolHandshakeTypeVersion( ushort major, ushort minor )
		{
			this.major = major;
			this.minor = minor;
		}

		public ushort major { get; set; }

		public ushort minor { get; set; }

		public bool IsEqual( MessageProtocolHandshakeTypeVersion other )
		{
			if ( this.major != other.major )
				return false;

			if ( this.minor != other.minor )
				return false;

			return true;
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeTypeFormats
	{
		public MessageProtocolHandshakeTypeFormats()
		{
		}

		public MessageProtocolHandshakeTypeFormats( string format )
		{
			this.format = new string[] { format };
		}

		public string[] format { get; set; }

		public bool IsEqual( MessageProtocolHandshakeTypeFormats other )
		{
			if ( this.format.Length != other.format.Length )
				return false;

			for ( int i = 0; i < this.format.Length; i++ )
				if ( this.format[i] != other.format[i] )
					return false;

			return true;
		}
	}
}
