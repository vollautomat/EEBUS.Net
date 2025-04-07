using EEBUS.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EEBUS.Messages
{
	public abstract class ShipMessageBase
	{
		public abstract class Class
		{
			public abstract ShipMessageBase Create( byte[] data, Server server );
		}

		static protected Dictionary<string, Class> messages = new Dictionary<string, Class>();

		protected Server server;

		public abstract ShipMessageBase FromJsonVirtual( byte[] data, Server server );

		static public ShipMessageBase Create( byte[] data, Server server )
		{
			Class cls = GetClass( data );
			return cls != null ? cls.Create( data, server ) : null;
		}

		public virtual (Server.State, Server.SubState, string) Test( Server.State state )
		{
			return (state, Server.SubState.None, null);
		}

		public virtual (Client.State, Client.SubState, string) Test( Client.State state )
		{
			return (state, Client.SubState.None, null);
		}

#pragma warning disable CS1998
		public virtual async Task<(Server.State, Server.SubState)> NextState( WebSocket ws, Server.State state, Server.SubState subState )
#pragma warning restore CS1998
		{
			return (Server.State.ErrorOrTimeout, Server.SubState.None);
		}

#pragma warning disable CS1998
		public virtual async Task<(Client.State, Client.SubState)> NextState( WebSocket ws, Client.State state, Client.SubState subState )
#pragma warning restore CS1998
		{
			return (Client.State.ErrorOrTimeout, Client.SubState.None);
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
			return GetClass( cmd );
		}

		static public Class GetClass( string cmd )
		{
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

		// convert json into the EEBUS json format
		static protected JObject JsonIntoEEBUSJson( JObject jobj )
		{
			foreach ( JProperty prop in jobj.Properties() )
			{
				JToken  val = prop.Value;
				JObject jo  = val as JObject;
				JArray  ja  = val as JArray;

				if ( null != jo )
				{
					if ( jo.Properties().Any() )
					{
						JArray replacement = ConvertToArray( jo );

						if ( 0 < replacement.Count )
							jo.Replace( replacement );
					}
				}
				else if ( null != ja )
				{
					for ( int i = 0; i < ja.Count; i++ )
					{
						jo = ja[i] as JObject;
						if ( null != jo )
						{
							if ( jo.Properties().Any() )
							{
								JArray replacement = ConvertToArray( jo );

								if  ( 0 < replacement.Count )
									jo.Replace( replacement );
							}
						}
					}
				}
			}

			return jobj;
		}

		static JArray ConvertToArray( JObject jo )
		{
			JArray replacement = new JArray();

			foreach (JProperty p in jo.Properties())
			{
				if (p.Name == "datagram" && 1 == jo.Properties().Count() && p.Value is JObject)
				{
					JObject jp = JsonIntoEEBUSJson(p.Value as JObject);

					JArray ja = new JArray();
					foreach (JProperty pp in jp.Properties())
					{
						JObject jpp = new JObject();
						jpp.Add(pp.Name, pp.Value);
						ja.Add(jpp);
					}

					p.Value.Replace(ja);
				}
				else
				{
					JObject jp = new JObject();
					jp.Add(p.Name, p.Value);
					jp = JsonIntoEEBUSJson(jp);
					replacement.Add(jp);
				}
			}

			return replacement;
		}
	}
}
