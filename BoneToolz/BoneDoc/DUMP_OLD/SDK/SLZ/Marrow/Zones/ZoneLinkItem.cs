using System;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneLinkItem : MonoBehaviour, IZoneLinkListenable, IZoneLinkPrimaryListenable, IZoneLinkSecondaryListenable
	{
		[Flags]
		public enum EventTypes
		{
			Primary = 1,
			Secondary = 2
		}

		[SerializeField]
		protected ZoneLink _zoneLink;

		[EnumFlags]
		[SerializeField]
		protected EventTypes _eventTypes;

		private bool _hasPrimary;

		private bool _hasSecondary;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected virtual void OnExit(MarrowEntity activatorEntity)
		{
		}

		protected virtual void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected virtual void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		protected virtual void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected virtual void OnSecondaryExit(MarrowEntity activatorEntity)
		{
		}

		public void OnZoneLinkEnter(MarrowEntity activator)
		{
		}

		public void OnZoneLinkExit(MarrowEntity activator)
		{
		}

		public void OnZoneLinkPrimaryEnter(MarrowEntity activator)
		{
		}

		public void OnZoneLinkPrimaryExit(MarrowEntity activator)
		{
		}

		public void OnZoneLinkSecondaryEnter(MarrowEntity activator)
		{
		}

		public void OnZoneLinkSecondaryExit(MarrowEntity activator)
		{
		}

		public ZoneLinkItem()
			: base()
		{
		}
	}
}
