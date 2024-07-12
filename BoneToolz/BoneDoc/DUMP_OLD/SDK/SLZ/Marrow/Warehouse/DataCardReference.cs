using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class DataCardReference : ScannableReference<DataCard>
	{
		public DataCard DataCard
		{
			get
			{
				return null;
			}
		}

		public DataCardReference()
			: base()
		{
		}

		public DataCardReference(string barcode)
			: this()
		{
		}

		public bool TryGetDataCard([Out] DataCard dataCard)
		{
			return default(bool);
		}

		public static bool IsValid(DataCardReference dataCardReference)
		{
			return default(bool);
		}
	}
	[Serializable]
	public class DataCardReference<T> : ScannableReference<DataCard> where T : DataCard
	{
		public T DataCard
		{
			get
			{
				return null;
			}
		}

		public DataCardReference()
			: base()
		{
		}

		public DataCardReference(string barcode)
			: this()
		{
		}

		public bool TryGetDataCard([Out] T dataCard)
		{
			return default(bool);
		}
	}
}
