using EEBUS.Enums;

namespace EEBUS
{
	public class JsonInitMessage<T> : JsonMessage<T> where T : JsonInitMessage<T>, new()
	{
		protected override byte GetDataType()
		{
			return SHIPMessageType.INIT;
		}
	}
}
