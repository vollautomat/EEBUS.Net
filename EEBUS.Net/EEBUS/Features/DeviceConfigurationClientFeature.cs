using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.Features
{
	public class DeviceConfigurationClientFeature : Feature
	{
		static DeviceConfigurationClientFeature()
		{
			Register( "DeviceConfiguration-client", new Class() );
		}

		public DeviceConfigurationClientFeature( int index, Entity owner )
			: base( index, "DeviceConfiguration", "client", owner )
		{
		}

		public DeviceConfigurationClientFeature( int index, Entity owner, FeatureInformationType featureInfo )
			: base( index, "DeviceClassification", "client", owner, featureInfo )
		{
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new DeviceConfigurationClientFeature( index, owner );
			}

			public override Feature Create( int index, Entity owner, FeatureInformationType featureInfo )
			{
				return new DeviceConfigurationClientFeature( index, owner, featureInfo  );
			}
		}

		public override string Description
		{
			get
			{
				return "DeviceConfiguration Client";
			}
		}
	}
}
