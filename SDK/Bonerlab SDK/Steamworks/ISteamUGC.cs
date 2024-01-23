using System;

namespace Steamworks
{
	internal class ISteamUGC : SteamInterface
	{
		internal ISteamUGC(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamUGC_v014();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		internal static extern IntPtr SteamAPI_SteamGameServerUGC_v014();

		public override IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
