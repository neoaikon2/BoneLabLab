using System;
using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(2, Pack = 1, Size = 18)]
	public struct NetAddress
	{
		internal struct IPV4
		{
			internal ulong m_8zeros;

			internal ushort m_0000;

			internal ushort m_ffff;

			internal byte ip0;

			internal byte ip1;

			internal byte ip2;

			internal byte ip3;
		}

		internal IPV4 ip;

		internal ushort port;

		internal static extern void InternalToString(NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort);

		public override string ToString()
		{
			return null;
		}
	}
}
