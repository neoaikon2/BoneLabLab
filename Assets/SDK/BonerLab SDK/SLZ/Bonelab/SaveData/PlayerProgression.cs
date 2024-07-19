using System.Collections.Generic;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public class PlayerProgression : IProgression, IFixFieldsIfNeeded
	{
		[JsonProperty("beat_game")]
		public bool BeatGame { get; set; }

		[JsonProperty("has_body_log")]
		public bool HasBodyLog { get; set; }

		[JsonProperty("body_log_enabled")]
		public bool BodyLogEnabled { get; set; }

		[JsonProperty("current_campaign_level")]
		public string CurrentCampaignLevel { get; set; }

		[JsonProperty("current_level")]
		public string CurrentLevel { get; set; }

		[JsonProperty("menu_resume")]
		public int MenuResume { get; set; }

		[JsonProperty("level_state")]
		public Dictionary<string, Dictionary<string, object>> LevelState { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
