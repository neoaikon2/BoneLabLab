using System;

namespace Steamworks
{
	internal class ISteamNetworking : SteamInterface
	{
		internal ISteamNetworking(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamNetworking_v006();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006();

		public override IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}
	}
}
