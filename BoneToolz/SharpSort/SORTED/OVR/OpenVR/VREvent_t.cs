namespace OVR.OpenVR
{
	public struct VREvent_t
	{
		public uint eventType;

		public uint trackedDeviceIndex;

		public float eventAgeSeconds;

		public VREvent_Data_t data;
	}
}
