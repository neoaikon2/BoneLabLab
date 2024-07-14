using System.Collections.Generic;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public sealed class Core
	{
		private static bool IsPlatformInitialized;

		public static bool LogMessages;

		public static string PlatformUninitializedError;

		public static bool IsInitialized()
		{
			return false;
		}

		internal static void ForceInitialized()
		{
		}

		private static string getAppID(string appId = null)
		{
			return null;
		}

		public static Request<PlatformInitialize> AsyncInitialize(string appId = null)
		{
			return null;
		}

		public static Request<PlatformInitialize> AsyncInitialize(string accessToken, Dictionary<InitConfigOptions, bool> initConfigOptions, string appId = null)
		{
			return null;
		}

		public static void Initialize(string appId = null)
		{
		}

		private static string GetAppIDFromConfig()
		{
			return null;
		}
	}
}
