using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithUser : Message<User>
	{
		public MessageWithUser(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override User GetUser()
		{
			return null;
		}

		protected override User GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
