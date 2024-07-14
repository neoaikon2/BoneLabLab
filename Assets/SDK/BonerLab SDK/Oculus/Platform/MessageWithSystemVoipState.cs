using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithSystemVoipState : Message<SystemVoipState>
	{
		public MessageWithSystemVoipState(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override SystemVoipState GetSystemVoipState()
		{
			return null;
		}

		protected override SystemVoipState GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
