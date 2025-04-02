using EEBUS.Enums;

namespace EEBUS.Messages
{
	public class JsonControlMessage<T> : JsonMessage<T> where T : JsonControlMessage<T>, new()
	{
		public new abstract class Class : JsonMessage<T>.Class
		{
		}

		protected override byte GetDataType()
		{
			return SHIPMessageType.CONTROL;
		}
	}
}
