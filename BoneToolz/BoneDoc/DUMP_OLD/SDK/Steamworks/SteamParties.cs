using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamParties : SteamClientClass<SteamParties>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnBeaconLocationsUpdated;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnActiveBeaconsUpdated;

		internal override void InitializeInterface(bool server)
		{
		}

		internal void InstallEvents(bool server)
		{
		}

		public SteamParties()
			: base()
		{
		}
	}
}
