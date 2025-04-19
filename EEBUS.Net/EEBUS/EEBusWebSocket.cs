using System.Net.WebSockets;

namespace EEBUS.EEBUS
{
	public class EEBusWebSocket
	{
		public EEBusWebSocket( WebSocket ws )
		{
			this.ws = ws;
		}

		private WebSocket ws;

		public async Task<byte[]> Receive( int timeout )
		{
			int			 chunksReceived	  = 0;
			int			 framePayloadSize = 0;
			Memory<byte> framePayload	  = null;
			Memory<byte> buffer			  = new Memory<byte>( new byte[1024] );
			
			CancellationTokenSource     cts = new CancellationTokenSource( timeout );
			ValueWebSocketReceiveResult result;

			do
			{
				result = await this.ws.ReceiveAsync( buffer, cts.Token ).ConfigureAwait( false );

				if ( chunksReceived == 0 )
					framePayload = new Memory<byte>( new byte[result.Count] ); //initialize with proper size

				Memory<byte> data = buffer.Slice( 0, result.Count );
				data.CopyTo( framePayload.Slice( framePayloadSize, result.Count ) );

				framePayloadSize += result.Count;
				chunksReceived++;
			} while ( ! result.EndOfMessage );

			return framePayload.ToArray();
		}
	}
}
