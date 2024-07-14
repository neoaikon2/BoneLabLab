using System;
 
using SLZ.Marrow.Interaction;
 
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    [AddComponentMenu("MarrowSDK/Zones/Zone")]
    public class Zone : MonoBehaviour
    {
#if UNITY_EDITOR
        [HideInInspector]
        public static bool gizmoZonelabMode = false;
        [HideInInspector]
        public static bool gizmoZonelabItemMode = false;
        [HideInInspector]
        public static bool gizmoZoneLinkHandles = false;
        [HideInInspector]
        [Range(0, 1000)]
        public static int gizmoZoneLinkHandlesRange = 50;
#endif
#if UNITY_EDITOR
        private void Reset()
        {
            gameObject.layer = (int)MarrowLayers.EntityTrigger;
            UnityEditor.EditorUtility.SetDirty(gameObject);
        }
#endif
    }
}