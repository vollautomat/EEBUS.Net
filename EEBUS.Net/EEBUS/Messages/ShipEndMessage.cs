using EEBUS.Enums;

namespace EEBUS.Messages
{
	public class ShipEndMessage<T> : ShipMessage<T> where T : ShipEndMessage<T>, new()
	{
		public new abstract class Class : ShipMessage<T>.Class
		{
		}

		protected override byte GetDataType()
		{
			return SHIPMessageType.END;
		}
	}
}
