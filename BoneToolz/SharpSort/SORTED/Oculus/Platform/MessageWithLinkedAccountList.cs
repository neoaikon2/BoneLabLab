using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLinkedAccountList : Message<LinkedAccountList>
	{
		public MessageWithLinkedAccountList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LinkedAccountList GetLinkedAccountList()
		{
			return null;
		}

		protected override LinkedAccountList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
