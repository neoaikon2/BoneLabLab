using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworkingUtils : SteamInterface
	{
		internal ISteamNetworkingUtils(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamNetworkingUtils_v003();

		public override IntPtr GetGlobalInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, NetIdentity identity, IntPtr buf, uint cbBuf);

		internal void SteamNetworkingIdentity_ToString(NetIdentity identity, [Out] string buf)
		{
		}
	}
}
