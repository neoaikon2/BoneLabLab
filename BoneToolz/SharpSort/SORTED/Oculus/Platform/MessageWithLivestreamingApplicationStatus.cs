using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLivestreamingApplicationStatus : Message<LivestreamingApplicationStatus>
	{
		public MessageWithLivestreamingApplicationStatus(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LivestreamingApplicationStatus GetLivestreamingApplicationStatus()
		{
			return null;
		}

		protected override LivestreamingApplicationStatus GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
