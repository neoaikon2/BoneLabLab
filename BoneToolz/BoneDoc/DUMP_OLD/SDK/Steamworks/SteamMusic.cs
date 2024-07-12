using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamMusic : SteamClientClass<SteamMusic>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnPlaybackChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<float> OnVolumeChanged;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents()
		{
		}

		public SteamMusic()
			: base()
		{
		}
	}
}
