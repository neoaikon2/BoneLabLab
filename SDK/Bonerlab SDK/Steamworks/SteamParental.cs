using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamParental : SteamSharedClass<SteamParental>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnSettingsChanged;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents(bool server)
		{
		}

		public SteamParental()
			: base()
		{
		}
	}
}
