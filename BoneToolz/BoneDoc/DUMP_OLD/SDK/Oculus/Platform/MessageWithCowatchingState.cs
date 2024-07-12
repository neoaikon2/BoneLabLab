using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithCowatchingState : Message<CowatchingState>
	{
		public MessageWithCowatchingState(IntPtr c_message)
			: base(c_message)
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
