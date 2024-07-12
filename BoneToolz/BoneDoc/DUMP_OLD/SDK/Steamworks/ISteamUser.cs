using System;

namespace Steamworks
{
	internal class ISteamUser : SteamInterface
	{
		internal ISteamUser(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamUser_v020();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern SteamId _GetSteamID(IntPtr self);

		internal SteamId GetSteamID()
		{
			return default(SteamId);
		}

		private static extern uint _GetVoiceOptimalSampleRate(IntPtr self);

		internal uint GetVoiceOptimalSampleRate()
		{
			return default(uint);
		}
	}
}
