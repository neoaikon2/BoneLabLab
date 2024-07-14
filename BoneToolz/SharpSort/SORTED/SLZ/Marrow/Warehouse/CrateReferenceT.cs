using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class CrateReferenceT<T> : ScannableReference<Crate> where T : Crate
	{
		public T Crate => null;

		public CrateReferenceT()
		{
		}

		public CrateReferenceT(string barcode)
		{
		}

		public bool TryGetCrate(out T crate)
		{
			crate = null;
			return false;
		}
	}
}
