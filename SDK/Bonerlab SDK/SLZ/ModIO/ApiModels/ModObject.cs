using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ModObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("game_id")]
		public long GameId { get; }

		[JsonProperty("status")]
		public int Status { get; }

		[JsonProperty("visible")]
		public int Visible { get; }

		[JsonProperty("submitted_by")]
		public UserObject SubmittedBy { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonProperty("date_updated")]
		public long DateUpdated { get; }

		[JsonProperty("date_live")]
		public long DateLive { get; }

		[JsonProperty("maturity_option")]
		public int MaturityOption { get; }

		[JsonProperty("community_options")]
		public int CommunityOptions { get; }

		[JsonProperty("monetisation_options")]
		public int MonetisationOptions { get; }

		[JsonProperty("price")]
		public int Price { get; }

		[JsonProperty("tax")]
		public int Tax { get; }

		[JsonProperty("logo")]
		public LogoObject Logo { get; }

		[JsonProperty("homepage_url")]
		public string HomepageUrl { get; }

		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("name_id")]
		public string NameId { get; }

		[JsonProperty("summary")]
		public string Summary { get; }

		[JsonProperty("description")]
		public string Description { get; }

		[JsonProperty("description_plaintext")]
		public string DescriptionPlaintext { get; }

		[JsonProperty("metadata_blob")]
		public string MetadataBlob { get; }

		[JsonProperty("profile_url")]
		public string ProfileUrl { get; }

		[JsonProperty("media")]
		public ModMediaObject Media { get; }

		[JsonProperty("modfile")]
		public ModfileObject Modfile { get; }

		[JsonProperty("stats")]
		public ModStatsObject Stats { get; }

		[JsonProperty("platforms")]
		public IReadOnlyList<ModPlatformsObject> Platforms { get; }

		[JsonProperty("metadata_kvp")]
		public IReadOnlyList<MetadataKVPObject> MetadataKvp { get; }

		[JsonProperty("tags")]
		public IReadOnlyList<ModTagObject> Tags { get; }

		[JsonConstructor]
		public ModObject([JsonProperty("id")] long id, [JsonProperty("game_id")] long gameId, [JsonProperty("status")] int status, [JsonProperty("visible")] int visible, [JsonProperty("submitted_by")] UserObject submittedBy, [JsonProperty("date_added")] long dateAdded, [JsonProperty("date_updated")] long dateUpdated, [JsonProperty("date_live")] long dateLive, [JsonProperty("maturity_option")] int maturityOption, [JsonProperty("community_options")] int communityOptions, [JsonProperty("monetisation_options")] int monetisationOptions, [JsonProperty("price")] int price, [JsonProperty("tax")] int tax, [JsonProperty("logo")] LogoObject logo, [JsonProperty("homepage_url")] string homepageUrl, [JsonProperty("name")] string name, [JsonProperty("name_id")] string nameId, [JsonProperty("summary")] string summary, [JsonProperty("description")] string description, [JsonProperty("description_plaintext")] string descriptionPlaintext, [JsonProperty("metadata_blob")] string metadataBlob, [JsonProperty("profile_url")] string profileUrl, [JsonProperty("media")] ModMediaObject media, [JsonProperty("modfile")] ModfileObject modfile, [JsonProperty("stats")] ModStatsObject stats, [JsonProperty("platforms")] List<ModPlatformsObject> platforms, [JsonProperty("metadata_kvp")] List<MetadataKVPObject> metadataKvp, [JsonProperty("tags")] List<ModTagObject> tags)
		{
			this.Tags = default(IReadOnlyList<ModTagObject>);
			this.MetadataKvp = default(IReadOnlyList<MetadataKVPObject>);
			this.Platforms = default(IReadOnlyList<ModPlatformsObject>);
			this.Stats = default(ModStatsObject);
			this.Modfile = default(ModfileObject);
			this.Media = default(ModMediaObject);
			this.ProfileUrl = default(string);
			this.MetadataBlob = default(string);
			this.DescriptionPlaintext = default(string);
			this.Description = default(string);
			this.Summary = default(string);
			this.NameId = default(string);
			this.Name = default(string);
			this.HomepageUrl = default(string);
			this.Logo = default(LogoObject);
			this.Tax = default(int);
			this.Price = default(int);
			this.MonetisationOptions = default(int);
			this.CommunityOptions = default(int);
			this.MaturityOption = default(int);
			this.DateLive = default(long);
			this.DateUpdated = default(long);
			this.DateAdded = default(long);
			this.SubmittedBy = default(UserObject);
			this.Visible = default(int);
			this.Status = default(int);
			this.GameId = default(long);
			this.Id = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
