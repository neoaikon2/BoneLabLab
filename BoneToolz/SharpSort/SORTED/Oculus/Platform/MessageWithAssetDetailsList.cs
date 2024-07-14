using System;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class MessageWithAssetDetailsList : Message<AssetDetailsList>
	{
		public MessageWithAssetDetailsList(IntPtr c_message)
			: base((IntPtr)0)
		{
		}

		public override AssetDetailsList GetAssetDetailsList()
		{
			return null;
		}

		protected override AssetDetailsList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
}
