using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithProductList : Message<ProductList>
	{
		public MessageWithProductList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override ProductList GetProductList()
		{
			return null;
		}

		protected override ProductList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
