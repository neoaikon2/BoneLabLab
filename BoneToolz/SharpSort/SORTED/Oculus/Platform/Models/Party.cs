using System;

namespace Oculus.Platform.Models
{
	public class Party
	{
		public readonly ulong ID;

		public readonly UserList InvitedUsersOptional;

		[Obsolete("Deprecated in favor of InvitedUsersOptional")]
		public readonly UserList InvitedUsers;

		public readonly User LeaderOptional;

		[Obsolete("Deprecated in favor of LeaderOptional")]
		public readonly User Leader;

		public readonly UserList UsersOptional;

		[Obsolete("Deprecated in favor of UsersOptional")]
		public readonly UserList Users;

		public Party(IntPtr o)
		{
		}
	}
}
