using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRCompositor
	{
		private IVRCompositor FnTable;

		internal CVRCompositor(IntPtr pInterface)
		{
		}

		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
		{
		}

		public ETrackingUniverseOrigin GetTrackingSpace()
		{
			return default(ETrackingUniverseOrigin);
		}

		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return default(EVRCompositorError);
		}

		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray)
		{
			return default(EVRCompositorError);
		}

		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose)
		{
			return default(EVRCompositorError);
		}

		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags)
		{
			return default(EVRCompositorError);
		}

		public void ClearLastSubmittedFrame()
		{
		}

		public void PostPresentHandoff()
		{
		}

		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo)
		{
			return false;
		}

		public uint GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames)
		{
			return 0u;
		}

		public float GetFrameTimeRemaining()
		{
			return 0f;
		}

		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes)
		{
		}

		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground)
		{
		}

		public HmdColor_t GetCurrentFadeColor(bool bBackground)
		{
			return default(HmdColor_t);
		}

		public void FadeGrid(float fSeconds, bool bFadeIn)
		{
		}

		public float GetCurrentGridAlpha()
		{
			return 0f;
		}

		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures)
		{
			return default(EVRCompositorError);
		}

		public void ClearSkyboxOverride()
		{
		}

		public void CompositorBringToFront()
		{
		}

		public void CompositorGoToBack()
		{
		}

		public void CompositorQuit()
		{
		}

		public bool IsFullscreen()
		{
			return false;
		}

		public uint GetCurrentSceneFocusProcess()
		{
			return 0u;
		}

		public uint GetLastFrameRenderer()
		{
			return 0u;
		}

		public bool CanRenderScene()
		{
			return false;
		}

		public void ShowMirrorWindow()
		{
		}

		public void HideMirrorWindow()
		{
		}

		public bool IsMirrorWindowVisible()
		{
			return false;
		}

		public void CompositorDumpImages()
		{
		}

		public bool ShouldAppRenderWithLowResources()
		{
			return false;
		}

		public void ForceInterleavedReprojectionOn(bool bOverride)
		{
		}

		public void ForceReconnectProcess()
		{
		}

		public void SuspendRendering(bool bSuspend)
		{
		}

		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView)
		{
			return default(EVRCompositorError);
		}

		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView)
		{
		}

		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle)
		{
			return default(EVRCompositorError);
		}

		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle)
		{
			return false;
		}

		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
		}

		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
		{
		}

		public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize)
		{
			return 0u;
		}

		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize)
		{
			return 0u;
		}

		public void SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode)
		{
		}

		public EVRCompositorError SubmitExplicitTimingData()
		{
			return default(EVRCompositorError);
		}
	}
}
