using System;

namespace Steamworks
{
	internal class ISteamParties : SteamInterface
	{
		internal ISteamParties(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamParties_v002();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
