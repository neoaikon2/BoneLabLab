using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithDestinationList : Message<DestinationList>
	{
		public MessageWithDestinationList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override DestinationList GetDestinationList()
		{
			return null;
		}

		protected override DestinationList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
