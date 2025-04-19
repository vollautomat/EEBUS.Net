using EEBUS.Models;

namespace EEBUS.Features
{
	public class NodeManagementSpecialFeature : Feature
	{
		static NodeManagementSpecialFeature()
		{
			Register( "NodeManagement-special", new Class() );
		}

		public NodeManagementSpecialFeature( int index, Entity owner )
			: base( index, "NodeManagement", "special", owner )
		{
			this.Functions.Add( new Function( "nodeManagementBindingData",			   true,  false ) );
			this.Functions.Add( new Function( "nodeManagementDetailedDiscoveryData",   true,  false ) );
			this.Functions.Add( new Function( "nodeManagementUseCaseData",			   true,  false ) );
			this.Functions.Add( new Function( "nodeManagementSubscriptionDeleteCall",  false, false ) );
			this.Functions.Add( new Function( "nodeManagementBindingDeleteCall",	   false, false ) );
			this.Functions.Add( new Function( "nodeManagementDestinationListData",	   true,  false ) );
			this.Functions.Add( new Function( "nodeManagementSubscriptionData",		   true,  false ) );
			this.Functions.Add( new Function( "nodeManagementSubscriptionRequestCall", false, false ) );
			this.Functions.Add( new Function( "nodeManagementBindingRequestCall",	   false, false ) );
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new NodeManagementSpecialFeature( index, owner );
			}
		}
	}
}
