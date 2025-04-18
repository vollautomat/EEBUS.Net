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
	public class DeviceDiagnosisServerFeature : Feature
	{
		static DeviceDiagnosisServerFeature()
		{
			Register( "DeviceDiagnosis-server", new Class() );
		}

		public DeviceDiagnosisServerFeature( int index, Entity owner )
			: base( index, "DeviceDiagnosis", "server", owner )
		{
			this.Functions.Add( new Function( "deviceDiagnosisHeartbeatData", true, false ) );
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new DeviceDiagnosisServerFeature( index, owner );
			}
		}

		public override string Description
		{
			get
			{
				return "DeviceDiagnosis Server";
			}
		}
	}
}
