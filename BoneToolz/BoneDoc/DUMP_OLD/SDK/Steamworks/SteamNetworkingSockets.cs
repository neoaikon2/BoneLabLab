using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamNetworkingSockets : SteamSharedClass<SteamNetworkingSockets>
	{
		private static readonly Dictionary<uint, SocketManager> SocketInterfaces;

		private static readonly Dictionary<uint, ConnectionManager> ConnectionInterfaces;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Connection, ConnectionInfo> OnConnectionStatusChanged;

		internal static ISteamNetworkingSockets Internal
		{
			get
			{
				return null;
			}
		}

		internal override void InitializeInterface(bool server)
		{
		}

		internal static SocketManager GetSocketManager(uint id)
		{
			return null;
		}

		internal static ConnectionManager GetConnectionManager(uint id)
		{
			return null;
		}

		internal void InstallEvents(bool server)
		{
		}

		private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data)
		{
		}

		public SteamNetworkingSockets()
			: base()
		{
		}
	}
}
