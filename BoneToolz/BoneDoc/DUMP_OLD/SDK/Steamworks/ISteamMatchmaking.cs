using System;

namespace Steamworks
{
	internal class ISteamMatchmaking : SteamInterface
	{
		internal ISteamMatchmaking(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamMatchmaking_v009();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, SteamId pSteamIDUser, IntPtr pvData, int cubData, ChatEntryType peChatEntryType);

		internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, SteamId pSteamIDUser, IntPtr pvData, int cubData, ChatEntryType peChatEntryType)
		{
			return default(int);
		}
	}
}
