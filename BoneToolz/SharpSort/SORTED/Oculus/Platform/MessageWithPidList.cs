using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithPidList : Message<PidList>
	{
		public MessageWithPidList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override PidList GetPidList()
		{
			return null;
		}

		protected override PidList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
