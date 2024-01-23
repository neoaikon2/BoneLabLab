using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamUser : SteamClientClass<SteamUser>
	{
		private static Dictionary<string, string> richPresence;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnSteamServersConnected;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnSteamServerConnectFailure;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnSteamServersDisconnected;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnClientGameServerDeny;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnLicensesUpdated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<AppId, ulong, bool> OnMicroTxnAuthorizationResponse;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string> OnGameWebCallback;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<DurationControl> OnDurationControl;

		private static byte[] readBuffer;

		private static uint sampleRate;

		internal static ISteamUser Internal
		{
			get
			{
				return null;
			}
		}

		public static uint SampleRate
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public static uint OptimalSampleRate
		{
			get
			{
				return default(uint);
			}
		}

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents()
		{
		}

		public SteamUser()
			: base()
		{
		}
	}
}
