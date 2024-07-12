using System;
using SLZ.Marrow.Interaction;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(ZoneLink))]
	public class ZoneLinkEvents : ZoneLinkItem
	{
		[Serializable]
		public class ZoneEventCallback : UltEvent<MarrowEntity>
		{
			public ZoneEventCallback()
				: base()
			{
			}
		}

		private bool _hasZoneLinkEntered;

		[Space(10f)]
		public ZoneEventCallback onZoneLinkEnter;

		[Space(10f)]
		public ZoneEventCallback onZoneLinkEnterOneShot;

		[Space(10f)]
		public ZoneEventCallback onZoneLinkExit;

		[Space(10f)]
		public ZoneEventCallback onSecondaryZoneLinkEnter;

		[Space(10f)]
		public ZoneEventCallback onSecondaryZoneLinkExit;

		[Space(10f)]
		public ZoneEventCallback onPrimaryZoneLinkEnter;

		[Space(10f)]
		public ZoneEventCallback onPrimaryZoneLinkExit;

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		protected override void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnSecondaryExit(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		public ZoneLinkEvents()
			: base()
		{
		}
	}
}
