using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	public struct ModEventObject : IEventObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("mod_id")]
		public long ModId { get; }

		[JsonProperty("user_id")]
		public long UserId { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonProperty("event_type")]
		public string EventType { get; }

		[JsonConstructor]
		public ModEventObject([JsonProperty("id")] long id, [JsonProperty("mod_id")] long modId, [JsonProperty("user_id")] long userId, [JsonProperty("date_added")] long dateAdded, [JsonProperty("event_type")] string eventType)
		{
			this.EventType = default(string);
			this.DateAdded = default(long);
			this.UserId = default(long);
			this.ModId = default(long);
			this.Id = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
