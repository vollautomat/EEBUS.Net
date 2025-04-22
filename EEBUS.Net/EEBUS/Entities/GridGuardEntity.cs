using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.Entities
{
	public class GridGuardEntity : Entity
	{
		static GridGuardEntity()
		{
			Register( "GridGuard", new Class() );
		}

		public GridGuardEntity( int index, LocalDevice local, EntitySettings entitySettings )
			: base( index, local, entitySettings )
		{
			Features.Add( Feature.Create( 1, "DeviceDiagnosis",		 "client", this ) );
			Features.Add( Feature.Create( 2, "LoadControl",			 "client", this ) );
			Features.Add( Feature.Create( 3, "DeviceConfiguration",  "client", this ) );
			Features.Add( Feature.Create( 4, "ElectricalConnection", "client", this ) );
			Features.Add( Feature.Create( 5, "DeviceDiagnosis",		 "server", this ) );
		}

		public GridGuardEntity( int index, LocalDevice local, EntityInformationType entityInfo, FeatureInformationType[] featureInfos )
			: base( index, local, entityInfo, featureInfos )
		{
		}


		public new class Class : Entity.Class
		{
			public override Entity Create( int index, LocalDevice local, EntitySettings entitySettings )
			{
				return new GridGuardEntity( index, local, entitySettings );
			}

			public override Entity Create( int index, LocalDevice local, EntityInformationType entityInfo, FeatureInformationType[] featureInfos )
			{
				return new GridGuardEntity( index, local, entityInfo, featureInfos );
			}
		}
	}
}
