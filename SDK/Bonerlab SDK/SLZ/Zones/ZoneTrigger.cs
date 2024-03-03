using System;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneTrigger : MonoBehaviour
	{
		public Action<SceneZone> zoneEnterDelegate;

		public Action<SceneZone> zoneExitDelegate;

		[SerializeField]
#if !UNITY_EDITOR // Castify required modification
		private bool isZoneTriggerActive;
#else
		public bool isZoneTriggerActive;
#endif

		public void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
