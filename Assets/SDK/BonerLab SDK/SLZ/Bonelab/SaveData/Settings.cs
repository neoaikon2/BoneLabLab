using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class Settings : ISettings, IFixFieldsIfNeeded
	{
		[JsonProperty("version")]
		public int Version { get; set; }

		[JsonProperty("modified")]
		public string Modified { get; set; }

		[JsonProperty("active_save_game")]
		public string ActiveSave { get; set; }

		[JsonProperty("debug_settings")]
		public IDebugSettings DebugSettings { get; set; }

		[JsonProperty("graphics_settings")]
		public IGraphicsSettings GraphicsSettings { get; set; }

		[JsonProperty("spectator_settings")]
		public ISpectatorSettings SpectatorSettings { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
