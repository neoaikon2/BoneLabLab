using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamUGC : SteamSharedClass<SteamUGC>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Result> OnDownloadItemResult;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents(bool server)
		{
		}

		public SteamUGC()
			: base()
		{
		}
	}
}
