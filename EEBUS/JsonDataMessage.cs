using EEBUS.Enums;

namespace EEBUS
{
	public class JsonDataMessage<T> : JsonMessage<T> where T : JsonDataMessage<T>, new()
	{
		protected override byte GetDataType()
		{
			return SHIPMessageType.DATA;
		}
	}
}
