using EEBUS.Models;
using EEBUS.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEBUS.Entities
{
	public class CEMEntity : Entity
	{
		static CEMEntity()
		{
			Register( "CEM", new Class() );
		}

		public CEMEntity( int index, LocalDevice local, EntitySettings entitySettings )
			: base( index, local, entitySettings )
		{
			Features.Add( Feature.Create( 1, "DeviceDiagnosis",		 "client", this ) );
			Features.Add( Feature.Create( 2, "LoadControl",			 "server", this ) );
			Features.Add( Feature.Create( 3, "DeviceConfiguration",  "server", this ) );
			Features.Add( Feature.Create( 4, "DeviceDiagnosis",		 "server", this ) );
			Features.Add( Feature.Create( 5, "ElectricalConnection", "server", this ) );
		}

		public new class Class : Entity.Class
		{
			public override Entity Create( int index, LocalDevice local, EntitySettings entitySettings )
			{
				return new CEMEntity( index, local, entitySettings );
			}
		}
	}
}
