using System;

namespace Steamworks
{
	internal class ISteamRemoteStorage : SteamInterface
	{
		internal ISteamRemoteStorage(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamRemoteStorage_v014();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
