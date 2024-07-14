using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class LevelCrateReference : CrateReferenceT<LevelCrate>
	{
		public LevelCrateReference(string barcode)
		{
		}

		public LevelCrateReference()
		{
		}
	}
}
