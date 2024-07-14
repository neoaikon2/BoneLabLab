using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithChallenge : Message<Challenge>
	{
		public MessageWithChallenge(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override Challenge GetChallenge()
		{
			return null;
		}

		protected override Challenge GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
