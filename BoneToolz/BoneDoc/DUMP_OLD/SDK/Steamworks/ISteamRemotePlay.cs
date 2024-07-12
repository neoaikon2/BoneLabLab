using System;

namespace Steamworks
{
	internal class ISteamRemotePlay : SteamInterface
	{
		internal ISteamRemotePlay(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamRemotePlay_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
