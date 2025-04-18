using EEBUS.Entities;
using EEBUS.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEBUS.Features
{
	public class ElectricalConnectionServerFeature : Feature
	{
		static ElectricalConnectionServerFeature()
		{
			Register( "ElectricalConnection-server", new Class() );
		}

		public ElectricalConnectionServerFeature( int index, Entity owner )
			: base( index, "ElectricalConnection", "server", owner )
		{
			this.Functions.Add( new Function( "electricalConnectionCharacteristicListData", true, false ) );
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new ElectricalConnectionServerFeature( index, owner );
			}
		}

		public override string Description
		{
			get
			{
				return "ElectricalConnection Server";
			}
		}
	}
}
