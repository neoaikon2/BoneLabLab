#if UNITY_EDITOR
using System;
using System.Reflection;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEngine;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(ZoneLinkItem))]
    public class ZoneLinkItemEditor : Editor
    {
        [DrawGizmo(GizmoType.Selected)]
        static void DrawSelectedZoneLinkItemGizmo(ZoneLinkItem zoneLinkItem, GizmoType gizmoType)
        {
        }

        [DrawGizmo(GizmoType.NonSelected)]
        static void DrawNonSelectedZoneLinkItemGizmo(ZoneLinkItem zoneLinkItem, GizmoType gizmoType)
        {
        }

        [DrawGizmo(GizmoType.Pickable | GizmoType.Selected)]
        static void DrawPickableSelectedZoneLinkItemGizmo(ZoneLinkItem zoneLinkItem, GizmoType gizmoType)
        {
            DrawZoneLinkItemGizmo(zoneLinkItem);
        }

        [DrawGizmo(GizmoType.Pickable | GizmoType.NonSelected)]
        static void DrawPickableNonSelectedZoneLinkItemGizmo(ZoneLinkItem zoneLinkItem, GizmoType gizmoType)
        {
            DrawZoneLinkItemGizmo(zoneLinkItem);
        }

        static void DrawZoneLinkItemGizmo(ZoneLinkItem zoneLinkItem)
        {
            if (MarrowSDKPreferences.gizmoZoneItemGizmos)
            {
                Vector3 itemLabelOffset = Vector3.down * 0.5f;
                if (MarrowSDKPreferences.gizmoZoneAmbience && zoneLinkItem.GetComponent<ZoneAmbience>())
                {
                    Gizmos.color = new Color(1f, 0.6f, 0f, MarrowSDKPreferences.gizmoZoneLinkItemOpacity);
                    DrawZoneLinkItem(zoneLinkItem, itemLabelOffset);
                }
                else if (MarrowSDKPreferences.gizmoZoneMusic && zoneLinkItem.GetComponent<ZoneMusic>())
                {
                    Gizmos.color = new Color(1f, 0.6f, 0f, MarrowSDKPreferences.gizmoZoneLinkItemOpacity);
                    DrawZoneLinkItem(zoneLinkItem, itemLabelOffset);
                }
                else
                {
                    if (MarrowSDKPreferences.gizmoZoneItemGizmos && !zoneLinkItem.GetComponent<ZoneMusic>() && !zoneLinkItem.GetComponent<ZoneAmbience>() && !zoneLinkItem.GetComponent<ZoneChunkLoader>())
                    {
                        Gizmos.color = new Color(1f, 1f, 0.25f, MarrowSDKPreferences.gizmoZoneLinkItemOpacity);
                        DrawZoneLinkItem(zoneLinkItem, itemLabelOffset);
                    }
                }
            }
        }

        static void DrawZoneLinkItem(ZoneLinkItem zoneLinkItem, Vector3 itemLabelOffset)
        {
            Gizmos.DrawCube(zoneLinkItem.transform.position, Vector3.one * 0.15f);
            if (Camera.current != null && Vector3.Dot(zoneLinkItem.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
            {
                DrawGizmoHelper.DrawText(zoneLinkItem.name, zoneLinkItem.transform.position + itemLabelOffset);
            }

            if (Zone.gizmoZonelabItemMode && MarrowSDKPreferences.gizmoZoneLinkItemRelations)
            {
                ZoneLink zoneLinkItemZone = null;
                Type type = zoneLinkItem.GetType();
                FieldInfo fieldInfo = null;
                while (fieldInfo == null && type != null)
                {
                    fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    type = type.BaseType;
                }

                if (fieldInfo == null)
                {
                    throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneLinkItem.GetType().FullName);
                }

                zoneLinkItemZone = fieldInfo.GetValue(zoneLinkItem) as ZoneLink;
                Vector3 zonePosition = zoneLinkItemZone.transform.position;
                Gizmos.DrawLine(zonePosition, zoneLinkItem.transform.position);
            }
        }
    }
}
#endif
