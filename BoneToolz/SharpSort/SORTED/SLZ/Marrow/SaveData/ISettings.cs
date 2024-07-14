using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	public interface ISettings
	{
		[JsonProperty("version")]
		int Version { get; set; }

		[JsonProperty("active_save_game")]
		string ActiveSave { get; set; }

		void FixFieldsIfNeeded();
	}
}
