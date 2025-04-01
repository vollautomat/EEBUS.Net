using EEBUS.Enums;
using Newtonsoft.Json;
using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EEBUS
{
	public abstract class JsonMessage<T> where T: JsonMessage<T>,  new()
	{
		private byte[] sentData;

		protected abstract byte GetDataType();
		static private JsonMessage<T> template = new T();

		private byte[] ToJson()
		{
			var jsonSerializerSettings = new JsonSerializerSettings();
			jsonSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, jsonSerializerSettings));
		}

		static public T FromJson(byte[] data)
		{
			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Include,
				MissingMemberHandling = MissingMemberHandling.Error
			};

			string dataStr = Encoding.UTF8.GetString(data);
			dataStr = JsonFromEEBUSJson(dataStr);
			
			return JsonConvert.DeserializeObject<T>(dataStr, settings);
		}

		public async Task Send(WebSocket ws)
		{
			byte[] msg = ToJson();
			string msgStr = System.Text.Encoding.Default.GetString(msg);
			this.sentData = new byte[msg.Length + 1];

			this.sentData[0] = GetDataType();
			Buffer.BlockCopy(msg, 0, this.sentData, 1, msg.Length);

			await ws.SendAsync(this.sentData, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.CMI_TIMEOUT).Token).ConfigureAwait(false);
		}

		public async Task Resend(WebSocket ws)
		{
			await ws.SendAsync(this.sentData, WebSocketMessageType.Binary, true, new CancellationTokenSource(SHIPMessageTimeout.T_HELLO_PROLONG_WAITING_GAP).Token).ConfigureAwait(false);
		}

		static public async Task<T> Receive(WebSocket ws, int timeout = SHIPMessageTimeout.CMI_TIMEOUT)
		{
			byte[] msg = new byte[1024];
			WebSocketReceiveResult result = await ws.ReceiveAsync(msg, new CancellationTokenSource(timeout).Token).ConfigureAwait(false);
			if (result.MessageType == WebSocketMessageType.Close)
				return null;

			if ((result.Count < 2) || (msg[0] != template.GetDataType()))
				throw new Exception($"Expected message of type {template.GetDataType()}!");

			byte[] buffer = new byte[result.Count - 1];
			Buffer.BlockCopy(msg, 1, buffer, 0, result.Count - 1);

			return FromJson(buffer);
		}

		static private string JsonFromEEBUSJson(string json)
		{
			json = json.Replace("[{", "{");
			json = json.Replace("},{", ",");
			json = json.Replace("}]", "}");
			json = json.Replace("[]", "{}");
			return json;
		}
	}
}
