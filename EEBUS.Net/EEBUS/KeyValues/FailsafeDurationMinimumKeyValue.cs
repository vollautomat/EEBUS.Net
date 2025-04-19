using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.KeyValues
{
	public class FailsafeDurationMinimumKeyValue : KeyValue
	{
		public FailsafeDurationMinimumKeyValue( Device device, string duration, bool changable )
			: base( device )
		{
			this.duration  = duration;
			this.changable = changable;
		}

		public override string KeyName { get { return "failsafeDurationMinimum"; } }
		public override string Type	   { get { return "duration"; } }

		private string		   duration;
		private bool		   changable;
		public override DeviceConfigurationKeyValueDescriptionDataType DescriptionData
		{
			get
			{
				DeviceConfigurationKeyValueDescriptionDataType data = new();

				data.keyId	   = this.device.GetId( this );
				data.keyName   = this.KeyName;
				data.valueType = this.Type;

				return data;
			}
		}

		public override DeviceConfigurationKeyValueDataType Data
		{
			get
			{
				DeviceConfigurationKeyValueDataType data = new();

				data.keyId			   = this.device.GetId( this );
				data.value.duration	   = this.duration;
				data.isValueChangeable = this.changable;

				return data;
			}
		}
	}
}
