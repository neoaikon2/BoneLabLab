using System;

namespace Steamworks
{
	internal class ISteamApps : SteamInterface
	{
		internal ISteamApps(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamApps_v008();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		internal static extern IntPtr SteamAPI_SteamGameServerApps_v008();

		public override IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
