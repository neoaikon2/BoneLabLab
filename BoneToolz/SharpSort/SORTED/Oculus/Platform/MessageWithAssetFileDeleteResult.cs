using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetFileDeleteResult : Message<AssetFileDeleteResult>
	{
		public MessageWithAssetFileDeleteResult(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AssetFileDeleteResult GetAssetFileDeleteResult()
		{
			return null;
		}

		protected override AssetFileDeleteResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
