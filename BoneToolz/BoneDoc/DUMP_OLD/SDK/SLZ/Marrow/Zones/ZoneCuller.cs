using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone Culler")]
	[RequireComponent(typeof(ZoneLink), typeof(Zone))]
	public class ZoneCuller : MonoBehaviour, IZoneEntityListenable, IZoneLinkListenable
	{
		private bool _isCullForced;

		private bool _hasZoneId;

		private int _zoneId;

		[SerializeField]
		private Zone _zone;

		[SerializeField]
		private ZoneLink _zoneLink;

		private Dictionary<MarrowEntity, bool> _activatorState;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void RegisterCuller()
		{
		}

		public void ForceCull(bool isForced)
		{
		}

		public void OnZoneEntityEnter(MarrowEntity entity)
		{
		}

		public void OnZoneEntityExit(MarrowEntity entity)
		{
		}

		public void OnZoneLinkEnter(MarrowEntity activator)
		{
		}

		public void OnZoneLinkExit(MarrowEntity activator)
		{
		}

		private void ProcessesHiddenState(MarrowEntity activatorEntity, bool wasActive)
		{
		}

		public ZoneCuller()
			: base()
		{
		}
	}
}
