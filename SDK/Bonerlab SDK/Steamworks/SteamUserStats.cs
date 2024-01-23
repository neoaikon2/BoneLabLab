using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamUserStats : SteamClientClass<SteamUserStats>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<string, int> OnAchievementIconFetched;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<SteamId, Result> OnUserStatsReceived;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Result> OnUserStatsStored;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Achievement, int, int> OnAchievementProgress;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<SteamId> OnUserStatsUnloaded;

		internal static ISteamUserStats Internal
		{
			get
			{
				return null;
			}
		}

		internal static bool StatsRecieved { set; get; }

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents()
		{
		}

		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		[DebuggerStepThrough]
		public static Task<Leaderboard?> FindLeaderboardAsync(string name)
		{
			return null;
		}

		public SteamUserStats()
			: base()
		{
		}
	}
}
