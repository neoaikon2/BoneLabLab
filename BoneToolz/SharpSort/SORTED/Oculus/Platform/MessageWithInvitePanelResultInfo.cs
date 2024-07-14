using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithInvitePanelResultInfo : Message<InvitePanelResultInfo>
	{
		public MessageWithInvitePanelResultInfo(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override InvitePanelResultInfo GetInvitePanelResultInfo()
		{
			return null;
		}

		protected override InvitePanelResultInfo GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
