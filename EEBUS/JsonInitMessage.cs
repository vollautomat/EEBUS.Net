using EEBUS.Enums;
using Newtonsoft.Json;
using System.Text;

namespace EEBUS
{
	public abstract class JsonInitMessage<T> : JsonMessage<T> where T : JsonInitMessage<T>, new()
	{
		protected override byte GetDataType()
		{
			return SHIPMessageType.INIT;
		}

		public abstract byte[] bytes { get;  set; }

		protected override byte[] ToJson()
		{
			return new byte[] { SHIPMessageValue.CMI_HEAD };
		}

		protected override T FromJsonVirtual(byte[] data)
		{
			return FromJson(data);
		}

		static new public T FromJson(byte[] data)
		{
			T init = new T();

			if (data == null || data.Length == 0)
				return null;
			else if (data.Length == 1)
				init.bytes[1] = data[0];
			else
			{
				init.bytes[0] = data[0];
				init.bytes[1] = data[1];
			}

			return init;
		}
	}
}
