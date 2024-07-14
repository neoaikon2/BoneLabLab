using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct UserEventObject : IEventObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("game_id")]
		public long GameId { get; }

		[JsonProperty("mod_id")]
		public long ModId { get; }

		[JsonProperty("user_id")]
		public long UserId { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonProperty("event_type")]
		public string EventType { get; }

		[JsonConstructor]
		public UserEventObject([JsonProperty("id")] long id, [JsonProperty("game_id")] long gameId, [JsonProperty("mod_id")] long modId, [JsonProperty("user_id")] long userId, [JsonProperty("date_added")] long dateAdded, [JsonProperty("event_type")] string eventType)
		{
			Id = 0L;
			GameId = 0L;
			ModId = 0L;
			UserId = 0L;
			DateAdded = 0L;
			EventType = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
