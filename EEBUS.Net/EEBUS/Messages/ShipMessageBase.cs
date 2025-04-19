using System.Net.WebSockets;
using System.Text;

using Newtonsoft.Json.Linq;

using EEBUS.Enums;

namespace EEBUS.Messages
{
	public abstract class ShipMessageBase
	{
		public abstract class Class
		{
			public abstract ShipMessageBase Create( byte[] data, Connection connection );
		}

		static protected Dictionary<string, Class> messages = new Dictionary<string, Class>();

		protected Connection connection;

		public virtual string GetDeviceId()
		{
			return null;
		}

		public abstract ShipMessageBase FromJsonVirtual( byte[] data, Connection connection );

		static public ShipMessageBase Create( byte[] data, Connection connection )
		{
			Class cls = GetClass( data );
			return cls != null ? cls.Create( data, connection ) : null;
		}

		public virtual (Connection.EState, Connection.ESubState, string) ServerTest( Connection.EState state )
		{
			return (state, Connection.ESubState.None, null);
		}

		public virtual (Connection.EState, Connection.ESubState, string) ClientTest( Connection.EState state )
		{
			return (state, Connection.ESubState.None, null);
		}

		public virtual async Task<(Connection.EState, Connection.ESubState)> NextServerState( Connection connection )
		{
			return (Connection.EState.ErrorOrTimeout, Connection.ESubState.None);
		}

		public virtual async Task<(Connection.EState, Connection.ESubState)> NextClientState( Connection connection )
		{
			return await NextServerState( connection );
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
