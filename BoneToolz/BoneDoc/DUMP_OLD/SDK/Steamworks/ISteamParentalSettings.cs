using System;

namespace Steamworks
{
	internal class ISteamParentalSettings : SteamInterface
	{
		internal ISteamParentalSettings(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamParentalSettings_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
