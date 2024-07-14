using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetFileDownloadUpdate : Message<AssetFileDownloadUpdate>
	{
		public MessageWithAssetFileDownloadUpdate(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AssetFileDownloadUpdate GetAssetFileDownloadUpdate()
		{
			return null;
		}

		protected override AssetFileDownloadUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
