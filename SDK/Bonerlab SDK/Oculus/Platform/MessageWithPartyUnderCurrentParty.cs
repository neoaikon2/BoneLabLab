using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPartyUnderCurrentParty : Message<Party>
	{
		public MessageWithPartyUnderCurrentParty(IntPtr c_message)
			: base(c_message)
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
