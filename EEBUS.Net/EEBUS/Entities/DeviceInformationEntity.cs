using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.Entities
{
	public class DeviceInformationEntity : Entity
	{
		static DeviceInformationEntity()
		{
			Register( "DeviceInformation", new Class() );
		}

		public DeviceInformationEntity( int index, LocalDevice local, EntitySettings entitySettings )
			: base( index, local, entitySettings )
		{
			Features.Add( Feature.Create( 0, "NodeManagement",		 "special", this ) );
			Features.Add( Feature.Create( 1, "DeviceClassification", "server", this ) );
		}

		public DeviceInformationEntity( int index, LocalDevice local, EntityInformationType entityInfo, FeatureInformationType[] featureInfos )
			: base( index, local, entityInfo, featureInfos )
		{
		}

		public new class Class : Entity.Class
		{
			public override Entity Create( int index, LocalDevice local, EntitySettings entitySettings )
			{
				return new DeviceInformationEntity( index, local, entitySettings );
			}

			public override Entity Create( int index, LocalDevice local, EntityInformationType entityInfo, FeatureInformationType[] featureInfos )
			{
				return new DeviceInformationEntity( index, local, entityInfo, featureInfos );
			}
		}
	}
}
