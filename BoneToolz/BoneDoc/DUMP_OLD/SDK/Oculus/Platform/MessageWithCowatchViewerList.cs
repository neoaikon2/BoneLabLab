using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCowatchViewerList : Message<CowatchViewerList>
	{
		public MessageWithCowatchViewerList(IntPtr c_message)
			: base(c_message)
		{
		}

		public override CowatchViewerList GetCowatchViewerList()
		{
			return null;
		}

		protected override CowatchViewerList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
