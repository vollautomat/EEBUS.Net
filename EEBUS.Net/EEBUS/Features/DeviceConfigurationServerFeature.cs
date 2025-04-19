using EEBUS.Models;

namespace EEBUS.Features
{
	public class DeviceConfigurationServerFeature : Feature
	{
		static DeviceConfigurationServerFeature()
		{
			Register( "DeviceConfiguration-server", new Class() );
		}

		public DeviceConfigurationServerFeature( int index, Entity owner )
			: base( index, "DeviceConfiguration", "server", owner )
		{
			this.Functions.Add( new Function( "deviceConfigurationKeyValueDescriptionListData",	true, false ) );
			this.Functions.Add( new Function( "deviceConfigurationKeyValueListData",			true, true ) );
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new DeviceConfigurationServerFeature( index, owner );
			}
		}

		public override string Description
		{
			get
			{
				return "DeviceConfiguration Server";
			}
		}
	}
}
