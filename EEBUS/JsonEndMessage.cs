using EEBUS.Enums;

namespace EEBUS
{
	public class JsonEndMessage<T> : JsonMessage<T> where T : JsonEndMessage<T>, new()
	{
		protected override byte GetDataType()
		{
			return SHIPMessageType.END;
		}
	}
}
