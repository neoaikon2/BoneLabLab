using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAppDownloadResult : Message<AppDownloadResult>
	{
		public MessageWithAppDownloadResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AppDownloadResult GetAppDownloadResult()
		{
			return null;
		}

		protected override AppDownloadResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
