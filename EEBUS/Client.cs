using System.Net.WebSockets;
using System.Threading.Tasks;

namespace EEBUS
{
	public class Client
	{
		public Client( string host, WebSocket ws )
		{
			this.host = host;
			this.ws	  = ws;
		}

		private string	  host;
		private WebSocket ws;
		private State	  state;

		public enum State
		{
			WaitingForInit,
			WaitingForConnectionHello,
			WaitingForProtocolHandshake,
			WaitingForPinCheck,
			WaitingForAccessMethodsRequest,
			WaitingForAccessMethods,
			WaitingForCLoseInitOrData,
			Connected,
			ErrorOrTimeout
		}

		public async Task<bool> Connect()
		{

			return true;
		}
	}
}
