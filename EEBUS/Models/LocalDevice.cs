using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EEBUS.Models
{
	public class LocalDevice : Device
	{
		public LocalDevice( byte[] ski, Settings settings )
			: base( settings.Device.Id, ski )
		{			
			this.Name	= settings.Device.Name;
			this.Brand  = settings.Device.Brand;
			this.Type   = settings.Device.Type;
			this.Model  = settings.Device.Model;
			this.Serial = settings.Device.Serial;
		}

		public string Brand { get; private set; }

		public string Type { get; private set; }

		public string Model { get; private set; }

		public string Serial { get; private set; }
	}
}
