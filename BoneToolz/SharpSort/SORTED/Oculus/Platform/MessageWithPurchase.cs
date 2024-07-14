using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPurchase : Message<Purchase>
	{
		public MessageWithPurchase(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override Purchase GetPurchase()
		{
			return null;
		}

		protected override Purchase GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
