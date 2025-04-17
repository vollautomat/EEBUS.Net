using Newtonsoft.Json.Linq;

namespace EEBUS.Controllers

{
	public class PushData : JObject
	{
		public PushData( string cmd )
		{
			Add( "cmd", cmd );
		}

		protected void AddData( object data )
		{
			Add( "data", JObject.FromObject( data ) );
		}
	}
}
