using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.Features
{
	public class ElectricalConnectionClientFeature : Feature
	{
		static ElectricalConnectionClientFeature()
		{
			Register( "ElectricalConnection-client", new Class() );
		}

		public ElectricalConnectionClientFeature( int index, Entity owner )
			: base( index, "ElectricalConnection", "client", owner )
		{
		}

		public ElectricalConnectionClientFeature( int index, Entity owner, FeatureInformationType featureInfo )
			: base( index, "ElectricalConnection", "client", owner, featureInfo )
		{
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new ElectricalConnectionClientFeature( index, owner );
			}

			public override Feature Create( int index, Entity owner, FeatureInformationType featureInfo )
			{
				return new ElectricalConnectionClientFeature( index, owner, featureInfo  );
			}
		}

		public override string Description
		{
			get
			{
				return "ElectricalConnection Client";
			}
		}
	}
}
