using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GameStatsObject
	{
		[JsonProperty("game_id")]
		public long GameId { get; }

		[JsonProperty("mods_count_total")]
		public long ModsCountTotal { get; }

		[JsonProperty("mods_downloads_today")]
		public long ModsDownloadsToday { get; }

		[JsonProperty("mods_downloads_total")]
		public long ModsDownloadsTotal { get; }

		[JsonProperty("mods_downloads_daily_average")]
		public long ModsDownloadsDailyAverage { get; }

		[JsonProperty("mods_subscribers_total")]
		public long ModsSubscribersTotal { get; }

		[JsonProperty("date_expires")]
		public long DateExpires { get; }

		[JsonConstructor]
		public GameStatsObject([JsonProperty("game_id")] long gameId, [JsonProperty("mods_count_total")] long modsCountTotal, [JsonProperty("mods_downloads_today")] long modsDownloadsToday, [JsonProperty("mods_downloads_total")] long modsDownloadsTotal, [JsonProperty("mods_downloads_daily_average")] long modsDownloadsDailyAverage, [JsonProperty("mods_subscribers_total")] long modsSubscribersTotal, [JsonProperty("date_expires")] long dateExpires)
		{
			this.DateExpires = default(long);
			this.ModsSubscribersTotal = default(long);
			this.ModsDownloadsDailyAverage = default(long);
			this.ModsDownloadsTotal = default(long);
			this.ModsDownloadsToday = default(long);
			this.ModsCountTotal = default(long);
			this.GameId = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
