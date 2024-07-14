using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct IVRExtendedDisplay
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);

		internal _GetWindowBounds GetWindowBounds;

		internal _GetEyeOutputViewport GetEyeOutputViewport;

		internal _GetDXGIOutputInfo GetDXGIOutputInfo;
	}
}
