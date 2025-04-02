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
	public class ProtocolHandshakeMessage : JsonControlMessage<ProtocolHandshakeMessage>
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

		public new class Class : JsonControlMessage<ProtocolHandshakeMessage>.Class
		{
			public override ProtocolHandshakeMessage Create( byte[] data )
			{
				return template.FromJsonVirtual(data);
			}
		}

		public MessageProtocolHandshakeType messageProtocolHandshake { get; set; } = new MessageProtocolHandshakeType();

		public bool IsEqual( ProtocolHandshakeMessage other )
		{
			return this.messageProtocolHandshake.IsEqual( other.messageProtocolHandshake );
		}

		public override (Server.State, Server.SubState, string) Test( Server.State state )
		{
			string			error		= null;
			Server.State	newState	= state;
			Server.SubState	newSubState = Server.SubState.None;

			if ( state == Server.State.WaitingForProtocolHandshake && this.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.announceMax )
			{
				error = "Protocol version max announcement expected!";
				newState = Server.State.SendProtocolHandshakeError;
				newSubState = Server.SubState.UnexpectedMessage;
			}
			else if ( state == Server.State.WaitingForProtocolHandshakeConfirm && this.messageProtocolHandshake.handshakeType != ProtocolHandshakeTypeType.select )
			{
				error = "Protocol format mismatch!";
				newState = Server.State.SendProtocolHandshakeError;
				newSubState = Server.SubState.FormatMismatch;
			}
			else if ( this.messageProtocolHandshake.version.major != 1 && this.messageProtocolHandshake.version.minor != 0 )
			{
				error = "Protocol version mismatch!";
				newState = Server.State.SendProtocolHandshakeError;
				newSubState = Server.SubState.FormatMismatch;
			}
			else if ( (this.messageProtocolHandshake.formats.format.Length == 0) || (this.messageProtocolHandshake.formats.format[0] != SHIPMessageFormat.JSON_UTF8) )
			{
				error = "Protocol format mismatch!";
				newState = Server.State.SendProtocolHandshakeError;
				newSubState = Server.SubState.FormatMismatch;
			}

			return (newState, newSubState, error);
		}

		public override async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
		{
			if ( state == Server.State.WaitingForProtocolHandshake )
			{
				this.messageProtocolHandshake.handshakeType = ProtocolHandshakeTypeType.select;
				await Send( ws ).ConfigureAwait( false );
				return (Server.State.SendProtocolHandshakeConfirm, Server.SubState.None);
			}
			else if ( state == Server.State.SendProtocolHandshakeConfirm )
			{
				return (Server.State.WaitingForPinCheck, Server.SubState.None);
			}
			else if ( state == Server.State.SendProtocolHandshakeError && subState == Server.SubState.FormatMismatch )
			{
				ProtocolHandshakeErrorMessage message = new ProtocolHandshakeErrorMessage( SHIPHandshakeError.SELECTION_MISMATCH );
				await message.Send( ws ).ConfigureAwait( false );
				return await message.NextState( ws, state, subState ).ConfigureAwait( false );
			}
			else if ( state == Server.State.SendProtocolHandshakeError &&  subState == Server.SubState.UnexpectedMessage )
			{
				ProtocolHandshakeErrorMessage message = new ProtocolHandshakeErrorMessage( SHIPHandshakeError.UNEXPECTED_MESSAGE );
				await message.Send( ws ).ConfigureAwait( false );
				return await message.NextState( ws, state, subState ).ConfigureAwait( false );
			}

			throw new Exception( "ProtocolHandshake aborted!" );
		}
	}

	[System.SerializableAttribute()]
	public class MessageProtocolHandshakeType
	{
		public ProtocolHandshakeTypeType handshakeType { get; set; } = new ProtocolHandshakeTypeType();

		public MessageProtocolHandshakeTypeVersion version { get; set; } = new MessageProtocolHandshakeTypeVersion();

		public MessageProtocolHandshakeTypeFormats formats { get; set; } = new MessageProtocolHandshakeTypeFormats( SHIPMessageFormat.JSON_UTF8 );

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
