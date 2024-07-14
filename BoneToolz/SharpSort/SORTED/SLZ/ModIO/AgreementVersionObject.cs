using System;
using Newtonsoft.Json;
using SLZ.ModIO.ApiModels;

namespace SLZ.ModIO
{
	[Serializable]
	public readonly struct AgreementVersionObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("is_active")]
		public bool IsActive { get; }

		[JsonProperty("type")]
		public int Type { get; }

		[JsonProperty("user")]
		public UserObject User { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonProperty("date_updated")]
		public long DateUpdated { get; }

		[JsonProperty("date_live")]
		public long DateLive { get; }

		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("changelog")]
		public string Changelog { get; }

		[JsonProperty("description")]
		public string Description { get; }

		[JsonConstructor]
		public AgreementVersionObject([JsonProperty("id")] long id, [JsonProperty("is_active")] bool isActive, [JsonProperty("type")] int type, [JsonProperty("user")] UserObject user, [JsonProperty("date_added")] long dateAdded, [JsonProperty("date_updated")] long dateUpdated, [JsonProperty("date_live")] long dateLive, [JsonProperty("name")] string name, [JsonProperty("changelog")] string changelog, [JsonProperty("description")] string description)
		{
			Id = 0L;
			IsActive = false;
			Type = 0;
			User = default(UserObject);
			DateAdded = 0L;
			DateUpdated = 0L;
			DateLive = 0L;
			Name = null;
			Changelog = null;
			Description = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
