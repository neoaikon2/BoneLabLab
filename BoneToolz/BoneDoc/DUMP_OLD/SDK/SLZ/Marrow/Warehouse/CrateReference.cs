using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class CrateReference : ScannableReference<Crate>
	{
		public Crate Crate
		{
			get
			{
				return null;
			}
		}

		public CrateReference()
			: base()
		{
		}

		public CrateReference(string barcode)
			: this()
		{
		}

		public bool TryGetCrate([Out] Crate crate)
		{
			return default(bool);
		}

		public static bool IsValid(CrateReference crateReference)
		{
			return default(bool);
		}
	}
}
