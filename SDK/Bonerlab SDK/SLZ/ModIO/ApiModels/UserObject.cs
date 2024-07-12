using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct UserObject
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
			this.ProfileUrl = default(string);
			this.Language = default(string);
			this.Timezone = default(string);
			this.Avatar = default(AvatarObject);
			this.DateJoined = default(long);
			this.DateOnline = default(long);
			this.DisplayNamePortal = default(string);
			this.Username = default(string);
			this.NameId = default(string);
			this.Id = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
