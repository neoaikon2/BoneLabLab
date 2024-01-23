using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamRemotePlay : SteamClientClass<SteamRemotePlay>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<RemotePlaySession> OnSessionConnected;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<RemotePlaySession> OnSessionDisconnected;

		internal override void InitializeInterface(bool server)
		{
		}

		internal void InstallEvents(bool server)
		{
		}

		public SteamRemotePlay()
			: base()
		{
		}
	}
}
