using System;

namespace Steamworks
{
	internal class ISteamMatchmakingServers : SteamInterface
	{
		internal ISteamMatchmakingServers(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
