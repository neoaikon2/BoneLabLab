using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithGroupPresenceJoinIntent : Message<GroupPresenceJoinIntent>
	{
		public MessageWithGroupPresenceJoinIntent(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override GroupPresenceJoinIntent GetGroupPresenceJoinIntent()
		{
			return null;
		}

		protected override GroupPresenceJoinIntent GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
