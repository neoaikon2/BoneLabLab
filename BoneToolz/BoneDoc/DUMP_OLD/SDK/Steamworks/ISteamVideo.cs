using System;

namespace Steamworks
{
	internal class ISteamVideo : SteamInterface
	{
		internal ISteamVideo(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamVideo_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
