using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ModStatsObject
	{
		[JsonProperty("mod_id")]
		public long ModId { get; }

		[JsonProperty("popularity_rank_position")]
		public long PopularityRankPosition { get; }

		[JsonProperty("popularity_rank_total_mods")]
		public long PopularityRankTotalMods { get; }

		[JsonProperty("downloads_today")]
		public long DownloadsToday { get; }

		[JsonProperty("downloads_total")]
		public long DownloadsTotal { get; }

		[JsonProperty("subscribers_total")]
		public long SubscribersTotal { get; }

		[JsonProperty("ratings_total")]
		public long RatingsTotal { get; }

		[JsonProperty("ratings_positive")]
		public long RatingsPositive { get; }

		[JsonProperty("ratings_negative")]
		public long RatingsNegative { get; }

		[JsonProperty("ratings_percentage_positive")]
		public long RatingsPercentagePositive { get; }

		[JsonProperty("ratings_weighted_aggregate")]
		public double RatingsWeightedAggregate { get; }

		[JsonProperty("ratings_display_text")]
		public string RatingsDisplayText { get; }

		[JsonProperty("date_expires")]
		public long DateExpires { get; }

		[JsonConstructor]
		public ModStatsObject([JsonProperty("mod_id")] long modId, [JsonProperty("popularity_rank_position")] long popularityRankPosition, [JsonProperty("popularity_rank_total_mods")] long popularityRankTotalMods, [JsonProperty("downloads_today")] long downloadsToday, [JsonProperty("downloads_total")] long downloadsTotal, [JsonProperty("subscribers_total")] long subscribersTotal, [JsonProperty("ratings_total")] long ratingsTotal, [JsonProperty("ratings_positive")] long ratingsPositive, [JsonProperty("ratings_negative")] long ratingsNegative, [JsonProperty("ratings_percentage_positive")] long ratingsPercentagePositive, [JsonProperty("ratings_weighted_aggregate")] double ratingsWeightedAggregate, [JsonProperty("ratings_display_text")] string ratingsDisplayText, [JsonProperty("date_expires")] long dateExpires)
		{
			ModId = 0L;
			PopularityRankPosition = 0L;
			PopularityRankTotalMods = 0L;
			DownloadsToday = 0L;
			DownloadsTotal = 0L;
			SubscribersTotal = 0L;
			RatingsTotal = 0L;
			RatingsPositive = 0L;
			RatingsNegative = 0L;
			RatingsPercentagePositive = 0L;
			RatingsWeightedAggregate = 0.0;
			RatingsDisplayText = null;
			DateExpires = 0L;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
