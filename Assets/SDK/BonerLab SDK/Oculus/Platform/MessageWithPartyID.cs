using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPartyID : Message<PartyID>
	{
		public MessageWithPartyID(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override PartyID GetPartyID()
		{
			return null;
		}

		protected override PartyID GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
