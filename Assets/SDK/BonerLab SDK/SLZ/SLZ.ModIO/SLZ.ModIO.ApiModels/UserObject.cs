using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct UserObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("name_id")]
		public string NameId { get; }

		[JsonProperty("username")]
		public string Username { get; }

		[JsonProperty("display_name_portal")]
		public string DisplayNamePortal { get; }

		[JsonProperty("date_online")]
		public long DateOnline { get; }

		[JsonProperty("date_joined")]
		public long DateJoined { get; }

		[JsonProperty("avatar")]
		public AvatarObject Avatar { get; }

		[JsonProperty("timezone")]
		public string Timezone { get; }

		[JsonProperty("language")]
		public string Language { get; }

		[JsonProperty("profile_url")]
		public string ProfileUrl { get; }

		[JsonConstructor]
		public UserObject([JsonProperty("id")] long id, [JsonProperty("name_id")] string nameId, [JsonProperty("username")] string username, [JsonProperty("display_name_portal")] string displayNamePortal, [JsonProperty("date_online")] long dateOnline, [JsonProperty("date_joined")] long dateJoined, [JsonProperty("avatar")] AvatarObject avatar, [JsonProperty("timezone")] string timezone, [JsonProperty("language")] string language, [JsonProperty("profile_url")] string profileUrl)
		{
			Id = 0L;
			NameId = null;
			Username = null;
			DisplayNamePortal = null;
			DateOnline = 0L;
			DateJoined = 0L;
			Avatar = default(AvatarObject);
			Timezone = null;
			Language = null;
			ProfileUrl = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
