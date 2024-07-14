using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCowatchingState : Message<CowatchingState>
	{
		public MessageWithCowatchingState(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override CowatchingState GetCowatchingState()
		{
			return null;
		}

		protected override CowatchingState GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
