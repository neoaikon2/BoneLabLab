using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithLaunchInvitePanelFlowResult : Message<LaunchInvitePanelFlowResult>
	{
		public MessageWithLaunchInvitePanelFlowResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override LaunchInvitePanelFlowResult GetLaunchInvitePanelFlowResult()
		{
			return null;
		}

		protected override LaunchInvitePanelFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
