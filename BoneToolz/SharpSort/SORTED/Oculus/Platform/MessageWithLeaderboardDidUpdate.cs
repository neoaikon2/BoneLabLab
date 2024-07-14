using System;

namespace Oculus.Platform
{
	public class MessageWithLeaderboardDidUpdate : Message<bool>
	{
		public MessageWithLeaderboardDidUpdate(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override bool GetLeaderboardDidUpdate()
		{
			return false;
		}

		protected override bool GetDataFromMessage(IntPtr c_message)
		{
			return false;
		}
	}
}
