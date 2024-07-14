 
 
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    [RequireComponent(typeof(Zone))]
    [AddComponentMenu("MarrowSDK/Zones/Zone Link")]
    public class ZoneLink : MonoBehaviour, IZoneEntityListenable, IZoneLinkable<MarrowEntity>, IZonePrioritizable
    {
        [SerializeField]
        private Zone _zone;
        public MarrowQuery activatorTags = new();
        public ZoneLink[] zoneLinks;
        [SerializeField]
        private int priority = 0;
        public int Priority => priority;

        private void Reset()
        {
            _zone = GetComponent<Zone>();
        }
    }
}