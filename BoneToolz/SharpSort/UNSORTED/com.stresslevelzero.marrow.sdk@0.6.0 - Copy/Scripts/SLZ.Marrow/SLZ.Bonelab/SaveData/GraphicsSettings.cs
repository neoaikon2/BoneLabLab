using Newtonsoft.Json;

namespace SLZ.Bonelab.SaveData
{
	public sealed class GraphicsSettings
	{
		[JsonProperty("graphics_quality")]
		public GraphicsQuality GraphicsQuality { get; set; }

		[JsonProperty("adaptive_resolution")]
		public bool AdaptiveResolution { get; set; }

		[JsonProperty("texture_resolution")]
		public int TextureResolution { get; set; }

		[JsonProperty("msaa")]
		public int MSAA { get; set; }

		[JsonProperty("smaa")]
		public SettingLevel SMAA { get; set; }

		[JsonProperty("hbao")]
		public SettingLevel HBAO { get; set; }

		[JsonProperty("ssr")]
		public SettingLevel SSR { get; set; }

		[JsonProperty("shadow_cascade")]
		public int ShadowCascade { get; set; }

		[JsonProperty("render_scale")]
		public int RenderScale { get; set; }

		[JsonProperty("shadows")]
		public SettingLevel Shadows { get; set; }

		[JsonProperty("bloom")]
		public SettingLevel Bloom { get; set; }

		[JsonProperty("volumetrics")]
		public SettingLevel Volumetrics { get; set; }

		[JsonProperty("LOD_Bias")]
		public int LODBias { get; set; }

		[JsonProperty("FoveatedRenderingMode")]
		public FoveatedRenderingMode FoveatedRenderingModeSetting { get; set; }

		[JsonProperty("FoveatedPreset")]
		public FoveatedPresets FoveatedPresetSetting { get; set; }

		[JsonProperty("FoveatedOuterRadius")]
		public int FoveatedOuterRadius { get; set; }

		[JsonProperty("FoveatedInnerRatio")]
		public int FoveatedInnerRatio { get; set; }

		[JsonProperty("FoveatedSamplingAnisotropy")]
		public int FoveatedSamplingAnisotropy { get; set; }

		[JsonProperty("EnableFoveatedRenderingMenu")]
		public bool EnableFoveatedRenderingMenu { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
