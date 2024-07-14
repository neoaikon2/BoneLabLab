namespace OVR.OpenVR
{
	public struct Compositor_FrameTiming
	{
		public uint m_nSize;

		public uint m_nFrameIndex;

		public uint m_nNumFramePresents;

		public uint m_nNumMisPresented;

		public uint m_nNumDroppedFrames;

		public uint m_nReprojectionFlags;

		public double m_flSystemTimeInSeconds;

		public float m_flPreSubmitGpuMs;

		public float m_flPostSubmitGpuMs;

		public float m_flTotalRenderGpuMs;

		public float m_flCompositorRenderGpuMs;

		public float m_flCompositorRenderCpuMs;

		public float m_flCompositorIdleCpuMs;

		public float m_flClientFrameIntervalMs;

		public float m_flPresentCallCpuMs;

		public float m_flWaitForPresentCpuMs;

		public float m_flSubmitFrameMs;

		public float m_flWaitGetPosesCalledMs;

		public float m_flNewPosesReadyMs;

		public float m_flNewFrameReadyMs;

		public float m_flCompositorUpdateStartMs;

		public float m_flCompositorUpdateEndMs;

		public float m_flCompositorRenderStartMs;

		public TrackedDevicePose_t m_HmdPose;
	}
}
