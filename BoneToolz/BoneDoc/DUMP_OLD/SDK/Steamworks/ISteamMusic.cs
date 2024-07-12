using System;

namespace Steamworks
{
	internal class ISteamMusic : SteamInterface
	{
		internal ISteamMusic(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamMusic_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
