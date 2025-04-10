using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace EEBUS.Models
{
	public class RemoteDevice : Device
	{
		public RemoteDevice( string id, string ski, string url )
			: base( id, ski )
		{
			this.Url = url;
		}

		public string	Url { get; private set; }

		public DateTime	Age = DateTime.UtcNow;

		public void ReNewAge()
		{
			this.Age = DateTime.UtcNow;
		}

		public bool OlderThan( TimeSpan delay )
		{
			return this.Age < DateTime.UtcNow.Add( -delay );
		}
	}
}
