using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.KeyValues
{
	public class FailsafeProductionActivePowerLimitKeyValue : KeyValue
	{
		public FailsafeProductionActivePowerLimitKeyValue( Device device, long value, short scale, bool changable )
			: base( device )
		{
			this.value	   = value;
			this.scale	   = scale;
			this.changable = changable;
		}

		public override string KeyName { get { return "failsafeProductionActivePowerLimit"; } }
		public override string Type	   { get { return "scaledNumber"; } }
		public string		   Unit	   { get { return "W"; } }

		private long		   value;
		private short		   scale;
		private bool		   changable;

		public override DeviceConfigurationKeyValueDescriptionDataType DescriptionData
		{
			get
			{
				DeviceConfigurationKeyValueDescriptionDataType descriptionData = new();

				descriptionData.keyId	  = this.device.GetId( this );
				descriptionData.keyName   = this.KeyName;
				descriptionData.valueType = this.Type;
				descriptionData.unit	  = this.Unit;

				return descriptionData;
			}
		}

		public override DeviceConfigurationKeyValueDataType Data
		{
			get
			{
				DeviceConfigurationKeyValueDataType data = new();

				data.keyId					   = this.device.GetId( this );
				data.value.scaledNumber		   = new();
				data.value.scaledNumber.number = this.value;
				data.value.scaledNumber.scale  = this.scale;
				data.isValueChangeable		   = this.changable;

				return data;
			}
		}
	}
}
