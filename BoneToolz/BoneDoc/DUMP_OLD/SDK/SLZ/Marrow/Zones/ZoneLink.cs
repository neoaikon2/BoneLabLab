using System;
using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone Link")]
	[RequireComponent(typeof(Zone))]
	public class ZoneLink : MonoBehaviour, IZoneEntityListenable, IZoneLinkable<MarrowEntity>, IZonePrioritizable
	{
		[SerializeField]
		private Zone _zone;

		public MarrowQuery activatorTags;

		public ZoneLink[] zoneLinks;

		[SerializeField]
		private int priority;

		private List<IZoneLinkListenable> _zoneLinkListeners;

		private List<IZoneLinkPrimaryListenable> _zoneLinkPrimaryListeners;

		private List<IZoneLinkSecondaryListenable> _zoneLinkSecondaryListeners;

		private Action<GameObject> _onActivatorDespawn;

		public int Priority
		{
			get
			{
				return default(int);
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnZoneEntityEnter(MarrowEntity entity)
		{
		}

		public void OnZoneEntityExit(MarrowEntity entity)
		{
		}

		public void OnEnter(MarrowEntity activator)
		{
		}

		public void OnExit(MarrowEntity activator)
		{
		}

		public void OnPrimaryEnter(MarrowEntity activator)
		{
		}

		public void OnPrimaryExit(MarrowEntity activator)
		{
		}

		public void OnSecondaryEnter(MarrowEntity activator)
		{
		}

		public void OnSecondaryExit(MarrowEntity activator)
		{
		}

		public void RegisterLinkEventListener(IZoneLinkListenable listener)
		{
		}

		public void UnregisterLinkEventListener(IZoneLinkListenable listener)
		{
		}

		public void RegisterLinkEventListener(IZoneLinkPrimaryListenable listener)
		{
		}

		public void UnregisterLinkEventListener(IZoneLinkPrimaryListenable listener)
		{
		}

		public void RegisterLinkEventListener(IZoneLinkSecondaryListenable listener)
		{
		}

		public void UnregisterLinkEventListener(IZoneLinkSecondaryListenable listener)
		{
		}

		public ZoneLink()
			: base()
		{
		}
	}
}
