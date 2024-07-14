using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithNetSyncConnection : Message<NetSyncConnection>
	{
		public MessageWithNetSyncConnection(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override NetSyncConnection GetNetSyncConnection()
		{
			return null;
		}

		protected override NetSyncConnection GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
