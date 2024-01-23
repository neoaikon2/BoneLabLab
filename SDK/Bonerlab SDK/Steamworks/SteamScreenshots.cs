using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamScreenshots : SteamClientClass<SteamScreenshots>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnScreenshotRequested;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Screenshot> OnScreenshotReady;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Result> OnScreenshotFailed;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents()
		{
		}

		public SteamScreenshots()
			: base()
		{
		}
	}
}
