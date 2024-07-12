using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.ModIO.ApiModels;

namespace SLZ.ModIO
{
	[Serializable]
	public struct AgreementVersionObject
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
			this.Description = default(string);
			this.Changelog = default(string);
			this.Name = default(string);
			this.DateLive = default(long);
			this.DateUpdated = default(long);
			this.DateAdded = default(long);
			this.User = default(UserObject);
			this.Type = default(int);
			this.IsActive = default(bool);
			this.Id = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
