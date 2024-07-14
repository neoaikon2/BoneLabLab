namespace OVR.OpenVR
{
	public struct CameraVideoStreamFrameHeader_t
	{
		public EVRTrackedCameraFrameType eFrameType;

		public uint nWidth;

		public uint nHeight;

		public uint nBytesPerPixel;

		public uint nFrameSequence;

		public TrackedDevicePose_t standingTrackedDevicePose;
	}
}
