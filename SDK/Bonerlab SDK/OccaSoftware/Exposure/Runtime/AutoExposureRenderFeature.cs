using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace OccaSoftware.Exposure.Runtime
{
	public class AutoExposureRenderFeature : ScriptableRendererFeature
	{
		private class AutoExposureRenderPass : ScriptableRenderPass
		{
			private struct ConstantData
			{
				public float evMin;

				public float evMax;

				public float evCompensation;

				public int adaptationMode;

				public float darkToLightInterp;

				public float lightToDarkInterp;

				public float deltaTime;

				public uint screenSizeX;

				public uint screenSizeY;

				public int isFirstFrame;

				public int meteringMaskMode;

				public float meteringProceduralFalloff;

				public ConstantData(float evMin, float evMax, float evCompensation, int adaptationMode, float darkToLightInterp, float lightToDarkInterp, float deltaTime, uint screenSizeX, uint screenSizeY, int isFirstFrame, int meteringMaskMode, float meteringProceduralFalloff)
				{
					this.meteringProceduralFalloff = default(float);
					this.meteringMaskMode = default(int);
					this.isFirstFrame = default(int);
					this.screenSizeY = default(uint);
					this.screenSizeX = default(uint);
					this.deltaTime = default(float);
					this.lightToDarkInterp = default(float);
					this.darkToLightInterp = default(float);
					this.adaptationMode = default(int);
					this.evCompensation = default(float);
					this.evMax = default(float);
					this.evMin = default(float);
				}
			}

			private const string cmdBufferName = "AEPass";

			private const string shaderName = "os-AutoExposureCompute";

			private ComputeShader shader;

			private ComputeBuffer constDataBuffer;

			private int mainKernel;

			private int updateKernel;

			private int rtKernel;

			private bool isFirst;

			private uint threadGroupSizeX;

			private uint threadGroupSizeY;

			private RenderTargetHandle aeHandle;

			private AutoExposure autoExposure;

			private Dictionary<Camera, ComputeBuffer> camBufferPairs;

			public bool RegisterAutoExposureStackComponent()
			{
				return default(bool);
			}

			public bool LoadComputeShader()
			{
				return default(bool);
			}

			private void OnAssemblyReload()
			{
			}

			public void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			public void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}

			public override void OnCameraCleanup(CommandBuffer cmd)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				throw new System.NotImplementedException();
			}

			public AutoExposureRenderPass()
				: base()
			{
			}
		}

		private AutoExposureRenderPass autoExposureRenderPass;

		public override void Create()
		{
		}

		public void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			throw new System.NotImplementedException();
		}

		public AutoExposureRenderFeature()
			: base()
		{
		}
	}
}
