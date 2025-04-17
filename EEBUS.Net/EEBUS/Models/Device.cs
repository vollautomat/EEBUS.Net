using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EEBUS.Models
{
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
