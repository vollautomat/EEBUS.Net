using EEBUS.SPINE.Commands;

namespace EEBUS.Models
{
	public abstract class KeyValue
	{
		protected KeyValue( Device device )
		{
			this.device = device;
		}

		protected Device	   device;

		public abstract string KeyName { get; }
		public abstract string Type	   { get; }

		public abstract DeviceConfigurationKeyValueDescriptionDataType DescriptionData { get; }

		public abstract DeviceConfigurationKeyValueDataType			   Data { get; }
	}
}
