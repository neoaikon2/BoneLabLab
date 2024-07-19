using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class SpectatorSettings : ISpectatorSettings, IFixFieldsIfNeeded
	{
		[JsonProperty("eye_output")]
		public EyeTarget EyeOutput { get; set; }

		[JsonProperty("spectator_camera_mode")]
		public SpectatorCameraMode SpectatorCameraMode { get; set; }

		[JsonProperty("resolution_x")]
		public int ResolutionX { get; set; }

		[JsonProperty("resolution_y")]
		public int ResolutionY { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
