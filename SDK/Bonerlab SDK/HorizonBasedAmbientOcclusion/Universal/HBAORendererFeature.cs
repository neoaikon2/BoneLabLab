using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace HorizonBasedAmbientOcclusion.Universal
{
	public class HBAORendererFeature : ScriptableRendererFeature
	{
		private class HBAORenderPass : ScriptableRenderPass
		{
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

				public const int Debug_ViewNormals = 10;
			}

			private static class ShaderProperties
			{
				public static int mainTex;

				public static int inputTex;

				public static int hbaoTex;

				public static int tempTex;

				public static int tempTex2;

				public static int noiseTex;

				public static int depthTex;

				public static int normalsTex;

				public static int ssaoTex;

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

				public static int historyBufferRTHandleScale;

				static ShaderProperties()
				{
				}

				public static string GetOrthographicProjectionKeyword(bool orthographic)
				{
					return null;
				}

				public static string GetDirectionsKeyword(HBAO.Quality quality)
				{
					return null;
				}

				public static string GetStepsKeyword(HBAO.Quality quality)
				{
					return null;
				}

				public static string GetNoiseKeyword(HBAO.NoiseType noiseType)
				{
					return null;
				}

				public static string GetDeinterleavingKeyword(HBAO.Deinterleaving deinterleaving)
				{
					return null;
				}

				public static string GetDebugKeyword(HBAO.DebugMode debugMode)
				{
					return null;
				}

				public static string GetMultibounceKeyword(bool useMultiBounce, bool litAoModeEnabled)
				{
					return null;
				}

				public static string GetOffscreenSamplesContributionKeyword(float offscreenSamplesContribution)
				{
					return null;
				}

				public static string GetPerPixelNormalsKeyword(HBAO.PerPixelNormals perPixelNormals)
				{
					return null;
				}

				public static string GetBlurRadiusKeyword(HBAO.BlurType blurType)
				{
					return null;
				}

				public static string GetVarianceClippingKeyword(HBAO.VarianceClipping varianceClipping)
				{
					return null;
				}

				public static string GetColorBleedingKeyword(bool colorBleedingEnabled, bool litAoModeEnabled)
				{
					return null;
				}

				public static string GetModeKeyword(HBAO.Mode mode)
				{
					return null;
				}
			}

			private static class MersenneTwister
			{
				public static float[] Numbers;
			}

			private class CameraHistoryBuffers
			{
				public CameraData cameraData { get; set; }

				public BufferedRTHandleSystem historyRTSystem { get; set; }

				public int frameCount { get; set; }

				public int lastRenderedFrame { get; set; }

				public CameraHistoryBuffers()
					: base()
				{
				}
			}

			private enum HistoryBufferType
			{
				AmbientOcclusion = 0,
				ColorBleeding = 1
			}

			public HBAO hbao;

			private static readonly Vector2[] s_jitter;

			private static readonly float[] s_temporalRotations;

			private static readonly float[] s_temporalOffsets;

			private HBAO.Resolution? m_PreviousResolution;

			private HBAO.NoiseType? m_PreviousNoiseType;

			private bool m_PreviousColorBleedingEnabled;

			private string[] m_ShaderKeywords;

			private RenderTargetIdentifier[] m_RtsDepth;

			private RenderTargetIdentifier[] m_RtsNormals;

			private List<CameraHistoryBuffers> m_CameraHistoryBuffers;

			private Material material { get; set; }

			private RenderTargetIdentifier source { get; set; }

			private CameraData cameraData { get; set; }

			private RenderTextureDescriptor sourceDesc { get; set; }

			private RenderTextureDescriptor aoDesc { get; set; }

			private RenderTextureDescriptor deinterleavedDepthDesc { get; set; }

			private RenderTextureDescriptor deinterleavedNormalsDesc { get; set; }

			private RenderTextureDescriptor deinterleavedAoDesc { get; set; }

			private RenderTextureDescriptor reinterleavedAoDesc { get; set; }

			private RenderTextureFormat colorFormat { get; set; }

			private GraphicsFormat graphicsColorFormat { get; set; }

			private RenderTextureFormat depthFormat { get; set; }

			private RenderTextureFormat normalsFormat { get; set; }

			private bool motionVectorsSupported { get; set; }

			private Texture2D noiseTex { get; set; }

			private int numberOfEyes { get; set; }

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

			public void FillSupportedRenderTextureFormats()
			{
			}

			public void Setup(Shader shader, ScriptableRenderer renderer, RenderingData renderingData)
			{
			}

			/*public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}*/

			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			/*public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}*/

			public override void FrameCleanup(CommandBuffer cmd)
			{
			}

			public void Cleanup()
			{
			}

			private void FetchVolumeComponent()
			{
			}

			private void FetchRenderParameters(RenderTextureDescriptor cameraTextureDesc)
			{
			}

			private RTHandle HistoryBufferAllocator(RTHandleSystem rtHandleSystem, int frameIndex)
			{
				return null;
			}

			private void AllocCameraHistoryBuffers(CameraHistoryBuffers buffers)
			{
			}

			private void ReleaseCameraHistoryBuffers(CameraHistoryBuffers buffers)
			{
			}

			private CameraHistoryBuffers GetCurrentCameraHistoryBuffers()
			{
				return null;
			}

			private void CopySource(CommandBuffer cmd)
			{
			}

			private void AO(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			private void DeinterleavedAO(CommandBuffer cmd)
			{
			}

			private void Blur(CommandBuffer cmd)
			{
			}

			private void TemporalFilter(CommandBuffer cmd, CameraHistoryBuffers buffers)
			{
			}

			private void Composite(CommandBuffer cmd)
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

			private RenderTextureDescriptor GetStereoCompatibleDescriptor(int width, int height, RenderTextureFormat format = RenderTextureFormat.Default, int depthBufferBits = 0, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
			{
				return default(RenderTextureDescriptor);
			}

			public void BlitFullscreenMesh(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0)
			{
			}

			public void BlitFullscreenMesh(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Rect viewportRect, Material material, int passIndex = 0)
			{
			}

			public void BlitFullscreenMesh(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Material material, int passIndex = 0)
			{
			}

			public void BlitFullscreenMesh(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Rect viewportRect, Material material, int passIndex = 0)
			{
			}

			public void BlitFullscreenMeshWithClear(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, Material material, Color clearColor, int passIndex = 0)
			{
			}

			public void BlitFullscreenMeshWithClear(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, Color clearColor, int passIndex = 0)
			{
			}

			private Vector2 AdjustBrightnessMaskToGammaSpace(Vector2 v)
			{
				return default(Vector2);
			}

			private float ToGammaSpace(float v)
			{
				return default(float);
			}

			private Vector2 ToGammaSpace(Vector2 v)
			{
				return default(Vector2);
			}

			private void CreateNoiseTexture()
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				throw new System.NotImplementedException();
			}

			public HBAORenderPass()
				: base()
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private Shader shader;

		private HBAORenderPass m_HBAORenderPass;

		private void OnDisable()
		{
		}

		public override void Create()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			throw new System.NotImplementedException();
		}

		/*public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}*/

		public HBAORendererFeature()
			: base()
		{
		}
	}
}
