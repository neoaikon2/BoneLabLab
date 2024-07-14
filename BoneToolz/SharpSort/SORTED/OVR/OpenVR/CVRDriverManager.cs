using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRDriverManager
	{
		private IVRDriverManager FnTable;

		internal CVRDriverManager(IntPtr pInterface)
		{
		}

		public uint GetDriverCount()
		{
			return 0u;
		}

		public uint GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize)
		{
			return 0u;
		}

		public ulong GetDriverHandle(string pchDriverName)
		{
			return 0uL;
		}
	}
}
