using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class BoneTagReference : DataCardReference<BoneTag>
	{
		public BoneTagReference()
			: base()
		{
		}

		public BoneTagReference(string barcode)
			: this()
		{
		}
	}
}
