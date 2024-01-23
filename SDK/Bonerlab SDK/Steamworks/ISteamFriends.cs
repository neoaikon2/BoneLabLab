using System;

namespace Steamworks
{
	internal class ISteamFriends : SteamInterface
	{
		internal ISteamFriends(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamFriends_v017();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern Utf8StringPointer _GetPersonaName(IntPtr self);

		internal string GetPersonaName()
		{
			return null;
		}

		private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend);

		internal string GetFriendPersonaName(SteamId steamIDFriend)
		{
			return null;
		}

		private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly);

		internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ChatEntryType peChatEntryType);

		internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ChatEntryType peChatEntryType)
		{
			return default(int);
		}
	}
}
