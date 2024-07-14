using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct GameObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("status")]
		public int Status { get; }

		[JsonProperty("submitted_by")]
		public UserObject SubmittedBy { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonProperty("date_updated")]
		public long DateUpdated { get; }

		[JsonProperty("date_live")]
		public long DateLive { get; }

		[JsonProperty("presentation_option")]
		public int PresentationOption { get; }

		[JsonProperty("community_options")]
		public int CommunityOptions { get; }

		[JsonProperty("monetisation_options")]
		public int MonetisationOptions { get; }

		[JsonProperty("submission_option")]
		public int SubmissionOption { get; }

		[JsonProperty("curation_option")]
		public int CurationOption { get; }

		[JsonProperty("revenue_options")]
		public int RevenueOptions { get; }

		[JsonProperty("api_access_options")]
		public int ApiAccessOptions { get; }

		[JsonProperty("maturity_options")]
		public int MaturityOptions { get; }

		[JsonProperty("ugc_name")]
		public string UgcName { get; }

		[JsonProperty("icon")]
		public IconObject Icon { get; }

		[JsonProperty("logo")]
		public LogoObject Logo { get; }

		[JsonProperty("header")]
		public HeaderImageObject Header { get; }

		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("name_id")]
		public string NameId { get; }

		[JsonProperty("summary")]
		public string Summary { get; }

		[JsonProperty("instructions")]
		public string Instructions { get; }

		[JsonProperty("instructions_url")]
		public string InstructionsUrl { get; }

		[JsonProperty("profile_url")]
		public string ProfileUrl { get; }

		[JsonProperty("other_urls")]
		public IReadOnlyList<GameOtherUrlsObject> OtherUrls { get; }

		[JsonProperty("tag_options")]
		public IReadOnlyList<GameTagOptionObject> TagOptions { get; }

		[JsonProperty("stats")]
		public GameStatsObject Stats { get; }

		[JsonProperty("theme")]
		public ThemeObject Theme { get; }

		[JsonProperty("platforms")]
		public IReadOnlyList<GamePlatformsObject> Platforms { get; }

		[JsonConstructor]
		public GameObject([JsonProperty("id")] long id, [JsonProperty("status")] int status, [JsonProperty("submitted_by")] UserObject submittedBy, [JsonProperty("date_added")] long dateAdded, [JsonProperty("date_updated")] long dateUpdated, [JsonProperty("date_live")] long dateLive, [JsonProperty("presentation_option")] int presentationOption, [JsonProperty("community_options")] int communityOptions, [JsonProperty("monetisation_options")] int monetisationOptions, [JsonProperty("submission_option")] int submissionOption, [JsonProperty("curation_option")] int curationOption, [JsonProperty("revenue_options")] int revenueOptions, [JsonProperty("api_access_options")] int apiAccessOptions, [JsonProperty("maturity_options")] int maturityOptions, [JsonProperty("ugc_name")] string ugcName, [JsonProperty("icon")] IconObject icon, [JsonProperty("logo")] LogoObject logo, [JsonProperty("header")] HeaderImageObject header, [JsonProperty("name")] string name, [JsonProperty("name_id")] string nameId, [JsonProperty("summary")] string summary, [JsonProperty("instructions")] string instructions, [JsonProperty("instructions_url")] string instructionsUrl, [JsonProperty("profile_url")] string profileUrl, [JsonProperty("other_urls")] List<GameOtherUrlsObject> otherUrls, [JsonProperty("tag_options")] List<GameTagOptionObject> tagOptions, [JsonProperty("stats")] GameStatsObject stats, [JsonProperty("theme")] ThemeObject theme, [JsonProperty("platforms")] List<GamePlatformsObject> platforms)
		{
			Id = 0L;
			Status = 0;
			SubmittedBy = default(UserObject);
			DateAdded = 0L;
			DateUpdated = 0L;
			DateLive = 0L;
			PresentationOption = 0;
			CommunityOptions = 0;
			MonetisationOptions = 0;
			SubmissionOption = 0;
			CurationOption = 0;
			RevenueOptions = 0;
			ApiAccessOptions = 0;
			MaturityOptions = 0;
			UgcName = null;
			Icon = default(IconObject);
			Logo = default(LogoObject);
			Header = default(HeaderImageObject);
			Name = null;
			NameId = null;
			Summary = null;
			Instructions = null;
			InstructionsUrl = null;
			ProfileUrl = null;
			OtherUrls = null;
			TagOptions = null;
			Stats = default(GameStatsObject);
			Theme = default(ThemeObject);
			Platforms = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
