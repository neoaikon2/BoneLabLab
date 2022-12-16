using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public sealed class GraphicsSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private GraphicsQuality _graphicsQuality;

		private bool _adaptiveResolution;

		private int _textureResolution;

		private int _msaa;

		private SettingLevel _smaa;

		private SettingLevel _HBAO;

		private SettingLevel _SSR;

		private int _shadowCascade;

		private int _renderScale;

		private SettingLevel _shadows;

		private SettingLevel _bloom;

		private SettingLevel _volumetrics;

		private int _LODBias;

		private FoveatedRenderingMode _foveatedRendering;

		private FoveatedPresets _foveatedPreset;

		private int _FoveatedOuterRadius;

		private int _FoveatedInnerRatio;

		private int _FoveatedSamplingAnisotropy;

		private bool _EnableFoveatedRenderingMenu;

		[JsonProperty("graphics_quality")]
		public GraphicsQuality GraphicsQuality
		{
			get
			{
				return default(GraphicsQuality);
			}
			set
			{
			}
		}

		[JsonProperty("adaptive_resolution")]
		public bool AdaptiveResolution
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonProperty("texture_resolution")]
		public int TextureResolution
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("msaa")]
		public int MSAA
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("smaa")]
		public SettingLevel SMAA
		{
			get
			{
				return default(SettingLevel);
			}
			set
			{
			}
		}

		[JsonProperty("hbao")]
		public SettingLevel HBAO
		{
			get
			{
				return default(SettingLevel);
			}
			set
			{
			}
		}

		[JsonProperty("ssr")]
		public SettingLevel SSR
		{
			get
			{
				return default(SettingLevel);
			}
			set
			{
			}
		}

		[JsonProperty("shadow_cascade")]
		public int ShadowCascade
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("render_scale")]
		public int RenderScale
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("shadows")]
		public SettingLevel Shadows
		{
			get
			{
				return default(SettingLevel);
			}
			set
			{
			}
		}

		[JsonProperty("bloom")]
		public SettingLevel Bloom
		{
			get
			{
				return default(SettingLevel);
			}
			set
			{
			}
		}

		[JsonProperty("volumetrics")]
		public SettingLevel Volumetrics
		{
			get
			{
				return default(SettingLevel);
			}
			set
			{
			}
		}

		[JsonProperty("LOD_Bias")]
		public int LODBias
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("FoveatedRenderingMode")]
		public FoveatedRenderingMode FoveatedRenderingModeSetting
		{
			get
			{
				return default(FoveatedRenderingMode);
			}
			set
			{
			}
		}

		[JsonProperty("FoveatedPreset")]
		public FoveatedPresets FoveatedPresetSetting
		{
			get
			{
				return default(FoveatedPresets);
			}
			set
			{
			}
		}

		[JsonProperty("FoveatedOuterRadius")]
		public int FoveatedOuterRadius
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("FoveatedInnerRatio")]
		public int FoveatedInnerRatio
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("FoveatedSamplingAnisotropy")]
		public int FoveatedSamplingAnisotropy
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonProperty("EnableFoveatedRenderingMenu")]
		public bool EnableFoveatedRenderingMenu
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void FixFieldsIfNeeded()
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = default(string))
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = default(string))
		{
		}

		public GraphicsSettings()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
