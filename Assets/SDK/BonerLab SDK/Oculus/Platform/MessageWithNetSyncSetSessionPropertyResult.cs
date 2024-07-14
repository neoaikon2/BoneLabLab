using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithNetSyncSetSessionPropertyResult : Message<NetSyncSetSessionPropertyResult>
	{
		public MessageWithNetSyncSetSessionPropertyResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override NetSyncSetSessionPropertyResult GetNetSyncSetSessionPropertyResult()
		{
			return null;
		}

		protected override NetSyncSetSessionPropertyResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
