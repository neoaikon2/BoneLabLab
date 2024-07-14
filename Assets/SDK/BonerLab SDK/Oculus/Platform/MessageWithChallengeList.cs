using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithChallengeList : Message<ChallengeList>
	{
		public MessageWithChallengeList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override ChallengeList GetChallengeList()
		{
			return null;
		}

		protected override ChallengeList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
