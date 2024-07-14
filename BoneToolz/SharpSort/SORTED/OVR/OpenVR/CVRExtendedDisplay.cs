using System;

namespace OVR.OpenVR
{
	public class CVRExtendedDisplay
	{
		private IVRExtendedDisplay FnTable;

		internal CVRExtendedDisplay(IntPtr pInterface)
		{
		}

		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight)
		{
		}

		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight)
		{
		}

		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex)
		{
		}
	}
}
