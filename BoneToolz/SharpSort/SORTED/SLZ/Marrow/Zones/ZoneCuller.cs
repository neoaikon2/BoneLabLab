 
 
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    [RequireComponent(typeof(ZoneLink), typeof(Zone))]
    [AddComponentMenu("MarrowSDK/Zones/Zone Culler")]
    public class ZoneCuller : MonoBehaviour, IZoneEntityListenable, IZoneLinkListenable
    {
        [SerializeField]
        private Zone _zone;
        [SerializeField]
        private ZoneLink _zoneLink;
        void Reset()
        {
            _zone = GetComponent<Zone>();
            _zoneLink = GetComponent<ZoneLink>();
        }
    }
}