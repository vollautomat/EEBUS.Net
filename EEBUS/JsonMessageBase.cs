using EEBUS.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EEBUS
{
	public class JsonMessageBase
	{
		static protected Dictionary<string, Type> messages = new Dictionary<string, Type>();

		static protected string GetCommand(byte[] bytes)
		{
			string str = Encoding.UTF8.GetString(bytes);
			int indx1 = str.IndexOf("{");
			int indx2 = str.IndexOf(":");
			return str.Substring(indx1, indx2 - indx1).Trim('"');
		}

		static public Type GetType(byte[] bytes)
		{
			string cmd = GetCommand(bytes);
			if (messages.TryGetValue(cmd, out Type type))
				return type;
			
			return null;
		}

		static protected string JsonFromEEBUSJson(string json)
		{
			json = json.Replace("[{", "{");
			json = json.Replace("},{", ",");
			json = json.Replace("}]", "}");
			json = json.Replace("[]", "{}");
			return json;
		}
	}
}
