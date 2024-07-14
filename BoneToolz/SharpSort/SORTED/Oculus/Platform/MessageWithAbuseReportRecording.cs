using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAbuseReportRecording : Message<AbuseReportRecording>
	{
		public MessageWithAbuseReportRecording(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AbuseReportRecording GetAbuseReportRecording()
		{
			return null;
		}

		protected override AbuseReportRecording GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
