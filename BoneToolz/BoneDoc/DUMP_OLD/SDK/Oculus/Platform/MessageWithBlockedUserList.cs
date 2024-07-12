using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithBlockedUserList : Message<BlockedUserList>
	{
		public MessageWithBlockedUserList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override BlockedUserList GetBlockedUserList()
		{
			return null;
		}

		protected override BlockedUserList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
