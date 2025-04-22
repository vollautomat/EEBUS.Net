using EEBUS.Models;

namespace EEBUS.Controllers
{
	public class HeartbeatReceived : PushData
	{
		public HeartbeatReceived( RemoteDevice device, uint timeout )
			: base( "heartbeatReceived" )
		{
			AddData( new
			{
				id		= device.Id,
				timeout = timeout
			} );
		}
	}
}
