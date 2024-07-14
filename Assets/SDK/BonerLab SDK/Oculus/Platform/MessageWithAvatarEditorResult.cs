using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAvatarEditorResult : Message<AvatarEditorResult>
	{
		public MessageWithAvatarEditorResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AvatarEditorResult GetAvatarEditorResult()
		{
			return null;
		}

		protected override AvatarEditorResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
