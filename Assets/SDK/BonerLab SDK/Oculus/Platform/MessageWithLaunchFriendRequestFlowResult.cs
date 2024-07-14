using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchFriendRequestFlowResult : Message<LaunchFriendRequestFlowResult>
	{
		public MessageWithLaunchFriendRequestFlowResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult()
		{
			return null;
		}

		protected override LaunchFriendRequestFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
