using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class Save : ISave<PlayerSettings, PlayerProgression, PlayerUnlocks>, IFixFieldsIfNeeded
	{
		[JsonProperty("version")]
		public int Version { get; set; }

		[JsonProperty("modified")]
		public string Modified { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("player_settings")]
		public PlayerSettings PlayerSettings { get; set; }

		[JsonIgnore]
		public PlayerUnlocks Unlocks { get; set; }

		[JsonProperty("unlocks")]
		public string SerializedUnlocks { get; set; }

		[JsonIgnore]
		public PlayerProgression Progression { get; set; }

		[JsonProperty("progression")]
		public string SerializedProgression { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
