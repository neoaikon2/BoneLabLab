using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithParty : Message<Party>
	{
		public MessageWithParty(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override Party GetParty()
		{
			return null;
		}

		protected override Party GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
