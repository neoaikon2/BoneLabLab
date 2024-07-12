using System;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamUtils : SteamInterface
	{
		internal ISteamUtils(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamUtils_v009();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		internal static extern IntPtr SteamAPI_SteamGameServerUtils_v009();

		public override IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, bool pbFailed);

		internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, bool pbFailed)
		{
			return default(bool);
		}

		private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, bool pbFailed);

		internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, bool pbFailed)
		{
			return default(bool);
		}
	}
}
