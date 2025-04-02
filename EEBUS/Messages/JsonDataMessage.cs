using EEBUS.Enums;

namespace EEBUS.Messages
{
	public class JsonDataMessage<T> : JsonMessage<T> where T : JsonDataMessage<T>, new()
	{
		public new abstract class Class : JsonMessage<T>.Class
		{
		}

		protected override byte GetDataType()
		{
			return SHIPMessageType.DATA;
		}
	}
}
