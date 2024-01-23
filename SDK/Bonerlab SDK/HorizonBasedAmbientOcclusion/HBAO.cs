using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace HorizonBasedAmbientOcclusion
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/HBAO")]
	[RequireComponent(typeof(Camera))]
	public class HBAO : MonoBehaviour
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

		public enum PipelineStage
		{
			BeforeImageEffectsOpaque = 0,
			AfterLighting = 1,
			BeforeReflections = 2
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
			GBuffer = 0,
			Camera = 1,
			Reconstruct = 2
		}

		public enum VarianceClipping
		{
			Disabled = 0,
			_4Tap = 1,
			_8Tap = 2
		}

		[Serializable]
		public struct Presets
		{
			public Preset preset;

			[SerializeField]
			public static Presets defaults
			{
				get
				{
					return default(Presets);
				}
			}
		}

		[Serializable]
		public struct GeneralSettings
		{
			[Tooltip("The stage the AO is injected into the rendering pipeline.")]
			[Space(6f)]
			public PipelineStage pipelineStage;

			[Tooltip("The quality of the AO.")]
			[Space(10f)]
			public Quality quality;

			[Tooltip("The deinterleaving factor.")]
			public Deinterleaving deinterleaving;

			[Tooltip("The resolution at which the AO is calculated.")]
			public Resolution resolution;

			[Space(10f)]
			[Tooltip("The type of noise to use.")]
			public NoiseType noiseType;

			[Space(10f)]
			[Tooltip("The debug mode actually displayed on screen.")]
			public DebugMode debugMode;

			[SerializeField]
			public static GeneralSettings defaults
			{
				get
				{
					return default(GeneralSettings);
				}
			}
		}

		[Serializable]
		public struct AOSettings
		{
			[Tooltip("AO radius: this is the distance outside which occluders are ignored.")]
			[Space(6f)]
			[Range(0.25f, 5f)]
			public float radius;

			[Range(16f, 256f)]
			[Tooltip("Maximum radius in pixels: this prevents the radius to grow too much with close-up object and impact on performances.")]
			public float maxRadiusPixels;

			[Tooltip("For low-tessellated geometry, occlusion variations tend to appear at creases and ridges, which betray the underlying tessellation. To remove these artifacts, we use an angle bias parameter which restricts the hemisphere.")]
			[Range(0f, 0.5f)]
			public float bias;

			[Tooltip("This value allows to scale up the ambient occlusion values.")]
			[Range(0f, 4f)]
			public float intensity;

			[Tooltip("Enable/disable MultiBounce approximation.")]
			public bool useMultiBounce;

			[Range(0f, 1f)]
			[Tooltip("MultiBounce approximation influence.")]
			public float multiBounceInfluence;

			[Range(0f, 1f)]
			[Tooltip("The amount of AO offscreen samples are contributing.")]
			public float offscreenSamplesContribution;

			[Tooltip("The max distance to display AO.")]
			[Space(10f)]
			public float maxDistance;

			[Tooltip("The distance before max distance at which AO start to decrease.")]
			public float distanceFalloff;

			[Tooltip("The type of per pixel normals to use.")]
			[Space(10f)]
			public PerPixelNormals perPixelNormals;

			[Tooltip("This setting allow you to set the base color if the AO, the alpha channel value is unused.")]
			[Space(10f)]
			public Color baseColor;

			[SerializeField]
			public static AOSettings defaults
			{
				get
				{
					return default(AOSettings);
				}
			}
		}

		[Serializable]
		public struct TemporalFilterSettings
		{
			[Space(6f)]
			public bool enabled;

			[Tooltip("The type of variance clipping to use.")]
			public VarianceClipping varianceClipping;

			[SerializeField]
			public static TemporalFilterSettings defaults
			{
				get
				{
					return default(TemporalFilterSettings);
				}
			}
		}

		[Serializable]
		public struct BlurSettings
		{
			[Space(6f)]
			[Tooltip("The type of blur to use.")]
			public BlurType type;

			[Space(10f)]
			[Tooltip("This parameter controls the depth-dependent weight of the bilateral filter, to avoid bleeding across edges. A zero sharpness is a pure Gaussian blur. Increasing the blur sharpness removes bleeding by using lower weights for samples with large depth delta from the current pixel.")]
			[Range(0f, 16f)]
			public float sharpness;

			[SerializeField]
			public static BlurSettings defaults
			{
				get
				{
					return default(BlurSettings);
				}
			}
		}

		[Serializable]
		public struct ColorBleedingSettings
		{
			[Space(6f)]
			public bool enabled;

			[Tooltip("This value allows to control the saturation of the color bleeding.")]
			[Space(10f)]
			[Range(0f, 4f)]
			public float saturation;

			[Tooltip("This value allows to scale the contribution of the color bleeding samples.")]
			[Range(0f, 32f)]
			public float albedoMultiplier;

			[Tooltip("Use masking on emissive pixels")]
			[Range(0f, 1f)]
			public float brightnessMask;

			[Tooltip("Brightness level where masking starts/ends")]
			[MinMaxSlider(0f, 2f)]
			public Vector2 brightnessMaskRange;

			[SerializeField]
			public static ColorBleedingSettings defaults
			{
				get
				{
					return default(ColorBleedingSettings);
				}
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			public SettingsGroup()
				: base()
			{
			}
		}

		public class MinMaxSliderAttribute : PropertyAttribute
		{
			public readonly float max;

			public readonly float min;

			public MinMaxSliderAttribute(float min, float max)
				: base()
			{
			}
		}

		private static class Pass
		{
			public const int AO = 0;

			public const int AO_Deinterleaved = 1;

			public const int Deinterleave_Depth = 2;

			public const int Deinterleave_Normals = 3;

			public const int Atlas_AO_Deinterleaved = 4;

			public const int Reinterleave_AO = 5;

			public const int Blur = 6;

			public const int Temporal_Filter = 7;

			public const int Copy = 8;

			public const int Composite = 9;

			public const int Composite_AfterLighting = 10;

			public const int Composite_BeforeReflections = 11;

			public const int Debug_ViewNormals = 12;
		}

		private static class ShaderProperties
		{
			public static int mainTex;

			public static int hbaoTex;

			public static int tempTex;

			public static int tempTex2;

			public static int noiseTex;

			public static int depthTex;

			public static int normalsTex;

			public static int[] depthSliceTex;

			public static int[] normalsSliceTex;

			public static int[] aoSliceTex;

			public static int[] deinterleaveOffset;

			public static int atlasOffset;

			public static int jitter;

			public static int uvTransform;

			public static int inputTexelSize;

			public static int aoTexelSize;

			public static int deinterleavedAOTexelSize;

			public static int reinterleavedAOTexelSize;

			public static int uvToView;

			public static int worldToCameraMatrix;

			public static int targetScale;

			public static int radius;

			public static int maxRadiusPixels;

			public static int negInvRadius2;

			public static int angleBias;

			public static int aoMultiplier;

			public static int intensity;

			public static int multiBounceInfluence;

			public static int offscreenSamplesContrib;

			public static int maxDistance;

			public static int distanceFalloff;

			public static int baseColor;

			public static int colorBleedSaturation;

			public static int albedoMultiplier;

			public static int colorBleedBrightnessMask;

			public static int colorBleedBrightnessMaskRange;

			public static int blurDeltaUV;

			public static int blurSharpness;

			public static int temporalParams;

			static ShaderProperties()
			{
			}

			public static string GetOrthographicOrDeferredKeyword(bool orthographic, GeneralSettings settings)
			{
				return null;
			}

			public static string GetDirectionsKeyword(GeneralSettings settings)
			{
				return null;
			}

			public static string GetStepsKeyword(GeneralSettings settings)
			{
				return null;
			}

			public static string GetNoiseKeyword(GeneralSettings settings)
			{
				return null;
			}

			public static string GetDeinterleavingKeyword(GeneralSettings settings)
			{
				return null;
			}

			public static string GetDebugKeyword(GeneralSettings settings)
			{
				return null;
			}

			public static string GetMultibounceKeyword(AOSettings settings)
			{
				return null;
			}

			public static string GetOffscreenSamplesContributionKeyword(AOSettings settings)
			{
				return null;
			}

			public static string GetPerPixelNormalsKeyword(AOSettings settings)
			{
				return null;
			}

			public static string GetBlurRadiusKeyword(BlurSettings settings)
			{
				return null;
			}

			public static string GetVarianceClippingKeyword(TemporalFilterSettings settings)
			{
				return null;
			}

			public static string GetColorBleedingKeyword(ColorBleedingSettings settings)
			{
				return null;
			}

			public static string GetLightingLogEncodedKeyword(bool hdr)
			{
				return null;
			}
		}

		private static class MersenneTwister
		{
			public static float[] Numbers;
		}

		public Shader hbaoShader;

		[SerializeField]
		[SettingsGroup]
		private Presets m_Presets;

		[SerializeField]
		[SettingsGroup]
		private GeneralSettings m_GeneralSettings;

		[SerializeField]
		[SettingsGroup]
		private AOSettings m_AOSettings;

		[SettingsGroup]
		[SerializeField]
		private TemporalFilterSettings m_TemporalFilterSettings;

		[SettingsGroup]
		[SerializeField]
		private BlurSettings m_BlurSettings;

		[SettingsGroup]
		[SerializeField]
		private ColorBleedingSettings m_ColorBleedingSettings;

		private static readonly Vector2[] s_jitter;

		private static readonly float[] s_temporalRotations;

		private static readonly float[] s_temporalOffsets;

		private RenderTextureDescriptor m_sourceDescriptor;

		private string[] m_ShaderKeywords;

		private bool m_IsCommandBufferDirty;

		private Mesh m_FullscreenTriangle;

		private PipelineStage? m_PreviousPipelineStage;

		private Resolution? m_PreviousResolution;

		private Deinterleaving? m_PreviousDeinterleaving;

		private DebugMode? m_PreviousDebugMode;

		private NoiseType? m_PreviousNoiseType;

		private BlurType? m_PreviousBlurAmount;

		private int m_PreviousWidth;

		private int m_PreviousHeight;

		private bool m_PreviousAllowHDR;

		private bool m_PreviousColorBleedingEnabled;

		private bool m_PreviousTemporalFilterEnabled;

		private RenderingPath m_PreviousRenderingPath;

		public Presets presets
		{
			get
			{
				return default(Presets);
			}
			set
			{
			}
		}

		public GeneralSettings generalSettings
		{
			get
			{
				return default(GeneralSettings);
			}
			set
			{
			}
		}

		public AOSettings aoSettings
		{
			get
			{
				return default(AOSettings);
			}
			set
			{
			}
		}

		public TemporalFilterSettings temporalFilterSettings
		{
			get
			{
				return default(TemporalFilterSettings);
			}
			set
			{
			}
		}

		public BlurSettings blurSettings
		{
			get
			{
				return default(BlurSettings);
			}
			set
			{
			}
		}

		public ColorBleedingSettings colorBleedingSettings
		{
			get
			{
				return default(ColorBleedingSettings);
			}
			set
			{
			}
		}

		private Material material { get; set; }

		private Camera hbaoCamera { get; set; }

		private CommandBuffer cmdBuffer { get; set; }

		private int width { get; set; }

		private int height { get; set; }

		private bool stereoActive { get; set; }

		private int numberOfEyes { get; set; }

		private int xrActiveEye { get; set; }

		private XRSettings.StereoRenderingMode stereoRenderingMode { get; set; }

		private int screenWidth { get; set; }

		private int screenHeight { get; set; }

		private int aoWidth { get; set; }

		private int aoHeight { get; set; }

		private int reinterleavedAoWidth { get; set; }

		private int reinterleavedAoHeight { get; set; }

		private int deinterleavedAoWidth { get; set; }

		private int deinterleavedAoHeight { get; set; }

		private int frameCount { get; set; }

		private bool motionVectorsSupported { get; set; }

		private RenderTexture aoHistoryBuffer { get; set; }

		private RenderTexture colorBleedingHistoryBuffer { get; set; }

		private Texture2D noiseTex { get; set; }

		private Mesh fullscreenTriangle
		{
			get
			{
				return null;
			}
		}

		private CameraEvent cameraEvent
		{
			get
			{
				return default(CameraEvent);
			}
		}

		private bool isCommandBufferDirty
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private static RenderTextureFormat defaultHDRRenderTextureFormat
		{
			get
			{
				return default(RenderTextureFormat);
			}
		}

		private RenderTextureFormat sourceFormat
		{
			get
			{
				return default(RenderTextureFormat);
			}
		}

		private static RenderTextureFormat colorFormat
		{
			get
			{
				return default(RenderTextureFormat);
			}
		}

		private static RenderTextureFormat depthFormat
		{
			get
			{
				return default(RenderTextureFormat);
			}
		}

		private static RenderTextureFormat normalsFormat
		{
			get
			{
				return default(RenderTextureFormat);
			}
		}

		private static bool isLinearColorSpace
		{
			get
			{
				return default(bool);
			}
		}

		private bool renderingInSceneView
		{
			get
			{
				return default(bool);
			}
		}

		public Preset GetCurrentPreset()
		{
			return default(Preset);
		}

		public void ApplyPreset(Preset preset)
		{
		}

		public PipelineStage GetPipelineStage()
		{
			return default(PipelineStage);
		}

		public void SetPipelineStage(PipelineStage pipelineStage)
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

		public void SetAoOffscreenSamplesContribution(float contribution)
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

		public void SetAoColor(Color color)
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

		public float GetColorBleedingAlbedoMultiplier()
		{
			return default(float);
		}

		public void SetColorBleedingAlbedoMultiplier(float albedoMultiplier)
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPreRender()
		{
		}

		private void OnPostRender()
		{
		}

		private void OnValidate()
		{
		}

		private void Initialize()
		{
		}

		private void FetchRenderParameters()
		{
		}

		private void AllocateHistoryBuffers()
		{
		}

		private void ReleaseHistoryBuffers()
		{
		}

		private void ClearCommandBuffer(CommandBuffer cmd)
		{
		}

		private void BuildCommandBuffer(CommandBuffer cmd, CameraEvent cameraEvent)
		{
		}

		private void AO(CommandBuffer cmd)
		{
		}

		private void DeinterleavedAO(CommandBuffer cmd)
		{
		}

		private void Blur(CommandBuffer cmd)
		{
		}

		private void TemporalFilter(CommandBuffer cmd)
		{
		}

		private void Composite(CommandBuffer cmd, CameraEvent cameraEvent)
		{
		}

		private void CompositeBeforeReflections(CommandBuffer cmd)
		{
		}

		private void CompositeAfterLighting(CommandBuffer cmd)
		{
		}

		private void CompositeBeforeImageEffectsOpaque(CommandBuffer cmd, int finalPassId = 9)
		{
		}

		private void UpdateMaterialProperties()
		{
		}

		private void UpdateShaderKeywords()
		{
		}

		private void CheckParameters()
		{
		}

		private RenderTextureDescriptor GetDefaultDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
		{
			return default(RenderTextureDescriptor);
		}

		private RenderTexture GetScreenSpaceRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
			return null;
		}

		private void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
		}

		private void ReleaseTemporaryRT(CommandBuffer cmd, int nameID)
		{
		}

		private void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass = 0)
		{
		}

		private void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Material material, int pass = 0)
		{
		}

		private void BlitFullscreenTriangleWithClear(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, Color clearColor, int pass = 0)
		{
		}

		private static void ApplyFlip(CommandBuffer cmd, bool flip = true)
		{
		}

		private static Vector2 AdjustBrightnessMaskToGammaSpace(Vector2 v)
		{
			return default(Vector2);
		}

		private static float ToGammaSpace(float v)
		{
			return default(float);
		}

		private static Vector2 ToGammaSpace(Vector2 v)
		{
			return default(Vector2);
		}

		private void CreateNoiseTexture()
		{
		}

		public HBAO()
			: base()
		{
		}
	}
}
