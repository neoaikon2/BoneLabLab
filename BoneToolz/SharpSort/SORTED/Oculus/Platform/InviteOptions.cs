using System;

namespace Oculus.Platform
{
	public class InviteOptions
	{
		private IntPtr Handle;

		public void AddSuggestedUser(ulong userID)
		{
		}

		public void ClearSuggestedUsers()
		{
		}

		public static explicit operator IntPtr(InviteOptions options)
		{
			return (IntPtr)0;
		}

		~InviteOptions()
		{
		}
	}
}
