using EEBUS.Enums;

namespace EEBUS.Messages
{
	public class ShipControlMessage<T> : ShipMessage<T> where T : ShipControlMessage<T>, new()
	{
		public new abstract class Class : ShipMessage<T>.Class
		{
		}

		protected override byte GetDataType()
		{
			return SHIPMessageType.CONTROL;
		}
	}
}
