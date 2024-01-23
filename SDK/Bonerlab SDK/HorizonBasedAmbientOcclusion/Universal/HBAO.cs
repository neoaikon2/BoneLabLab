using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace HorizonBasedAmbientOcclusion.Universal
{
	[VolumeComponentMenu("Lighting/HBAO")]
	[ExecuteInEditMode]
	public class HBAO : VolumeComponent, IPostProcessComponent
	{
		public enum Preset
		{
			FastestPerformance = 0,
			FastPerformance = 1,
			Normal = 2,
			HighQuality = 3,
			HighestQuality = 4,
			Custom = 5
		}

		public enum Mode
		{
			Normal = 0,
			LitAO = 1
		}

		public enum RenderingPath
		{
			Forward = 0,
			Deferred = 1
		}

		public enum Quality
		{
			Lowest = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			Highest = 4
		}

		public enum Resolution
		{
			Full = 0,
			Half = 1
		}

		public enum NoiseType
		{
			Dither = 0,
			InterleavedGradientNoise = 1,
			SpatialDistribution = 2
		}

		public enum Deinterleaving
		{
			Disabled = 0,
			x4 = 1
		}

		public enum DebugMode
		{
			Disabled = 0,
			AOOnly = 1,
			ColorBleedingOnly = 2,
			SplitWithoutAOAndWithAO = 3,
			SplitWithAOAndAOOnly = 4,
			SplitWithoutAOAndAOOnly = 5,
			ViewNormals = 6
		}

		public enum BlurType
		{
			None = 0,
			Narrow = 1,
			Medium = 2,
			Wide = 3,
			ExtraWide = 4
		}

		public enum PerPixelNormals
		{
			Reconstruct2Samples = 0,
			Reconstruct4Samples = 1,
			Camera = 2
		}

		public enum VarianceClipping
		{
			Disabled = 0,
			_4Tap = 1,
			_8Tap = 2
		}

		[Serializable]
		public sealed class PresetParameter : VolumeParameter<Preset>
		{
			public PresetParameter(Preset value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class ModeParameter : VolumeParameter<Mode>
		{
			public ModeParameter(Mode value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class RenderingPathParameter : VolumeParameter<RenderingPath>
		{
			public RenderingPathParameter(RenderingPath value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class QualityParameter : VolumeParameter<Quality>
		{
			public QualityParameter(Quality value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class DeinterleavingParameter : VolumeParameter<Deinterleaving>
		{
			public DeinterleavingParameter(Deinterleaving value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class ResolutionParameter : VolumeParameter<Resolution>
		{
			public ResolutionParameter(Resolution value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class NoiseTypeParameter : VolumeParameter<NoiseType>
		{
			public NoiseTypeParameter(NoiseType value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class DebugModeParameter : VolumeParameter<DebugMode>
		{
			public DebugModeParameter(DebugMode value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class PerPixelNormalsParameter : VolumeParameter<PerPixelNormals>
		{
			public PerPixelNormalsParameter(PerPixelNormals value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class VarianceClippingParameter : VolumeParameter<VarianceClipping>
		{
			public VarianceClippingParameter(VarianceClipping value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class BlurTypeParameter : VolumeParameter<BlurType>
		{
			public BlurTypeParameter(BlurType value, bool overrideState = false)
				: base()
			{
			}
		}

		[Serializable]
		public sealed class MinMaxFloatParameter : VolumeParameter<Vector2>
		{
			public float min;

			public float max;

			public MinMaxFloatParameter(Vector2 value, float min, float max, bool overrideState = false)
				: base()
			{
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			public bool isExpanded;

			public SettingsGroup()
				: base()
			{
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class ParameterDisplayName : Attribute
		{
			public string name;

			public ParameterDisplayName(string name)
				: base()
			{
			}
		}

		public class Presets : SettingsGroup
		{
			public Presets()
				: base()
			{
			}
		}

		public class GeneralSettings : SettingsGroup
		{
			public GeneralSettings()
				: base()
			{
			}
		}

		public class AOSettings : SettingsGroup
		{
			public AOSettings()
				: base()
			{
			}
		}

		public class TemporalFilterSettings : SettingsGroup
		{
			public TemporalFilterSettings()
				: base()
			{
			}
		}

		public class BlurSettings : SettingsGroup
		{
			public BlurSettings()
				: base()
			{
			}
		}

		public class ColorBleedingSettings : SettingsGroup
		{
			public ColorBleedingSettings()
				: base()
			{
			}
		}

		[Presets]
		public PresetParameter preset;

		[Tooltip("The mode of the AO.")]
		[Space(6f)]
		[GeneralSettings]
		public ModeParameter mode;

		[Tooltip("The rendering path used for AO. Temporary settings as for now rendering path is internal to renderer settings.")]
		[Space(6f)]
		[GeneralSettings]
		public RenderingPathParameter renderingPath;

		[Space(6f)]
		[Tooltip("The quality of the AO.")]
		[GeneralSettings]
		public QualityParameter quality;

		[Tooltip("The deinterleaving factor.")]
		[GeneralSettings]
		public DeinterleavingParameter deinterleaving;

		[GeneralSettings]
		[Tooltip("The resolution at which the AO is calculated.")]
		public ResolutionParameter resolution;

		[Space(10f)]
		[GeneralSettings]
		[Tooltip("The type of noise to use.")]
		public NoiseTypeParameter noiseType;

		[Tooltip("The debug mode actually displayed on screen.")]
		[GeneralSettings]
		[Space(10f)]
		public DebugModeParameter debugMode;

		[Space(6f)]
		[Tooltip("AO radius: this is the distance outside which occluders are ignored.")]
		[AOSettings]
		public ClampedFloatParameter radius;

		[Tooltip("Maximum radius in pixels: this prevents the radius to grow too much with close-up object and impact on performances.")]
		[AOSettings]
		public ClampedFloatParameter maxRadiusPixels;

		[Tooltip("For low-tessellated geometry, occlusion variations tend to appear at creases and ridges, which betray the underlying tessellation. To remove these artifacts, we use an angle bias parameter which restricts the hemisphere.")]
		[AOSettings]
		public ClampedFloatParameter bias;

		[Tooltip("This value allows to scale up the ambient occlusion values.")]
		[AOSettings]
		public ClampedFloatParameter intensity;

		[Tooltip("Enable/disable MultiBounce approximation.")]
		[AOSettings]
		public BoolParameter useMultiBounce;

		[Tooltip("MultiBounce approximation influence.")]
		[AOSettings]
		public ClampedFloatParameter multiBounceInfluence;

		[Tooltip("How much AO affect direct lighting.")]
		[AOSettings]
		public ClampedFloatParameter directLightingStrength;

		[Tooltip("The amount of AO offscreen samples are contributing.")]
		[AOSettings]
		public ClampedFloatParameter offscreenSamplesContribution;

		[Tooltip("The max distance to display AO.")]
		[AOSettings]
		[Space(10f)]
		public FloatParameter maxDistance;

		[Tooltip("The distance before max distance at which AO start to decrease.")]
		[AOSettings]
		public FloatParameter distanceFalloff;

		[Tooltip("The type of per pixel normals to use.")]
		[AOSettings]
		[Space(10f)]
		public PerPixelNormalsParameter perPixelNormals;

		[Tooltip("This setting allow you to set the base color if the AO, the alpha channel value is unused.")]
		[AOSettings]
		[Space(10f)]
		public ColorParameter baseColor;

		[TemporalFilterSettings]
		[ParameterDisplayName("Enabled")]
		[Space(6f)]
		public BoolParameter temporalFilterEnabled;

		[TemporalFilterSettings]
		[Tooltip("The type of variance clipping to use.")]
		public VarianceClippingParameter varianceClipping;

		[BlurSettings]
		[ParameterDisplayName("Type")]
		[Space(6f)]
		[Tooltip("The type of blur to use.")]
		public BlurTypeParameter blurType;

		[Tooltip("This parameter controls the depth-dependent weight of the bilateral filter, to avoid bleeding across edges. A zero sharpness is a pure Gaussian blur. Increasing the blur sharpness removes bleeding by using lower weights for samples with large depth delta from the current pixel.")]
		[BlurSettings]
		[Space(10f)]
		public ClampedFloatParameter sharpness;

		[ParameterDisplayName("Enabled")]
		[Space(6f)]
		[ColorBleedingSettings]
		public BoolParameter colorBleedingEnabled;

		[Tooltip("This value allows to control the saturation of the color bleeding.")]
		[Space(10f)]
		[ColorBleedingSettings]
		public ClampedFloatParameter saturation;

		[Tooltip("Use masking on emissive pixels")]
		[ColorBleedingSettings]
		public ClampedFloatParameter brightnessMask;

		[ColorBleedingSettings]
		[Tooltip("Brightness level where masking starts/ends")]
		public MinMaxFloatParameter brightnessMaskRange;

		public void EnableHBAO(bool enable)
		{
		}

		public Preset GetCurrentPreset()
		{
			return default(Preset);
		}

		public void ApplyPreset(Preset preset)
		{
		}

		public Mode GetMode()
		{
			return default(Mode);
		}

		public void SetMode(Mode mode)
		{
		}

		public RenderingPath GetRenderingPath()
		{
			return default(RenderingPath);
		}

		public void SetRenderingPath(RenderingPath renderingPath)
		{
		}

		public Quality GetQuality()
		{
			return default(Quality);
		}

		public void SetQuality(Quality quality)
		{
		}

		public Deinterleaving GetDeinterleaving()
		{
			return default(Deinterleaving);
		}

		public void SetDeinterleaving(Deinterleaving deinterleaving)
		{
		}

		public Resolution GetResolution()
		{
			return default(Resolution);
		}

		public void SetResolution(Resolution resolution)
		{
		}

		public NoiseType GetNoiseType()
		{
			return default(NoiseType);
		}

		public void SetNoiseType(NoiseType noiseType)
		{
		}

		public DebugMode GetDebugMode()
		{
			return default(DebugMode);
		}

		public void SetDebugMode(DebugMode debugMode)
		{
		}

		public float GetAoRadius()
		{
			return default(float);
		}

		public void SetAoRadius(float radius)
		{
		}

		public float GetAoMaxRadiusPixels()
		{
			return default(float);
		}

		public void SetAoMaxRadiusPixels(float maxRadiusPixels)
		{
		}

		public float GetAoBias()
		{
			return default(float);
		}

		public void SetAoBias(float bias)
		{
		}

		public float GetAoOffscreenSamplesContribution()
		{
			return default(float);
		}

		public void SetAoOffscreenSamplesContribution(float offscreenSamplesContribution)
		{
		}

		public float GetAoMaxDistance()
		{
			return default(float);
		}

		public void SetAoMaxDistance(float maxDistance)
		{
		}

		public float GetAoDistanceFalloff()
		{
			return default(float);
		}

		public void SetAoDistanceFalloff(float distanceFalloff)
		{
		}

		public PerPixelNormals GetAoPerPixelNormals()
		{
			return default(PerPixelNormals);
		}

		public void SetAoPerPixelNormals(PerPixelNormals perPixelNormals)
		{
		}

		public Color GetAoColor()
		{
			return default(Color);
		}

		public void SetAoColor(Color baseColor)
		{
		}

		public float GetAoIntensity()
		{
			return default(float);
		}

		public void SetAoIntensity(float intensity)
		{
		}

		public bool UseMultiBounce()
		{
			return default(bool);
		}

		public void EnableMultiBounce(bool enabled = true)
		{
		}

		public float GetAoMultiBounceInfluence()
		{
			return default(float);
		}

		public void SetAoMultiBounceInfluence(float multiBounceInfluence)
		{
		}

		public bool IsTemporalFilterEnabled()
		{
			return default(bool);
		}

		public void EnableTemporalFilter(bool enabled = true)
		{
		}

		public VarianceClipping GetTemporalFilterVarianceClipping()
		{
			return default(VarianceClipping);
		}

		public void SetTemporalFilterVarianceClipping(VarianceClipping varianceClipping)
		{
		}

		public BlurType GetBlurType()
		{
			return default(BlurType);
		}

		public void SetBlurType(BlurType blurType)
		{
		}

		public float GetBlurSharpness()
		{
			return default(float);
		}

		public void SetBlurSharpness(float sharpness)
		{
		}

		public bool IsColorBleedingEnabled()
		{
			return default(bool);
		}

		public void EnableColorBleeding(bool enabled = true)
		{
		}

		public float GetColorBleedingSaturation()
		{
			return default(float);
		}

		public void SetColorBleedingSaturation(float saturation)
		{
		}

		public float GetColorBleedingBrightnessMask()
		{
			return default(float);
		}

		public void SetColorBleedingBrightnessMask(float brightnessMask)
		{
		}

		public Vector2 GetColorBleedingBrightnessMaskRange()
		{
			return default(Vector2);
		}

		public void SetColorBleedingBrightnessMaskRange(Vector2 brightnessMaskRange)
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsTileCompatible()
		{
			return default(bool);
		}

		public HBAO()
			: base()
		{
		}
	}
}
