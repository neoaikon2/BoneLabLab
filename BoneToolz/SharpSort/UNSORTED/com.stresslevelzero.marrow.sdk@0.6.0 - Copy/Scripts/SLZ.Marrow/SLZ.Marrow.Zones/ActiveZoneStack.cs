using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ActiveZoneStack<TZoneLink> : Object where TZoneLink : class, IZonePrioritizable
	{
		private Dictionary<TZoneLink, List<TZoneLink>> _stackLookup;

		private List<TZoneLink> _activeZones;

		public List<TZoneLink> ActiveZones => null;

		public IReadOnlyList<TZoneLink> GetZoneStack(TZoneLink zoneLink)
		{
			return null;
		}

		public bool Activate(TZoneLink previous, TZoneLink next)
		{
			return false;
		}

		public bool Activate(TZoneLink zoneLink)
		{
			return false;
		}

		public bool Deactivate(TZoneLink zoneLink)
		{
			return false;
		}
	}
}
