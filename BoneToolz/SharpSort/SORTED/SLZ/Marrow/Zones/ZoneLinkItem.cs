using SLZ.Marrow.Interaction;
using System;
 
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    public class ZoneLinkItem : MonoBehaviour, IZoneLinkListenable, IZoneLinkPrimaryListenable, IZoneLinkSecondaryListenable
    {
        [Flags]
        public enum EventTypes
        {
            Primary = 1 << 0,
            Secondary = 1 << 1
        }

        [SerializeField]
        protected ZoneLink _zoneLink;
        [EnumFlags, SerializeField]
        protected EventTypes _eventTypes = EventTypes.Primary | EventTypes.Secondary;
#if UNITY_EDITOR
        protected virtual void Reset()
        {
            _zoneLink = GetComponent<ZoneLink>();
            if (_zoneLink != null || transform.parent == null)
                return;
            _zoneLink = transform.parent.GetComponent<ZoneLink>();
        }

		public void OnZoneLinkSecondaryEnter(MarrowEntity activator)
		{
			throw new NotImplementedException();
		}

		public void OnZoneLinkSecondaryExit(MarrowEntity activator)
		{
			throw new NotImplementedException();
		}

		public void OnZoneLinkPrimaryEnter(MarrowEntity activator)
		{
			throw new NotImplementedException();
		}

		public void OnZoneLinkPrimaryExit(MarrowEntity activator)
		{
			throw new NotImplementedException();
		}
#endif
	}
}