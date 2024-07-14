using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class GameObjectCrateReference : CrateReferenceT<GameObjectCrate>
	{
		public GameObjectCrateReference(string barcode)
		{
		}

		public GameObjectCrateReference()
		{
		}
	}
}
