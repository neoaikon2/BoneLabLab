using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Users
	{
		public static string GetLoggedInUserLocale()
		{
			return null;
		}

		public static Request<User> Get(ulong userID)
		{
			return null;
		}

		public static Request<string> GetAccessToken()
		{
			return null;
		}

		public static Request<BlockedUserList> GetBlockedUsers()
		{
			return null;
		}

		public static Request<User> GetLoggedInUser()
		{
			return null;
		}

		public static Request<UserList> GetLoggedInUserFriends()
		{
			return null;
		}

		public static Request<OrgScopedID> GetOrgScopedID(ulong userID)
		{
			return null;
		}

		public static Request<SdkAccountList> GetSdkAccounts()
		{
			return null;
		}

		public static Request<UserProof> GetUserProof()
		{
			return null;
		}

		public static Request<LaunchBlockFlowResult> LaunchBlockFlow(ulong userID)
		{
			return null;
		}

		public static Request<LaunchFriendRequestFlowResult> LaunchFriendRequestFlow(ulong userID)
		{
			return null;
		}

		public static Request<LaunchUnblockFlowResult> LaunchUnblockFlow(ulong userID)
		{
			return null;
		}

		public static Request<BlockedUserList> GetNextBlockedUserListPage(BlockedUserList list)
		{
			return null;
		}

		public static Request<UserList> GetNextUserListPage(UserList list)
		{
			return null;
		}

		public static Request<UserCapabilityList> GetNextUserCapabilityListPage(UserCapabilityList list)
		{
			return null;
		}
	}
}
