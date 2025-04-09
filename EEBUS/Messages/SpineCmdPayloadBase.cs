using EEBUS.SHIP.Messages;
using Makaretu.Dns;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EEBUS.Messages
{
	public class SpineCmdPayloadBase
	{
		public SpineCmdPayloadBase()
		{
		}

		public abstract class Class
		{
			public virtual async Task<SpineCmdPayloadBase> CreateAnswer( DatagramType datagram, HeaderType header, Connection connection )
			{
				return null;
			}

			public virtual SpineCmdPayloadBase CreateNotify( DatagramType datagram )
			{
				return null;
			}

			public virtual bool? GetAnswerAckRequest()
			{
				return null;
			}
		}

		static protected Dictionary<string, Class> commands = new Dictionary<string, Class>();

		static protected void Register( string cmd, Class cls )
		{
			commands.Add( cmd, cls );
		}

		static public Class GetClass( string cmd )
		{
			if ( commands.TryGetValue( cmd, out Class cls ) )
				return cls;

			return null;
		}
	}
}
