using Steamworks.Data;

namespace Steamworks
{
	internal static class SteamAPI
	{
		internal static class Native
		{
			public static extern bool SteamAPI_Init();

			public static extern void SteamAPI_Shutdown();

			public static extern HSteamPipe SteamAPI_GetHSteamPipe();
		}

		internal static bool Init()
		{
			return default(bool);
		}

		internal static void Shutdown()
		{
		}

		internal static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}
	}
}
