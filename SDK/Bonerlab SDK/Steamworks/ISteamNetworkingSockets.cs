using System;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamNetworkingSockets : SteamInterface
	{
		internal ISteamNetworkingSockets(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamNetworkingSockets_v008();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_v008();

		public override IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern Result _AcceptConnection(IntPtr self, Connection hConn);

		internal Result AcceptConnection(Connection hConn)
		{
			return default(Result);
		}

		private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger);

		internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			return default(bool);
		}

		private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup);

		internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}
	}
}
