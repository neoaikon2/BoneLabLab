using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct VRControllerState_t_Packed
	{
		public uint unPacketNum;

		public ulong ulButtonPressed;

		public ulong ulButtonTouched;

		public VRControllerAxis_t rAxis0;

		public VRControllerAxis_t rAxis1;

		public VRControllerAxis_t rAxis2;

		public VRControllerAxis_t rAxis3;

		public VRControllerAxis_t rAxis4;

		public VRControllerState_t_Packed(VRControllerState_t unpacked)
		{
			unPacketNum = 0u;
			ulButtonPressed = 0uL;
			ulButtonTouched = 0uL;
			rAxis0 = default(VRControllerAxis_t);
			rAxis1 = default(VRControllerAxis_t);
			rAxis2 = default(VRControllerAxis_t);
			rAxis3 = default(VRControllerAxis_t);
			rAxis4 = default(VRControllerAxis_t);
		}

		public void Unpack(ref VRControllerState_t unpacked)
		{
		}
	}
}
