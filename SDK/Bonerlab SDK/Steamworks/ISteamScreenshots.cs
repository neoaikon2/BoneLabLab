using System;

namespace Steamworks
{
	internal class ISteamScreenshots : SteamInterface
	{
		internal ISteamScreenshots(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamScreenshots_v003();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
