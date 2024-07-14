using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetDetails : Message<AssetDetails>
	{
		public MessageWithAssetDetails(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AssetDetails GetAssetDetails()
		{
			return null;
		}

		protected override AssetDetails GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
