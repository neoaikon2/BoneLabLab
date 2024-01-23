using System;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamNetworking : SteamSharedClass<SteamNetworking>
	{
		public static Action<SteamId> OnP2PSessionRequest;

		public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed;

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents(bool server)
		{
		}

		public SteamNetworking()
			: base()
		{
		}
	}
}
