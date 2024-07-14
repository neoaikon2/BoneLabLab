using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithShareMediaResult : Message<ShareMediaResult>
	{
		public MessageWithShareMediaResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override ShareMediaResult GetShareMediaResult()
		{
			return null;
		}

		protected override ShareMediaResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
