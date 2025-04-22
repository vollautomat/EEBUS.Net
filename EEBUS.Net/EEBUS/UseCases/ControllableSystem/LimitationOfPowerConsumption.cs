using System.Xml;
using EEBUS.DataStructures;
using EEBUS.KeyValues;
using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.UseCases.ControllableSystem
{
	public class LimitationOfPowerConsumption : UseCase
	{
		static LimitationOfPowerConsumption()
		{
			Register( "limitationOfPowerConsumption-ControllableSystem", new Class() );
		}

		public LimitationOfPowerConsumption( UseCaseSettings usecaseSettings, Entity entity )
			: base( usecaseSettings, entity )
		{
			Scenarios.Add( new Scenario( 1, true, "Control active power consumption limit" ) );
			Scenarios.Add( new Scenario( 2, true, "Failsafe values" ) );
			Scenarios.Add( new Scenario( 3, true, "Heartbeat" ) );
			Scenarios.Add( new Scenario( 4, true, "Constraints" ) );

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

			entity.Local.Add( new LoadControlLimitDataStructure( "consume", limit, 0, xmlDuration, active ) );

			entity.Local.AddUnique( new FailsafeConsumptionActivePowerLimitKeyValue( entity.Local, failsafeLimit, 0, true ) );
			entity.Local.AddUnique( new FailsafeDurationMinimumKeyValue(			 entity.Local, xmlFailsafeDuration, true ) );
		}

		public new class Class : UseCase.Class
		{
			public override UseCase Create( UseCaseSettings usecaseSettings, Entity entity )
			{
				return new LimitationOfPowerConsumption( usecaseSettings, entity );
			}
		}

		public override string Actor { get { return "ControllableSystem"; } }

		public override UseCaseSupportType Information
		{
			get
			{
				List<uint> scenarios = new();
				foreach ( var scenario in Scenarios )
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
