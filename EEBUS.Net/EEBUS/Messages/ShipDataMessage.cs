using EEBUS.Enums;

namespace EEBUS.Messages
{
	public class ShipDataMessage<T> : ShipMessage<T> where T : ShipDataMessage<T>, new()
	{
		public new abstract class Class : ShipMessage<T>.Class
		{
		}

		protected override byte GetDataType()
		{
			return SHIPMessageType.DATA;
		}
	}
}
