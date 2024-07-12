using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class Settings : ISettings
	{
		[JsonProperty("version")]
		public int Version { get; set; }

		[JsonProperty("modified")]
		public string Modified { get; set; }

		[JsonProperty("active_save_game")]
		public string ActiveSave { get; set; }

		[JsonProperty("debug_settings")]
		public DebugSettings DebugSettings { get; set; }

		[JsonProperty("graphics_settings")]
		public GraphicsSettings GraphicsSettings { get; set; }

		[JsonProperty("spectator_settings")]
		public SpectatorSettings SpectatorSettings { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
