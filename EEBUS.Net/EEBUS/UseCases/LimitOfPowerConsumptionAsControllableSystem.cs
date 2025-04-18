using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEBUS.DataStructures;
using EEBUS.KeyValues;
using EEBUS.Models;
using EEBUS.SPINE.Commands;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EEBUS.UseCases
{
	public class LimitOfPowerConsumptionAsControllableSystem : UseCase
	{
		static LimitOfPowerConsumptionAsControllableSystem()
		{
			Register( "limitationOfPowerConsumption-ControllableSystem", new Class() );
		}

		public LimitOfPowerConsumptionAsControllableSystem( UseCaseSettings usecaseSettings, Entity entity )
			: base( usecaseSettings, entity )
		{
			this.Scenarios.Add( new Scenario( 1, true, "Control active power consumption limit" ) );
			this.Scenarios.Add( new Scenario( 2, true, "Failsafe values" ) );
			this.Scenarios.Add( new Scenario( 3, true, "Heartbeat" ) );
			this.Scenarios.Add( new Scenario( 4, true, "Constraints" ) );

			entity.Local.Add( new LoadControlLimitDataStructure( 0, "consume" ) );

			entity.Local.AddUnique( new FailsafeConsumptionActivePowerLimitKeyValue( entity.Local, 3600, 0, true ) );
			entity.Local.AddUnique( new FailsafeDurationMinimumKeyValue(			 entity.Local, "PT2H", true) );
		}

		public new class Class : UseCase.Class
		{
			public override UseCase Create( UseCaseSettings usecaseSettings, Entity entity )
			{
				return new LimitOfPowerConsumptionAsControllableSystem( usecaseSettings, entity );
			}
		}

		public override string Actor { get { return "ControllableSystem"; } }

		public override UseCaseSupportType Information
		{
			get
			{
				List<uint> scenarios = new();
				foreach ( var scenario in this.Scenarios )
					scenarios.Add( scenario.Index );

				UseCaseSupportType support = new();
				support.useCaseName				   = "limitationOfPowerConsumption";
				support.useCaseVersion			   = "1.0.0";
				support.useCaseAvailable		   = true;
				support.scenarioSupport			   = scenarios.ToArray();
				support.useCaseDocumentSubRevision = "release";

				return support;
			}
		}
	}
}
