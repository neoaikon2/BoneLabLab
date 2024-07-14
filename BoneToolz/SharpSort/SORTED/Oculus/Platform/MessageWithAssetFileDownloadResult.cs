using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetFileDownloadResult : Message<AssetFileDownloadResult>
	{
		public MessageWithAssetFileDownloadResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AssetFileDownloadResult GetAssetFileDownloadResult()
		{
			return null;
		}

		protected override AssetFileDownloadResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
