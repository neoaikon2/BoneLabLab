using System;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class MonoDiscReference : DataCardReference<MonoDisc>
	{
		public MonoDiscReference()
			: base()
		{
		}

		public MonoDiscReference(string barcode)
			: this()
		{
		}
	}
}
