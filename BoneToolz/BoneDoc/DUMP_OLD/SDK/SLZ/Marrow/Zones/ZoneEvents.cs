using System;
using SLZ.Marrow.Interaction;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(Zone))]
	[AddComponentMenu("MarrowSDK/Zones/Zone Events")]
	public class ZoneEvents : ZoneItem
	{
		[Serializable]
		public class ZoneEventCallback : UltEvent<MarrowEntity>
		{
			public ZoneEventCallback()
				: base()
			{
			}
		}

		private bool _hasZoneEntered;

		[Space(10f)]
		public ZoneEventCallback onZoneEnter;

		[Space(10f)]
		public ZoneEventCallback onZoneEnterOneShot;

		[Space(10f)]
		public ZoneEventCallback onZoneExit;

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		public ZoneEvents()
			: base()
		{
		}
	}
}
