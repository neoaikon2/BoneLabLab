namespace OVR.OpenVR
{
	public struct TrackedDevicePose_t
	{
		public HmdMatrix34_t mDeviceToAbsoluteTracking;

		public HmdVector3_t vVelocity;

		public HmdVector3_t vAngularVelocity;

		public ETrackingResult eTrackingResult;

		public bool bPoseIsValid;

		public bool bDeviceIsConnected;
	}
}
