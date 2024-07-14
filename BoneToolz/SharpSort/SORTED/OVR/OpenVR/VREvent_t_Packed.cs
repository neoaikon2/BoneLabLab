using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct VREvent_t_Packed
	{
		public uint eventType;

		public uint trackedDeviceIndex;

		public float eventAgeSeconds;

		public VREvent_Data_t data;

		public VREvent_t_Packed(VREvent_t unpacked)
		{
			eventType = 0u;
			trackedDeviceIndex = 0u;
			eventAgeSeconds = 0f;
			data = default(VREvent_Data_t);
		}

		public void Unpack(ref VREvent_t unpacked)
		{
		}
	}
}
