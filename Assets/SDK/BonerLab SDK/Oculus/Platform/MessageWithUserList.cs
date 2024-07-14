using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUserList : Message<UserList>
	{
		public MessageWithUserList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override UserList GetUserList()
		{
			return null;
		}

		protected override UserList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
