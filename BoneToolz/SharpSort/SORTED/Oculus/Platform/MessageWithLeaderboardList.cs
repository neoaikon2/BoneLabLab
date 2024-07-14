using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLeaderboardList : Message<LeaderboardList>
	{
		public MessageWithLeaderboardList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LeaderboardList GetLeaderboardList()
		{
			return null;
		}

		protected override LeaderboardList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
