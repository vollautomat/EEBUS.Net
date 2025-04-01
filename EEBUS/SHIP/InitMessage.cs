using EEBUS.Enums;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace EEBUS.SHIP.Messages
{
	public class InitMessage : JsonInitMessage<InitMessage>
	{
		//static InitMessage()		// InitMessage is a special message. It's not JSON serialisable.

		public InitMessage()
		{
		}

		public override byte[] bytes { get; set; } = { SHIPMessageType.INIT, SHIPMessageValue.CMI_HEAD };
	}
}
