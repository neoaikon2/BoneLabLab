using System.Runtime.InteropServices;
using System.Text;

namespace OVR.OpenVR
{
	public struct IVRDriverManager
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetDriverCount();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _GetDriverHandle(string pchDriverName);

		internal _GetDriverCount GetDriverCount;

		internal _GetDriverName GetDriverName;

		internal _GetDriverHandle GetDriverHandle;
	}
}
