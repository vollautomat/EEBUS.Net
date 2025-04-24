using System.Xml;
using EEBUS.DataStructures;
using EEBUS.KeyValues;
using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.UseCases.GridConnectionPoint
{
	public class MonitoringOfGridConnectionPoint : UseCase
	{
		static MonitoringOfGridConnectionPoint()
		{
			Register( "monitoringOfGridConnectionPoint-GridConnectionPoint", new Class() );
		}

		public MonitoringOfGridConnectionPoint( UseCaseSettings usecaseSettings, Entity entity )
			: base( usecaseSettings, entity )
		{
			Scenarios.Add( new Scenario( 1, true, "Monitor PV feed-in power limitation factor" ) );
			Scenarios.Add( new Scenario( 2, true, "Monitor momentary power consumption/production" ) );
			Scenarios.Add( new Scenario( 3, true, "Monitor total feed-in energy" ) );
			Scenarios.Add( new Scenario( 4, true, "Monitor total consumed energy" ) );
			Scenarios.Add( new Scenario( 5, true, "Monitor momentary current consumption/production phase details" ) );
			Scenarios.Add( new Scenario( 6, true, "Monitor voltage phase details" ) );
			Scenarios.Add( new Scenario( 7, true, "Monitor frequency" ) );

			//bool active			  = false;
			//long limit			  = 0;
			//uint duration		  = 0;
			//long failsafeLimit	  = 4200;
			//uint failsafeDuration = 7200;

			//if ( null != usecaseSettings.InitLimits )
			//{
			//	active			 = usecaseSettings.InitLimits.Active;
			//	limit			 = usecaseSettings.InitLimits.Limit;
			//	duration		 = usecaseSettings.InitLimits.Duration;
			//	failsafeLimit	 = usecaseSettings.InitLimits.FailsafeLimit;
			//	failsafeDuration = usecaseSettings.InitLimits.FailsafeDuration;
			//}

			//string xmlDuration		   = XmlConvert.ToString( TimeSpan.FromSeconds( duration ) );
			//string xmlFailsafeDuration = XmlConvert.ToString( TimeSpan.FromSeconds( failsafeDuration ) );

			//entity.Local.Add( new LoadControlLimitDataStructure( "consume", limit, 0, xmlDuration, active ) );

			//entity.Local.AddUnique( new FailsafeConsumptionActivePowerLimitKeyValue( entity.Local, failsafeLimit, 0, true ) );
			//entity.Local.AddUnique( new FailsafeDurationMinimumKeyValue(			 entity.Local, xmlFailsafeDuration, true ) );
		}

		public new class Class : UseCase.Class
		{
			public override UseCase Create( UseCaseSettings usecaseSettings, Entity entity )
			{
				return new MonitoringOfGridConnectionPoint( usecaseSettings, entity );
			}
		}

		public override string Actor { get { return "GridConnectionPoint"; } }

		public override UseCaseSupportType Information
		{
			get
			{
				List<uint> scenarios = new();
				foreach ( var scenario in Scenarios )
					scenarios.Add( scenario.Index );

				UseCaseSupportType support = new();
				support.useCaseName				   = "monitoringOfGridConnectionPoint";
				support.useCaseVersion			   = "1.0.0";
				support.useCaseAvailable		   = true;
				support.scenarioSupport			   = scenarios.ToArray();
				support.useCaseDocumentSubRevision = "release";

				return support;
			}
		}
	}
}
