using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAppDownloadProgressResult : Message<AppDownloadProgressResult>
	{
		public MessageWithAppDownloadProgressResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AppDownloadProgressResult GetAppDownloadProgressResult()
		{
			return null;
		}

		protected override AppDownloadProgressResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
