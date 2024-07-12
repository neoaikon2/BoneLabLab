using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class PalletReference : ScannableReference<Pallet>
	{
		public Pallet Pallet
		{
			get
			{
				return null;
			}
		}

		public PalletReference()
			: base()
		{
		}

		public PalletReference(string barcode)
			: this()
		{
		}

		public bool TryGetPallet([Out] Pallet pallet)
		{
			return default(bool);
		}

		public static bool IsValid(PalletReference palletReference)
		{
			return default(bool);
		}
	}
}
