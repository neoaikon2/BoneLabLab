using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	public class ZoneManager
	{
		private readonly HashSet<Zone> _zones;

		public int RegisteredZoneCount => 0;

		public Zone[] RegisteredZones => null;

		public void RegisterZone(Zone zone)
		{
		}

		public void UnregisterZone(Zone zone)
		{
		}

		public void RegisterZoneLink(ZoneLink zoneA, ZoneLink zoneB)
		{
		}

		public void UnregisterZoneLink(ZoneLink zoneA, ZoneLink zoneB)
		{
		}
	}
}
