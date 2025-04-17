using EEBUS.Models;

namespace EEBUS.Controllers
{
	public class ClientStateChanged : PushData
	{
		public ClientStateChanged( RemoteDevice device, Connection.EState state )
			: base( "clientStateChanged" )
		{
			AddData( new
			{
				id	  = device.Id,
				state = state.ToString()
			} );
		}
	}
}
