using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EEBUS.Models
{
	public class Devices
	{
		public Devices()
		{
		}

		public LocalDevice		  Local  { get; private set; }
		public List<RemoteDevice> Remote { get; set; } = [];

		private object mutex = new();

		public LocalDevice GetOrCreateLocal( byte[] ski, Settings settings )
		{
			lock ( this.mutex )
			{
				if ( null == Local )
					Local = new LocalDevice( ski, settings );
			
				return Local;
			}
		}

		public RemoteDevice GetOrCreateRemote( string id, string ski, string url )
		{
			if ( null != Local && Local.SKI == new SKI( ski ) )
				return null;

			lock ( this.mutex )
			{
				RemoteDevice remote = Remote.FirstOrDefault( r => r.Id == id );

				if ( null == remote )
				{
					remote = new RemoteDevice( id, ski, url );
					Remote.Add( remote );
				}

				return remote;
			}
		}

		public void GarbageCollect()
		{
			lock ( this.mutex )
			{
				foreach( RemoteDevice remote in Remote.ToArray() )
				{
					if ( remote.OlderThan( new TimeSpan( 1, 0, 0 ) ) )
						Remote.Remove( remote );
				}
			}
		}
	}

	public class Device
	{
		public Device( string id, byte[] ski )
		{
			this.Id  = id;
			this.SKI = new SKI( ski );
		}

		public Device( string id, string ski )
		{
			this.Id  = id;
			this.SKI = new SKI( ski );
		}

		public string	  Id	{ get; private set; }

		public string	  Name	{ get; set; }

		public SKI		  SKI	{ get; set; }

		public string	  Error	{ get; set; }

		public override bool Equals( object obj )
		{
			if ( (obj == null) || ! GetType().Equals( obj.GetType() ) )
				return false;

			Device org = (Device) obj;
			return this.SKI == org.SKI;
		}

		public override int GetHashCode()
		{
			return this.SKI.GetHashCode();
		}


		public List<Entity> Entities = new();
	}
}
