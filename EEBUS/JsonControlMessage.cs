using EEBUS.Enums;

namespace EEBUS
{
	public class JsonControlMessage<T> : JsonMessage<T> where T : JsonControlMessage<T>, new()
	{
		protected override byte GetDataType()
		{
			return SHIPMessageType.CONTROL;
		}
	}
}
