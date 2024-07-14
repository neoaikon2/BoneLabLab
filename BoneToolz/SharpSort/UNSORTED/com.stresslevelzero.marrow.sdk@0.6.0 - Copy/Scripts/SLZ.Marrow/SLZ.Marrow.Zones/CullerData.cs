using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	internal class CullerData
	{
		public bool isSet;

		public bool isCulled;

		public bool isCullForced;

		public int priority;

		public List<InactiveStatus> disableables;

		public List<InactiveStatus> orphanDisableables;

		public CullerData(int priority)
		{
		}

		public bool IsCulled()
		{
			return false;
		}
	}
}
