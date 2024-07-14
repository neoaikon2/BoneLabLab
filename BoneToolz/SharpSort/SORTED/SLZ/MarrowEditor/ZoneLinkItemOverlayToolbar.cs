#if UNITY_EDITOR
using System.Collections.Generic;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    [Overlay(typeof(SceneView), id: ID_OVERLAY_ZONEITEM, displayName: "ZoneLink Items")]
    public class ZoneLinkItemOverlayToolbar : Overlay
    {
        private const string ID_OVERLAY_ZONEITEM = "zonelink-item-overlay-toolbar";
        private string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("c923f4331487c004b92ce7a744bfb0b5");
        public override VisualElement CreatePanelContent()
        {
            SceneVisibilityManager svm = SceneVisibilityManager.instance;
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement rootVisualElement = new VisualElement();
            rootVisualElement.Add(tree);
            Toggle zonelabItemModeToggle = rootVisualElement.Q<Toggle>("zonelabItemModeToggle");
            zonelabItemModeToggle.RegisterValueChangedCallback(evt =>
            {
                if (zonelabItemModeToggle.value)
                {
                    List<GameObject> nonZoneGameObjects = new List<GameObject>();
                    nonZoneGameObjects.Clear();
                    foreach (GameObject gameObj in Object.FindObjectsOfType<GameObject>())
                    {
                        if (!gameObj.GetComponent<ZoneLinkItem>() && !gameObj.GetComponent<Zone>())
                        {
                            nonZoneGameObjects.Add(gameObj);
                        }
                    }

                    EnableZonelabItemMode(svm, zonelabItemModeToggle, nonZoneGameObjects);
                }
                else
                {
                    DisableZonelabItemMode(svm, zonelabItemModeToggle);
                }
            });
            Toggle zoneLinkItemRelationsToggle = rootVisualElement.Q<Toggle>("zoneLinkItemRelationsToggle");
            Slider zoneLinkItemOpacitySlider = rootVisualElement.Q<Slider>("zoneLinkItemOpacitySlider");
            Button enableAllZoneLinkItemGizmosButton = rootVisualElement.Q<Button>("enableAllZoneLinkItemGizmosButton");
            Button disableAllZoneLinkItemGizmosButton = rootVisualElement.Q<Button>("disableAllZoneLinkItemGizmosButton");
            Toggle zoneLinkItemsToggle = rootVisualElement.Q<Toggle>("zoneLinkItemsToggle");
            Toggle zoneAmbienceToggle = rootVisualElement.Q<Toggle>("zoneAmbienceToggle");
            Toggle zoneMusicToggle = rootVisualElement.Q<Toggle>("zoneMusicToggle");
            zoneLinkItemRelationsToggle.RegisterValueChangedCallback((evt) =>
            {
                if (zoneLinkItemRelationsToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneLinkItemRelations = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneLinkItemRelations = false;
                }
            });
            zoneLinkItemOpacitySlider.RegisterValueChangedCallback((evt) =>
            {
                MarrowSDKPreferences.gizmoZoneLinkItemOpacity = zoneLinkItemOpacitySlider.value;
            });
            enableAllZoneLinkItemGizmosButton.clickable.clicked += () =>
            {
                zoneLinkItemsToggle.value = true;
                MarrowSDKPreferences.gizmoZoneItemGizmos = true;
                zoneAmbienceToggle.value = true;
                MarrowSDKPreferences.gizmoZoneAmbience = true;
                zoneMusicToggle.value = true;
                MarrowSDKPreferences.gizmoZoneMusic = true;
            };
            disableAllZoneLinkItemGizmosButton.clickable.clicked += () =>
            {
                zoneLinkItemsToggle.value = false;
                MarrowSDKPreferences.gizmoZoneItemGizmos = true;
                zoneAmbienceToggle.value = false;
                MarrowSDKPreferences.gizmoZoneAmbience = true;
                zoneMusicToggle.value = false;
                MarrowSDKPreferences.gizmoZoneMusic = true;
            };
            zoneLinkItemsToggle.RegisterValueChangedCallback((evt) =>
            {
                if (zoneLinkItemsToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneItemGizmos = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneItemGizmos = false;
                }
            });
            zoneAmbienceToggle.RegisterValueChangedCallback((evt) =>
            {
                if (zoneAmbienceToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneAmbience = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneAmbience = false;
                }
            });
            zoneMusicToggle.RegisterValueChangedCallback((evt) =>
            {
                if (zoneMusicToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneMusic = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneMusic = false;
                }
            });
            DisableZonelabItemMode(svm, zonelabItemModeToggle);
            MarrowSDKPreferences.gizmoZoneLinkItemOpacity = zoneLinkItemOpacitySlider.value;
            MarrowSDKPreferences.gizmoZoneItemGizmos = zoneLinkItemsToggle.value;
            MarrowSDKPreferences.gizmoZoneAmbience = zoneAmbienceToggle.value;
            MarrowSDKPreferences.gizmoZoneMusic = zoneMusicToggle.value;
            return rootVisualElement;
        }

        private void EnableZonelabItemMode(SceneVisibilityManager svm, Toggle zonelabItemModeToggle, List<GameObject> nonZoneGameObjects)
        {
            zonelabItemModeToggle.text = "  Enabled: Zones and ZoneLinkItems Scene-Selectable";
            svm.DisablePicking(nonZoneGameObjects.ToArray(), false);
            Zone.gizmoZonelabItemMode = true;
        }

        private void DisableZonelabItemMode(SceneVisibilityManager svm, Toggle zonelabItemModeToggle)
        {
            zonelabItemModeToggle.text = "  Disabled: All Objects are Selectable";
            svm.EnableAllPicking();
            Zone.gizmoZonelabItemMode = false;
        }
    }
}
#endif
