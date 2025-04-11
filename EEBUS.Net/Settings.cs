using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEBUS
{
	public class Settings
	{
        public DeviceSettings Device      { get; set; }
    }

    public class DeviceSettings
    {
		public string Name                { get; set; }
		public string Id                  { get; set; }
		public string Model               { get; set; }
		public string Brand               { get; set; }
		public string Type                { get; set; }
		public string Serial              { get; set; }
		public string Host                { get; set; }
		public ushort Port                { get; set; }
        public string NetworkFeatureSet   { get; set; }

        public EntitySettings[] Entities  { get; set; } = [];
	}

    public class EntitySettings
    {
		public string Type                { get; set; }
	}
}
