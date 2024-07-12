using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.Bonelab.SaveData
{
	public sealed class PlayerSettings
	{
		[JsonProperty("modified")]
		public string Modified { get; set; }

		[JsonProperty("inventory_hud_enabled")]
		public bool InventoryHudEnabled { get; set; }

		[JsonProperty("tooltips_enabled")]
		public bool TooltipsEnabled { get; set; }

		[JsonProperty("haptics")]
		public float Haptics { get; set; }

		[JsonProperty("right_handed")]
		public bool RightHanded { get; set; }

		[JsonProperty("locomotion_curve")]
		public int LocomotionCurve { get; set; }

		[JsonProperty("locomotion_degrees_per_snap")]
		public float LocomotionDegreesPerSnap { get; set; }

		[JsonProperty("locomotion_direction")]
		public int LocomotionDirection { get; set; }

		[JsonProperty("locomotion_snap_degrees_per_frame")]
		public int LocomotionSnapDegreesPerFrame { get; set; }

		[JsonProperty("snap_enabled")]
		public bool SnapEnabled { get; set; }

		[JsonProperty("virtual_crouching_enabled")]
		public bool VirtualCrouchingEnabled { get; set; }

		[JsonProperty("player_height")]
		public float PlayerHeight { get; set; }

		[JsonProperty("measurement_presets")]
		public BodyVitals.MeasurementState MeasurementPresets { get; set; }

		[JsonProperty("chest_circumference")]
		public float ChestCircumference { get; set; }

		[JsonProperty("underbust_circumference")]
		public float UnderbustCircumference { get; set; }

		[JsonProperty("waist_circumference")]
		public float WaistCircumference { get; set; }

		[JsonProperty("hips_circumference")]
		public float HipsCircumference { get; set; }

		[JsonProperty("wingspan_length")]
		public float WingspanLength { get; set; }

		[JsonProperty("inseam_length")]
		public float InseamLength { get; set; }

		[JsonProperty("offset_sitting")]
		public float OffsetSitting { get; set; }

		[JsonProperty("offset_floor")]
		public float OffsetFloor { get; set; }

		[JsonProperty("standing")]
		public bool Standing { get; set; }

		[JsonProperty("belt_location_right")]
		public bool BeltLocationRight { get; set; }

		[JsonProperty("body_log_location_right")]
		public bool BodyLogLocationRight { get; set; }

		[JsonProperty("volume_global")]
		public float VolumeGlobal { get; set; }

		[JsonProperty("volume_music")]
		public float VolumeMusic { get; set; }

		[JsonProperty("volume_sfx")]
		public float VolumeSFX { get; set; }

		[JsonProperty("fallback_avatar")]
		public string FallbackAvatar { get; set; }

		[JsonProperty("current_avatar")]
		public string CurrentAvatar { get; set; }

		[JsonProperty("favorite_avatars")]
		public List<string> FavoriteAvatars { get; set; }

		[JsonProperty("favorite_spawnables")]
		public List<string> FavoriteSpawnables { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
