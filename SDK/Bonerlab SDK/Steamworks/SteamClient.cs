using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Steamworks
{
	public static class SteamClient
	{
		private static bool initialized;

		private static readonly List<SteamClass> openInterfaces;

		public static bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public static SteamId SteamId
		{
			get
			{
				return default(SteamId);
			}
		}

		public static string Name
		{
			get
			{
				return null;
			}
		}

		internal static AppId AppId { set; get; }

		public static void Init(uint appid, bool asyncCallbacks = true)
		{
		}

		internal static void AddInterface<T>() where T : SteamClass, new()
		{
		}

		internal static void ShutdownInterfaces()
		{
		}

		public static void Shutdown()
		{
		}

		internal static void Cleanup()
		{
		}
	}
}
