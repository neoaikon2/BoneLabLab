using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLivestreamingStartResult : Message<LivestreamingStartResult>
	{
		public MessageWithLivestreamingStartResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LivestreamingStartResult GetLivestreamingStartResult()
		{
			return null;
		}

		protected override LivestreamingStartResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
