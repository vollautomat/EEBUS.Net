
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EEBUS
{
	public class SHIPMiddleware
    {
        private readonly RequestDelegate next;

        public SHIPMiddleware( RequestDelegate next )
        {
            this.next = next;
        }

        public async Task Invoke( HttpContext httpContext )
        {
            try
            {
                if ( ! httpContext.WebSockets.IsWebSocketRequest )
                {
                    // passed on to next middleware
                    await this.next( httpContext ).ConfigureAwait( false );
                }

                if ( ! ProtocolSupported( httpContext ) )
                {
                    // passed on to next middleware
                    await this.next( httpContext ).ConfigureAwait( false );
                }

                Server server = Server.Get( httpContext.Request.Host.Host );
                if ( server != null )
                    await server.Close().ConfigureAwait( false );

                var socket = await httpContext.WebSockets.AcceptWebSocketAsync( "ship" ).ConfigureAwait( false );
                if ( socket == null || socket.State != WebSocketState.Open )
                {
                    Console.WriteLine( "Failed to accept socket from " + httpContext.Request.Host.Host );
                    return;
                }

                server = new Server( httpContext.Request.Host.Host, socket );
                await server.Do().ConfigureAwait(false);
            }
            catch ( Exception ex )
            {
                Console.WriteLine( "Exception: " + ex.Message );

                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsync( "Error while processing websocket: " + ex.Message ).ConfigureAwait( false );
            }
        }

        private bool ProtocolSupported( HttpContext httpContext )
        {
            IList<string> requestedProtocols = httpContext.WebSockets.WebSocketRequestedProtocols;
            return (0 < requestedProtocols.Count) && requestedProtocols.Contains("ship");
        }
    }
}
