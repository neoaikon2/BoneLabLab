using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	public class MessageConverter : JsonConverter<Message>
	{
		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, Message value, JsonSerializer serializer)
		{
		}

		public override Message ReadJson(JsonReader reader, Type objectType, Message existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return default(Message);
		}
	}
}
