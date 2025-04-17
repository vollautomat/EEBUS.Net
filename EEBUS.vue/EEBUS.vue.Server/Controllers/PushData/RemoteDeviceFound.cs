using EEBUS.Models;

namespace EEBUS.Controllers
{
	public class RemoteDeviceFound : PushData
	{
		public RemoteDeviceFound( RemoteDevice device )
			: base( "remoteDeviceFound" )
		{
			AddData( new
			{
				id			= device.Id,
				name		= device.Name,
				ski			= device.SKI.ToString(),
				serverState	= device.serverState.ToString(),
				clientState	= device.serverState.ToString(),
			} );
		}
	}
}
