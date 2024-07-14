#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SLZ.Marrow;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(ZoneLink))]
    [CanEditMultipleObjects]
    public class ZoneLinkEditor : Editor
    {
        ZoneLink script;
        DragAndDropManipulatorListHelper dragDropManip;
        public virtual void OnEnable()
        {
            script = (ZoneLink)target;
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("c5aafdd8cc492914e8f64ddd3e546045");
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement validationFeedback = tree.Q<VisualElement>("validationFeedback");
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            Button addZoneMusicButton = tree.Q<Button>("addZoneMusicButton");
            addZoneMusicButton.clickable.clicked += () =>
            {
                AddZoneMusicChildToZoneOnClick();
            };
            Button addZoneAmbienceButton = tree.Q<Button>("addZoneAmbienceButton");
            addZoneAmbienceButton.clickable.clicked += () =>
            {
                AddZoneAmbienceChildToZoneOnClick();
            };
            Button connectChildAudioToZoneButton = tree.Q<Button>("connectChildAudioToZoneButton");
            connectChildAudioToZoneButton.clickable.clicked += () =>
            {
                ConnectChildAudioToZoneButtonOnClick();
            };
            dragDropManip = new(tree);
            VisualElement zoneLinkDragDropTarget = tree.Q<VisualElement>("zoneLinkDragDropTarget");
            Label zoneLinkDragDropHint = tree.Q<Label>("zoneLinkDragDropHint");
            Label preDragHintText = tree.Q<Label>("preDragHintText");
            zoneLinkDragDropTarget.RegisterCallback<DragUpdatedEvent>(evt =>
            {
                DropAreaDragActive(zoneLinkDragDropTarget, zoneLinkDragDropHint, preDragHintText);
            });
            zoneLinkDragDropTarget.RegisterCallback<DragLeaveEvent>(evt =>
            {
                DropAreaDefaults(zoneLinkDragDropTarget, zoneLinkDragDropHint, preDragHintText);
            });
            zoneLinkDragDropTarget.RegisterCallback<DragPerformEvent>(evt =>
            {
                List<ZoneLink> zoneLinksList = script.zoneLinks.ToList();
                foreach (var droppedObject in dragDropManip.droppedObjects)
                {
                    GameObject droppedGO = (GameObject)droppedObject;
                    ZoneLink droppedZL = droppedGO.GetComponent<ZoneLink>();
                    if (droppedZL != script.GetComponent<ZoneLink>())
                    {
                        if (droppedZL != null && !script.zoneLinks.Contains(droppedZL))
                        {
                            zoneLinksList.Add(droppedZL);
                        }
                    }
                }

                script.zoneLinks = zoneLinksList.ToArray();
                List<ZoneLink> zoneList = UnityEngine.Object.FindObjectsOfType<ZoneLink>().ToList();
                foreach (ZoneLink zoneLink in zoneList)
                {
                    foreach (ZoneLink zl in zoneLink.zoneLinks)
                    {
                        List<ZoneLink> linksOfZoneLink = zl.zoneLinks.ToList();
                        if (!linksOfZoneLink.Contains(zoneLink))
                        {
                            linksOfZoneLink.Add(zoneLink);
                            zl.zoneLinks = linksOfZoneLink.ToArray();
                        }
                    }
                }

                DropAreaDefaults(zoneLinkDragDropTarget, zoneLinkDragDropHint, preDragHintText);
                zoneLinkDragDropTarget.RemoveFromClassList("drop-area--dropping");
            });
            imguiValidationContainer.onGUIHandler = () =>
            {
            };
            Button marrowDocsButton = tree.Q<Button>("marrowDocsButton");
            marrowDocsButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneLinks");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            DropAreaDefaults(zoneLinkDragDropTarget, zoneLinkDragDropHint, preDragHintText);
            return tree;
        }

        private void DropAreaDefaults(VisualElement zoneLinkDragDropTarget, Label zoneLinkDragDropHint, Label preDragHintText)
        {
            preDragHintText.style.display = DisplayStyle.Flex;
            zoneLinkDragDropTarget.style.borderTopWidth = 0;
            zoneLinkDragDropTarget.style.borderBottomWidth = 0;
            zoneLinkDragDropTarget.style.borderLeftWidth = 0;
            zoneLinkDragDropTarget.style.borderRightWidth = 0;
            zoneLinkDragDropHint.style.display = DisplayStyle.None;
        }

        private void DropAreaDragActive(VisualElement zoneLinkDragDropTarget, Label zoneLinkDragDropHint, Label preDragHintText)
        {
            preDragHintText.style.display = DisplayStyle.None;
            zoneLinkDragDropTarget.style.borderTopWidth = 1;
            zoneLinkDragDropTarget.style.borderBottomWidth = 1;
            zoneLinkDragDropTarget.style.borderLeftWidth = 1;
            zoneLinkDragDropTarget.style.borderRightWidth = 1;
            zoneLinkDragDropHint.style.display = DisplayStyle.Flex;
        }

        private void OnDestroy()
        {
#if UNITY_EDITOR
            if (!UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
            {
                if (Time.frameCount != 0 && Time.renderedFrameCount != 0)
                {
                    if (!ActiveEditorTracker.sharedTracker.isLocked)
                    {
                        RemoveEmptyOrDupLinksOnDestroy();
                    }
                }
            }
#endif
        }

        private void RemoveEmptyOrDupLinksOnDestroy()
        {
            List<ZoneLink> zoneList = UnityEngine.Object.FindObjectsOfType<ZoneLink>().ToList();
            List<ZoneLink> linkedZoneNoEmpties = new List<ZoneLink>();
            foreach (var zone in zoneList)
            {
                linkedZoneNoEmpties.Clear();
                if (zone.zoneLinks != null)
                {
                    foreach (var linkedZone in zone.zoneLinks)
                    {
                        if (linkedZone != null && !linkedZoneNoEmpties.Contains(linkedZone) && linkedZone != zone)
                        {
                            linkedZoneNoEmpties.Add(linkedZone);
                        }
                    }

                    Undo.RecordObject(zone, "Cull Dup/Empty Zone ZoneLinks");
                    zone.zoneLinks = linkedZoneNoEmpties.ToArray();
                }
            }
        }

        private void AddZoneMusicChildToZoneOnClick()
        {
            ZoneLink parentZoneLink = script.GetComponent<ZoneLink>();
            ZoneLinkItem parentZoneLinkItem = script.GetComponent<ZoneLinkItem>();
            GameObject zoneMusicChildObj = new GameObject(script.name + " ZoneMusic");
            zoneMusicChildObj.transform.position = parentZoneLink.transform.position;
            ZoneMusic zoneMusicChild = zoneMusicChildObj.AddComponent<ZoneMusic>();
            zoneMusicChildObj.transform.parent = script.transform;
            zoneMusicChildObj.layer = LayerMask.NameToLayer("Default");
            SetZoneMusicZoneLink(zoneMusicChild, parentZoneLink);
            SetZoneMusicEventType(zoneMusicChild, parentZoneLinkItem);
            Selection.activeGameObject = zoneMusicChildObj;
        }

        private void AddZoneAmbienceChildToZoneOnClick()
        {
            ZoneLink parentZoneLink = script.GetComponent<ZoneLink>();
            ZoneLinkItem parentZoneLinkItem = script.GetComponent<ZoneLinkItem>();
            GameObject zoneAmbienceChildObj = new GameObject(script.name + " ZoneAmbience");
            zoneAmbienceChildObj.transform.position = parentZoneLink.transform.position;
            ZoneAmbience zoneAmbienceChild = zoneAmbienceChildObj.AddComponent<ZoneAmbience>();
            zoneAmbienceChildObj.transform.parent = script.transform;
            zoneAmbienceChildObj.layer = LayerMask.NameToLayer("Default");
            SetZoneAmbienceZoneLink(zoneAmbienceChild, parentZoneLink);
            SetZoneAmbienceEventType(zoneAmbienceChild, parentZoneLinkItem);
            Selection.activeGameObject = zoneAmbienceChildObj;
        }

        private void ConnectChildAudioToZoneButtonOnClick()
        {
            ZoneLink parentZoneLink = script.GetComponent<ZoneLink>();
            foreach (ZoneMusic zoneMusic in script.GetComponentsInChildren<ZoneMusic>())
            {
                SetZoneMusicZoneLink(zoneMusic, parentZoneLink);
            }

            foreach (ZoneAmbience zoneAmbience in script.GetComponentsInChildren<ZoneAmbience>())
            {
                SetZoneAmbienceZoneLink(zoneAmbience, parentZoneLink);
            }
        }

        private void SetZoneMusicZoneLink(ZoneMusic zoneMusicChild, ZoneLink parentZoneLink)
        {
            Type type = zoneMusicChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneMusicChild.GetType().FullName);
            }

            if (parentZoneLink != null)
            {
                fieldInfo.SetValue(zoneMusicChild, parentZoneLink);
            }
        }

        private void SetZoneAmbienceZoneLink(ZoneAmbience zoneAmbienceChild, ZoneLink parentZoneLink)
        {
            Type type = zoneAmbienceChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneAmbienceChild.GetType().FullName);
            }

            if (parentZoneLink != null)
            {
                fieldInfo.SetValue(zoneAmbienceChild, parentZoneLink);
            }
        }

        private void SetZoneMusicEventType(ZoneMusic zoneMusicChild, ZoneLinkItem parentZoneLinkItem)
        {
            Type type = zoneMusicChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_eventTypes", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _eventTypes was not found in Type " + zoneMusicChild.GetType().FullName);
            }
            else
            {
                fieldInfo.SetValue(zoneMusicChild, ZoneLinkItem.EventTypes.Primary);
            }
        }

        private void SetZoneAmbienceEventType(ZoneAmbience zoneAmbienceChild, ZoneLinkItem parentZoneLinkItem)
        {
            Type type = zoneAmbienceChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_eventTypes", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _eventTypes was not found in Type " + zoneAmbienceChild.GetType().FullName);
            }
            else
            {
                fieldInfo.SetValue(zoneAmbienceChild, ZoneLinkItem.EventTypes.Primary);
            }
        }
    }
}
#endif
