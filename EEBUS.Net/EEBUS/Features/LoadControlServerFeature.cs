using EEBUS.Models;

namespace EEBUS.Features
{
	public class LoadControlServerFeature : Feature
	{
		static LoadControlServerFeature()
		{
			Register( "LoadControl-server", new Class() );
		}

		public LoadControlServerFeature( int index, Entity owner )
			: base( index, "LoadControl", "server", owner )
		{
			this.Functions.Add( new Function( "loadControlLimitDescriptionListData", true, false ) );
			this.Functions.Add( new Function( "loadControlLimitListData",			 true, true ) );
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new LoadControlServerFeature( index, owner );
			}
		}

		public override string Description
		{
			get
			{
				return "LoadControl Server";
			}
		}
	}
}
