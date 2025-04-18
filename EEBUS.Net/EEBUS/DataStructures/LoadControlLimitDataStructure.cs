using EEBUS.Models;
using EEBUS.SPINE.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EEBUS.DataStructures
{
	public class LoadControlLimitDataStructure : DataStructure
	{
		public LoadControlLimitDataStructure( uint limitId, string direction )
			: base( "LoadControlLimit" )
		{
			this.limitId		= limitId;
			this.limitType		= "signDependentAbsValueLimit";
			this.limitCategory	= "obligation";
			this.limitDirection	= direction;
			this.measurementId	= 0;
			this.scopeType		= "activePowerLimit";

			this.limitChangable	= true;
			this.limitActive	= false;
			this.endTime		= "PT2H";
			this.number			= 4200;
			this.scale			= 0;
		}

		private uint   limitId;
		private string limitType;
		private string limitCategory;
		private string limitDirection;
		private uint   measurementId;
		private string scopeType;

		private bool   limitChangable;
		private bool   limitActive;
		private string endTime;
		private long   number;
		private short  scale;

		public LoadControlLimitDescriptionDataType DescriptionData
		{
			get
			{
				LoadControlLimitDescriptionDataType descriptionData = new();

				descriptionData.limitId		   = this.limitId;
				descriptionData.limitType	   = this.limitType;
				descriptionData.limitCategory  = this.limitCategory;
				descriptionData.limitDirection = this.limitDirection;
				descriptionData.measurementId  = this.measurementId;
				descriptionData.scopeType	   = this.scopeType;

				return descriptionData;
			}
		}

		public LoadControlLimitDataType Data
		{
			get
			{
				LoadControlLimitDataType data = new();

				data.limitId			= this.limitId;
				data.isLimitChangeable	= this.limitChangable;
				data.isLimitActive		= this.limitActive;
				data.timePeriod.endTime	= this.endTime;
				data.value.number		= this.number;
				data.value.scale		= this.scale;

				return data;
			}
		}
	}
}
