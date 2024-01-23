using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamNetworkingUtils : SteamSharedClass<SteamNetworkingUtils>
	{
		private struct DebugMessage
		{
			public NetDebugOutput Type;

			public string Msg;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<NetDebugOutput, string> OnDebugOutput;

		private static ConcurrentQueue<DebugMessage> debugMessages;

		internal static ISteamNetworkingUtils Internal
		{
			get
			{
				return null;
			}
		}

		private static SteamNetworkingAvailability Status { set; get; }

		internal override void InitializeInterface(bool server)
		{
		}

		private static void InstallCallbacks(bool server)
		{
		}

		internal static void OutputDebugMessages()
		{
		}

		public SteamNetworkingUtils()
			: base()
		{
		}
	}
}
