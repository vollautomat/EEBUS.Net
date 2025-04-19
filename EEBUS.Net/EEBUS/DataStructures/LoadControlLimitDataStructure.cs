using EEBUS.Models;
using EEBUS.SPINE.Commands;

namespace EEBUS.DataStructures
{
	public class LoadControlLimitDataStructure : DataStructure
	{
		public LoadControlLimitDataStructure( string direction, long value, short scale, string duration, bool active )
			: base( "LoadControlLimit" )
		{
			this.limitId		= 0;
			this.limitType		= "signDependentAbsValueLimit";
			this.limitCategory	= "obligation";
			this.limitDirection	= direction;
			this.measurementId	= 0;
			this.scopeType		= "activePowerLimit";

			this.LimitChangable	= true;
			this.LimitActive	= active;
			this.EndTime		= duration;
			this.Number			= value;
			this.Scale			= scale;
		}

		private uint   limitId;
		private string limitType;
		private string limitCategory;
		private string limitDirection;
		private uint   measurementId;
		private string scopeType;

		public bool	   LimitChangable { get; set; }
		public bool	   LimitActive	  { get; set; }
		public string  EndTime		  { get; set; }
		public long	   Number		  { get; set; }
		public short   Scale		  { get; set; }

		public override uint Id
		{
			get
			{
				return this.limitId;
			}
			set
			{
				this.limitId = value;
			}
		}

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
				data.isLimitChangeable	= this.LimitChangable;
				data.isLimitActive		= this.LimitActive;
				data.timePeriod.endTime	= this.EndTime;
				data.value.number		= this.Number;
				data.value.scale		= this.Scale;

				return data;
			}
		}
	}
}
