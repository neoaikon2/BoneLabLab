using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamUtils : SteamSharedClass<SteamUtils>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnIpCountryChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int> OnLowBatteryPower;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnSteamShutdown;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> OnGamepadTextInputDismissed;

		private static NotificationPosition overlayNotificationPosition;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents(bool server)
		{
		}

		private static void SteamClosed()
		{
		}

		public SteamUtils()
			: base()
		{
		}
	}
}
