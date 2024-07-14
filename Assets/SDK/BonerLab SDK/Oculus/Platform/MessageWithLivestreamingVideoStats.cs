using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLivestreamingVideoStats : Message<LivestreamingVideoStats>
	{
		public MessageWithLivestreamingVideoStats(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LivestreamingVideoStats GetLivestreamingVideoStats()
		{
			return null;
		}

		protected override LivestreamingVideoStats GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
