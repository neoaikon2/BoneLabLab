using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamVideo : SteamClientClass<SteamVideo>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnBroadcastStarted;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<BroadcastUploadResult> OnBroadcastStopped;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents()
		{
		}

		public SteamVideo()
			: base()
		{
		}
	}
}
