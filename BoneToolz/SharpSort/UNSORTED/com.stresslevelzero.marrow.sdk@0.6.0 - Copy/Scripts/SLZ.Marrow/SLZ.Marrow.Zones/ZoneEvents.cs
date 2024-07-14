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
        }

        [Space(10)]
        public ZoneEventCallback onZoneEnter = new();
        [Space(10)]
        public ZoneEventCallback onZoneEnterOneShot = new();
        [Space(10)]
        public ZoneEventCallback onZoneExit = new();
    }
}