using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRResources
	{
		private IVRResources FnTable;

		internal CVRResources(IntPtr pInterface)
		{
		}

		public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen)
		{
			return 0u;
		}

		public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen)
		{
			return 0u;
		}
	}
}
