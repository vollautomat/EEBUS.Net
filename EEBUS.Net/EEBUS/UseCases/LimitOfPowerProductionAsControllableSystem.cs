using System.Xml;

using EEBUS.DataStructures;
using EEBUS.KeyValues;
using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.UseCases
{
	public class LimitOfPowerProductionAsControllableSystem : UseCase
	{
		static LimitOfPowerProductionAsControllableSystem()
		{
			Register( "limitationOfPowerProduction-ControllableSystem", new Class() );
		}

		public LimitOfPowerProductionAsControllableSystem( UseCaseSettings usecaseSettings, Entity entity )
			: base( usecaseSettings, entity )
		{
			this.Scenarios.Add( new Scenario( 1, true, "Control active power production limit" ) );
			this.Scenarios.Add( new Scenario( 2, true, "Failsafe values" ) );
			this.Scenarios.Add( new Scenario( 3, true, "Heartbeat" ) );
			this.Scenarios.Add( new Scenario( 4, true, "Constraints" ) );

			bool active			  = false;
			long limit			  = 0;
			uint duration		  = 0;
			long failsafeLimit	  = 4200;
			uint failsafeDuration = 7200;

			if ( null != usecaseSettings.InitLimits )
			{
				active			 = usecaseSettings.InitLimits.Active;
				limit			 = usecaseSettings.InitLimits.Limit;
				duration		 = usecaseSettings.InitLimits.Duration;
				failsafeLimit	 = usecaseSettings.InitLimits.FailsafeLimit;
				failsafeDuration = usecaseSettings.InitLimits.FailsafeDuration;
			}

			string xmlDuration		   = XmlConvert.ToString( TimeSpan.FromSeconds( duration ) );
			string xmlFailsafeDuration = XmlConvert.ToString( TimeSpan.FromSeconds( failsafeDuration ) );
			
			entity.Local.Add( new LoadControlLimitDataStructure( "produce", limit, 0, xmlDuration, active ) );

			entity.Local.AddUnique( new FailsafeProductionActivePowerLimitKeyValue(	entity.Local, failsafeLimit, 0, true ) );
			entity.Local.AddUnique( new FailsafeDurationMinimumKeyValue(			entity.Local, xmlFailsafeDuration, true ) );
		}

		public new class Class : UseCase.Class
		{
			public override UseCase Create( UseCaseSettings usecaseSettings, Entity entity )
			{
				return new LimitOfPowerProductionAsControllableSystem( usecaseSettings, entity );
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
				support.useCaseName				   = "limitationOfPowerProduction";
				support.useCaseVersion			   = "1.0.0";
				support.useCaseAvailable		   = true;
				support.scenarioSupport			   = scenarios.ToArray();
				support.useCaseDocumentSubRevision = "release";

				return support;
			}
		}
	}
}
