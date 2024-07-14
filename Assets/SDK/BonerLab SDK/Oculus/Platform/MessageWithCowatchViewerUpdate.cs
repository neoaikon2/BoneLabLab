using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCowatchViewerUpdate : Message<CowatchViewerUpdate>
	{
		public MessageWithCowatchViewerUpdate(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override CowatchViewerUpdate GetCowatchViewerUpdate()
		{
			return null;
		}

		protected override CowatchViewerUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
