using EEBUS.Enums;

namespace EEBUS.Messages
{
	public class JsonEndMessage<T> : JsonMessage<T> where T : JsonEndMessage<T>, new()
	{
		public new abstract class Class : JsonMessage<T>.Class
		{
		}

		protected override byte GetDataType()
		{
			return SHIPMessageType.END;
		}
	}
}
