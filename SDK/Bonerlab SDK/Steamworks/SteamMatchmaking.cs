using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamMatchmaking : SteamClientClass<SteamMatchmaking>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Friend, Lobby> OnLobbyInvite;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Lobby> OnLobbyEntered;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Result, Lobby> OnLobbyCreated;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, uint, ushort, SteamId> OnLobbyGameCreated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Lobby> OnLobbyDataChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, Friend> OnLobbyMemberDataChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, Friend> OnLobbyMemberJoined;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, Friend> OnLobbyMemberLeave;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, Friend> OnLobbyMemberDisconnected;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, Friend, Friend> OnLobbyMemberKicked;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Lobby, Friend, Friend> OnLobbyMemberBanned;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<Lobby, Friend, string> OnChatMessage;

		internal static ISteamMatchmaking Internal
		{
			get
			{
				return null;
			}
		}

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents()
		{
		}

		private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback)
		{
		}

		public SteamMatchmaking()
			: base()
		{
		}
	}
}
