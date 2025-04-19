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
