using System;

namespace EEBUS.Controllers
{
	public class FailsafeLimitDataChanged : PushData
	{
		public FailsafeLimitDataChanged( bool consume, long limit )
			: base( "failsafeLimitDataChanged" )
		{
			AddData( new
			{
				direction  = consume ? "consume" : "produce",
				limit	   = limit,
			} );
		}
	}
}
