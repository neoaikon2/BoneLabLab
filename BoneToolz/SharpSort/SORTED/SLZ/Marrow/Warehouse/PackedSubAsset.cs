using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public struct PackedSubAsset
	{
		public string subTitle;

		public MarrowAsset subAsset;

		public PackedSubAsset(string subTitle, MarrowAsset subAsset)
		{
			this.subTitle = null;
			this.subAsset = null;
		}
	}
}
