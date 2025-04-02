using EEBUS.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EEBUS.Messages
{
	public abstract class JsonMessage<T> : JsonMessageBase where T: JsonMessage<T>, new()
	{
		public new abstract class Class : JsonMessageBase.Class
		{
		}

		static public JsonMessage<T> template = new T();

		private byte[] sentData;

		protected abstract byte GetDataType();

		static protected void Register( Class cls )
		{
			byte[] test = template.ToJson();
			string cmd = GetCommand( test );

			messages.Add( cmd, cls );
		}

		protected virtual byte[] ToJson()
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add( new Newtonsoft.Json.Converters.StringEnumConverter() );

			return Encoding.UTF8.GetBytes( JsonConvert.SerializeObject( this, jsonSerializerSettings ) );
		}

		public override T FromJsonVirtual( byte[] data )
		{
			return FromJson( data );
		}

		static public T FromJson( byte[] data )
		{
			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Include,
				MissingMemberHandling = MissingMemberHandling.Error
			};

			if ( data == null || data.Length < 2 )
				return null;

			string dataStr = Encoding.UTF8.GetString( data );
			dataStr = JsonFromEEBUSJson( data[0] == template.GetDataType() ? dataStr.Substring( 1 ) : dataStr );

			return JsonConvert.DeserializeObject<T>( dataStr, settings );
		}

		public override async Task Send( WebSocket ws )
		{
			byte[] msg = ToJson();
			string msgStr = Encoding.Default.GetString( msg );
			this.sentData = new byte[msg.Length + 1];

			this.sentData[0] = GetDataType();
			Buffer.BlockCopy( msg, 0, this.sentData, 1, msg.Length );

			await ws.SendAsync( this.sentData, WebSocketMessageType.Binary, true, new CancellationTokenSource( SHIPMessageTimeout.CMI_TIMEOUT ).Token ).ConfigureAwait( false );
		}

		public async Task Resend( WebSocket ws )
		{
			await ws.SendAsync( this.sentData, WebSocketMessageType.Binary, true, new CancellationTokenSource( SHIPMessageTimeout.T_HELLO_PROLONG_WAITING_GAP ).Token ).ConfigureAwait( false );
		}

		static public async Task<T> Receive( WebSocket ws, int timeout = SHIPMessageTimeout.CMI_TIMEOUT )
		{
			byte[] msg = new byte[1024];
			WebSocketReceiveResult result = await ws.ReceiveAsync( msg, new CancellationTokenSource( timeout ).Token ).ConfigureAwait( false );
			if ( result.MessageType == WebSocketMessageType.Close )
				return null;

			if ( (result.Count < 2) || (msg[0] != template.GetDataType()) )
				throw new Exception( $"Expected message of type {template.GetDataType()}!" );

			return template.FromJsonVirtual( msg );
		}
	}
}
