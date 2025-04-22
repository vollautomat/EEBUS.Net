namespace EEBUS.Controllers
{
	public class LimitDataChanged : PushData
	{
		public LimitDataChanged( bool consume, bool active, long limit, TimeSpan duration )
			: base( "limitDataChanged" )
		{
			AddData( new
			{
				direction = consume ? "consume" : "produce",
				active	  = active,
				limit	  = limit,
				duration  = duration
			} );
		}
	}
}
