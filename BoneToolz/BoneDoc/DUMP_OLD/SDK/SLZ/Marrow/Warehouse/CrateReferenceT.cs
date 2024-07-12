using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class CrateReferenceT<T> : ScannableReference<Crate> where T : Crate
	{
		public T Crate
		{
			get
			{
				return null;
			}
		}

		public CrateReferenceT()
			: base()
		{
		}

		public CrateReferenceT(string barcode)
			: this()
		{
		}

		public bool TryGetCrate([Out] T crate)
		{
			return default(bool);
		}
	}
}
