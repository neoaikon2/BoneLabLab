using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ModStatsObject
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
			this.DateExpires = default(long);
			this.RatingsDisplayText = default(string);
			this.RatingsWeightedAggregate = default(double);
			this.RatingsPercentagePositive = default(long);
			this.RatingsNegative = default(long);
			this.RatingsPositive = default(long);
			this.RatingsTotal = default(long);
			this.SubscribersTotal = default(long);
			this.DownloadsTotal = default(long);
			this.DownloadsToday = default(long);
			this.PopularityRankTotalMods = default(long);
			this.PopularityRankPosition = default(long);
			this.ModId = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
