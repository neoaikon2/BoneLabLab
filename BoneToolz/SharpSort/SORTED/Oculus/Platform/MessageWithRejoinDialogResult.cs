using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithRejoinDialogResult : Message<RejoinDialogResult>
	{
		public MessageWithRejoinDialogResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override RejoinDialogResult GetRejoinDialogResult()
		{
			return null;
		}

		protected override RejoinDialogResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
