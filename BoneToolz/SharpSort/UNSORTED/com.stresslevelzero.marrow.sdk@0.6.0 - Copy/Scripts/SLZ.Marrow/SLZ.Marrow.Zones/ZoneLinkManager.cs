using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	public class ZoneLinkManager<TZoneActivator, TZoneLink> where TZoneActivator : class where TZoneLink : class, IZoneLinkable<TZoneActivator>, IZonePrioritizable
	{
		public class ActivatorStates
		{
			public readonly ActiveZoneStack<TZoneLink> zoneStack;

			public readonly Dictionary<TZoneLink, ActiveZoneState> states;

			public bool isOrphaned;

			public TZoneLink orphanActiveLink;

			public ActiveZoneState GetZoneState(TZoneLink zoneLink)
			{
				return null;
			}

			public void ClearState(TZoneLink zoneLink)
			{
			}

			public bool WillOrphan(TZoneLink zoneLink)
			{
				return false;
			}

			public void ClearOrphan()
			{
			}
		}

		private readonly ZoneGraph<TZoneLink> _graph;

		private readonly List<TZoneLink> _linkBuffer;

		private readonly Dictionary<TZoneActivator, ActivatorStates> _activatorStates;

		public void RegisterZoneLink(TZoneLink zoneLinkA)
		{
		}

		public void RegisterZoneLink(TZoneLink zoneLinkA, TZoneLink zoneLinkB)
		{
		}

		public void UnregisterZoneLinkEdge(TZoneLink zoneLinkA, TZoneLink zoneLinkB)
		{
		}

		public void UnregisterZoneLinkVert(TZoneLink zoneLink)
		{
		}

		private bool RegisterActivator(TZoneActivator activator)
		{
			return false;
		}

		private void UnregisterActivator(TZoneActivator activator)
		{
		}

		public void Activate(TZoneActivator activator, TZoneLink zoneLink)
		{
		}

		public void Deactivate(TZoneActivator activator, TZoneLink zoneLink, bool allowOrphan = true)
		{
		}

		private void ClearLink(TZoneLink zoneLink)
		{
		}

		private void RefreshZoneStates()
		{
		}

		private void SolveZoneStates(ActivatorStates states, TZoneActivator activator, TZoneLink zoneLink, TZoneLink curActiveZoneLink)
		{
		}
	}
}
