using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.Features
{
	public class MeasurementServerFeature : Feature
	{
		static MeasurementServerFeature()
		{
			Register( "Measurement-server", new Class() );
		}

		public MeasurementServerFeature( int index, Entity owner )
			: base( index, "Measurement", "server", owner )
		{
			this.Functions.Add( new Function( "measurementDescriptionListData",	true, false ) );
			this.Functions.Add( new Function( "measurementListData",			true, false ) );
		}

		public MeasurementServerFeature( int index, Entity owner, FeatureInformationType featureInfo )
			: base( index, "Measurement", "server", owner, featureInfo )
		{
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new MeasurementServerFeature( index, owner );
			}

			public override Feature Create( int index, Entity owner, FeatureInformationType featureInfo )
			{
				return new MeasurementServerFeature( index, owner, featureInfo  );
			}
		}

		public override string Description
		{
			get
			{
				return "Measurement Server";
			}
		}
	}
}
