using System;
using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone")]
	public class Zone : MonoBehaviour
	{
		private Action<Collider> _otherColDisableAction;

		private readonly Dictionary<MarrowEntity, int> _entityOverlapCounts;

		private readonly HashSet<Tracker> _trackerOverlap;

		private readonly List<Collider> _colliderExitBuffer;

		private List<EntityAggregator> _aggregators;

		private List<IZoneBodyListenable> _zoneBodyListeners;

		private List<IZoneEntityListenable> _zoneEntityListeners;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void OnTriggerExit(Collider other)
		{
		}

		private void ProcessesTriggerExit(Collider other)
		{
		}

		private void OnColliderDisable(Collider other)
		{
		}

		public void RegisterZoneEventListener(IZoneBodyListenable listener)
		{
		}

		public void UnregisterZoneEventListener(IZoneBodyListenable listener)
		{
		}

		public void RegisterZoneEventListener(IZoneEntityListenable listener)
		{
		}

		public void UnregisterZoneEventListener(IZoneEntityListenable listener)
		{
		}

		public void RegisterAggregator(EntityAggregator aggregator)
		{
		}

		public void UnregisterAggregator(EntityAggregator aggregator)
		{
		}

		public Zone()
			: base()
		{
		}
	}
}
