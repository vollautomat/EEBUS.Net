using EEBUS.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EEBUS.Messages
{
	public abstract class JsonMessageBase
	{
		public abstract class Class
		{
			public abstract JsonMessageBase Create( byte[] data );
		}

		static protected Dictionary<string, Class> messages = new Dictionary<string, Class>();

		public abstract JsonMessageBase FromJsonVirtual( byte[] data );

		static public JsonMessageBase Create( byte[] data )
		{
			Class cls = GetClass( data );
			return cls != null ? cls.Create( data ) : null;
		}

		public virtual (Server.State, Server.SubState, string) Test( Server.State state )
		{
			return (state, Server.SubState.None, null);
		}

		public virtual (Client.State, string) Test( Client.State state )
		{
			return (state, null);
		}

#pragma warning disable CS1998
		public virtual async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
#pragma warning restore CS1998
		{
			return (Server.State.ErrorOrTimeout, Server.SubState.None);
		}

		public virtual Client.State NextState( Client.State state )
		{
			return Client.State.ErrorOrTimeout;
		}

		public abstract Task Send( WebSocket ws );

		static protected string GetCommand( byte[] bytes )
		{
			if ( bytes[0] == SHIPMessageType.INIT )
				return "INIT";

			string str = Encoding.UTF8.GetString( bytes );
			int indx1 = str.IndexOf( "{" );
			int indx2 = str.IndexOf( ":" );

			return str.Substring( indx1 + 1, indx2 - indx1 ).Trim( '"' );
		}

		static public Class GetClass( byte[] bytes )
		{
			string cmd = GetCommand( bytes );
			if ( messages.TryGetValue( cmd, out Class cls ) )
				return cls;
			
			return null;
		}

		static protected string JsonFromEEBUSJson( string json )
		{
			json = json.Replace( "[{", "{" );
			json = json.Replace( "},{", "," );
			json = json.Replace( "}]", "}" );
			json = json.Replace( "[]", "{}" );

			return json;
		}
	}
}
