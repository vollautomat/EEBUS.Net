namespace EEBUS.Controllers
{
	public class FailsafeLimitDurationChanged : PushData
	{
		public FailsafeLimitDurationChanged( TimeSpan duration )
			: base( "failsafeLimitDurationChanged" )
		{
			AddData( new
			{
				duration = duration
			} );
		}
	}
}
