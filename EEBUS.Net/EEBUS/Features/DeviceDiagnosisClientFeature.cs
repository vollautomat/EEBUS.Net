﻿using EEBUS.Entities;
using EEBUS.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEBUS.Features
{
	public class DeviceDiagnosisClientFeature : Feature
	{
		static DeviceDiagnosisClientFeature()
		{
			Register( "DeviceDiagnosis-client", new Class() );
		}

		public DeviceDiagnosisClientFeature( int index, Entity owner )
			: base( index, "DeviceDiagnosis", "client", owner )
		{
		}

		public new class Class : Feature.Class
		{
			public override Feature Create( int index, Entity owner )
			{
				return new DeviceDiagnosisClientFeature( index, owner );
			}
		}

		public override string Description
		{
			get
			{
				return "DeviceDiagnosis Client";
			}
		}
	}
}
