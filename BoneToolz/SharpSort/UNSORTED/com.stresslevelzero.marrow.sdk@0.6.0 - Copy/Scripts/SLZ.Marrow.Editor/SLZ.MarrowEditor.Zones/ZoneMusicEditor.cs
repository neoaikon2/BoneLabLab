#if UNITY_EDITOR
using System;
using System.Reflection;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using static SLZ.Marrow.Zones.ZoneLinkItem;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(ZoneMusic), true)]
    [CanEditMultipleObjects]
    public class ZoneMusicEditor : Editor
    {
        ZoneMusic script;
        public enum EventTypesFiltered
        {
            Nothing = 0,
            Primary = 1
        }

        public virtual void OnEnable()
        {
            script = (ZoneMusic)target;
            EditorApplication.hierarchyWindowItemOnGUI += ZoneMusicPasteCommand;
            if (ZoneMusic.zoneMusicPasted)
            {
                ZoneLink _zoneLink = null;
                Type type = script.GetType();
                FieldInfo fieldInfo = null;
                while (fieldInfo == null && type != null)
                {
                    fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    type = type.BaseType;
                }

                if (fieldInfo == null)
                {
                    throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + script.GetType().FullName);
                }

                _zoneLink = fieldInfo.GetValue(script) as ZoneLink;
                ZoneLink parentZoneLink = script.GetComponentInParent<ZoneLink>();
                if (parentZoneLink != null && _zoneLink != parentZoneLink)
                {
                    fieldInfo.SetValue(script, parentZoneLink);
                    script.gameObject.name = parentZoneLink.gameObject.name + " ZoneMusic";
                }

                ZoneMusic.zoneMusicPasted = false;
            }
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("efdf19c375a6f8149ba17183d8295fca");
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement validationFeedback = tree.Q<VisualElement>("validationFeedback");
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            imguiValidationContainer.onGUIHandler = () =>
            {
                ZoneLink _zoneLink = null;
                Type type = script.GetType();
                FieldInfo fieldInfo = null;
                while (fieldInfo == null && type != null)
                {
                    fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    type = type.BaseType;
                }

                if (fieldInfo == null)
                {
                    throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + script.GetType().FullName);
                }

                _zoneLink = fieldInfo.GetValue(script) as ZoneLink;
                if (_zoneLink == null)
                {
                    EditorGUILayout.HelpBox("ZoneMusic's ZoneLink is missing.", MessageType.Error);
                }
            };
            EnumField eventTypesFiltered = tree.Q<EnumField>("EventTypesFiltered");
            Type eventTypesType = script.GetType();
            FieldInfo eventTypesFieldInfo = null;
            while (eventTypesFieldInfo == null && eventTypesType != null)
            {
                eventTypesFieldInfo = eventTypesType.GetField("_eventTypes", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                eventTypesType = eventTypesType.BaseType;
            }

            if (eventTypesFieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _eventTypes was not found in Type " + script.GetType().FullName);
            }

            eventTypesFiltered.RegisterValueChangedCallback(evt =>
            {
                if (eventTypesFiltered.value.ToString() == "Nothing")
                {
                    eventTypesFieldInfo.SetValue(script, 0);
                }
                else
                {
                    eventTypesFieldInfo.SetValue(script, EventTypes.Primary);
                }
            });
            if ((EventTypes)eventTypesFieldInfo.GetValue(script) == 0)
            {
                eventTypesFiltered.value = EventTypesFiltered.Nothing;
            }
            else
            {
                eventTypesFiltered.value = EventTypesFiltered.Primary;
                eventTypesFieldInfo.SetValue(script, EventTypes.Primary);
            }

            Button marrowDocsButton = tree.Q<Button>("marrowDocsButton");
            marrowDocsButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneMusic");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            return tree;
        }

        private void ZoneMusicPasteCommand(int n, Rect rt)
        {
            string cmdName = Event.current.commandName;
            switch (cmdName)
            {
                case null:
                    break;
                case "":
                    break;
                default:
                    break;
            }

            if (Event.current != null && Event.current.type == EventType.ValidateCommand && "Paste" == Event.current.commandName)
            {
                ZoneMusic.zoneMusicPasted = true;
            }
        }
    }
}
#endif
