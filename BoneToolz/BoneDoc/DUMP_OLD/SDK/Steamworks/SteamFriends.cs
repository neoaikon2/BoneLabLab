using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamFriends : SteamClientClass<SteamFriends>
	{
		private static Dictionary<string, string> richPresence;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Friend, string, string> OnChatMessage;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Friend> OnPersonaStateChange;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Friend, string> OnGameRichPresenceJoinRequested;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<bool> OnGameOverlayActivated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string, string> OnGameServerChangeRequested;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Lobby, SteamId> OnGameLobbyJoinRequested;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Friend> OnFriendRichPresenceUpdate;

		internal static ISteamFriends Internal
		{
			get
			{
				return null;
			}
		}

		internal override void InitializeInterface(bool server)
		{
		}

		internal void InstallEvents()
		{
		}

		private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data)
		{
		}

		public SteamFriends()
			: base()
		{
		}
	}
}
