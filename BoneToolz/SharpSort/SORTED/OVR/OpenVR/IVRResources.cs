using System.Runtime.InteropServices;
using System.Text;

namespace OVR.OpenVR
{
	public struct IVRResources
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen);

		internal _LoadSharedResource LoadSharedResource;

		internal _GetResourceFullPath GetResourceFullPath;
	}
}
