using System;

namespace Steamworks
{
	internal class ISteamInput : SteamInterface
	{
		internal ISteamInput(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamInput_v001();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
