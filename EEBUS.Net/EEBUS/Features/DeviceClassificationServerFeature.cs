﻿using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.Features
{
	public class DeviceClassificationServerFeature : Feature
	{
		static DeviceClassificationServerFeature()
		{
			Register( "DeviceClassification-server", new Class() );
		}

		public DeviceClassificationServerFeature( int index, Entity owner )
			: base( index, "DeviceClassification", "server", owner )
		{
			this.Functions.Add( new Function( "deviceClassificationManufacturerData", true, false ) );
		}

		public DeviceClassificationServerFeature( int index, Entity owner, FeatureInformationType featureInfo )
			: base( index, "DeviceClassification", "server", owner, featureInfo )
		{
		}


		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new DeviceClassificationServerFeature( index, owner );
			}

			public override Feature Create( int index, Entity owner, FeatureInformationType featureInfo )
			{
				return new DeviceClassificationServerFeature( index, owner, featureInfo  );
			}
		}
	}
}
