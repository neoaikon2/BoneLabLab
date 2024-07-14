using Newtonsoft.Json;

namespace SLZ.Bonelab.SaveData
{
	public class AmmoInventory
	{
		[JsonProperty("ammo_global_light")]
		public int AmmoGlobalLight { get; set; }

		[JsonProperty("ammo_global_medium")]
		public int AmmoGlobalMedium { get; set; }

		[JsonProperty("ammo_global_heavy")]
		public int AmmoGlobalHeavy { get; set; }
	}
}
