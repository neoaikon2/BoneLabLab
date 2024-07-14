using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	public interface ISave<TProgression, TUnlocks> where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new()
	{
		[JsonProperty("version")]
		int Version { get; set; }

		[JsonProperty("modified")]
		string Modified { get; set; }

		[JsonIgnore]
		TUnlocks Unlocks { get; set; }

		[JsonProperty("unlocks")]
		string SerializedUnlocks { get; set; }

		[JsonIgnore]
		TProgression Progression { get; set; }

		[JsonProperty("progression")]
		string SerializedProgression { get; set; }

		void FixFieldsIfNeeded();
	}
}
