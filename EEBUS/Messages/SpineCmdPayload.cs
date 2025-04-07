using EEBUS.SHIP.Messages;
using Makaretu.Dns;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace EEBUS.Messages
{
	public class SpineCmdPayload<T> : SpineCmdPayloadBase where T: CmdType, new()
	{
		public SpineCmdPayload()
		{
		}

		public T[] cmd { get; set; } = [new T()];
	}

	[System.SerializableAttribute()]
	public class CmdType
	{
	}
}
