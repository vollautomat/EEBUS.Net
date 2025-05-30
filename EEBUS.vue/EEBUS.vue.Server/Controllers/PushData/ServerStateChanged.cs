﻿using EEBUS.Models;

namespace EEBUS.Controllers
{
	public class ServerStateChanged : PushData
	{
		public ServerStateChanged( RemoteDevice device, Connection.EState state )
			: base( "serverStateChanged" )
		{
			AddData( new
			{
				id	  = device.Id,
				ski	  = device.SKI,
				state = state.ToString()
			} );
		}
	}
}
