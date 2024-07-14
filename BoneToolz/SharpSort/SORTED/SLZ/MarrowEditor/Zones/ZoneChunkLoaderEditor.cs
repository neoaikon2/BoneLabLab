#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(ZoneChunkLoader))]
    [CanEditMultipleObjects]
    public class ZoneChunkLoaderEditor : Editor
    {
        ZoneChunkLoader script;
        public virtual void OnEnable()
        {
            script = (ZoneChunkLoader)target;
            ZoneLink zoneLink = script.GetComponent<ZoneLink>();
            if (zoneLink != null)
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
                else
                {
                    _zoneLink = fieldInfo.GetValue(script) as ZoneLink;
                    if (_zoneLink != null && _zoneLink != zoneLink)
                    {
                        fieldInfo.SetValue(script, zoneLink);
                    }
                }
            }
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("c630897a080b9e14bb27aa9e012f8e74");
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement validationFeedback = tree.Q<VisualElement>("validationFeedback");
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            imguiValidationContainer.onGUIHandler = () =>
            {
            };
            Button marrowDocsButton = tree.Q<Button>("marrowDocsButton");
            marrowDocsButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneChunkLoader");
            };
            Button addSelectedSceneChunksButton = tree.Q<Button>("addSelectedSceneChunksButton");
            addSelectedSceneChunksButton.clickable.clicked += () =>
            {
                List<ZoneChunkLoader> selectedZoneChunkLoaders = new List<ZoneChunkLoader>();
                List<SceneChunk> selectedSceneChunks = new List<SceneChunk>();
                foreach (GameObject go in Selection.gameObjects)
                {
                    ZoneChunkLoader zcLoader = go.GetComponent<ZoneChunkLoader>();
                    if (zcLoader != null && !selectedZoneChunkLoaders.Contains(zcLoader))
                    {
                        selectedZoneChunkLoaders.Add(zcLoader);
                    }

                    SceneChunk sceneChunk = go.GetComponent<SceneChunk>();
                    if (sceneChunk != null && !selectedSceneChunks.Contains(sceneChunk))
                    {
                        selectedSceneChunks.Add(sceneChunk);
                    }
                }

                foreach (ZoneChunkLoader zcl in selectedZoneChunkLoaders)
                {
                    if (zcl.chunks.Length > 0)
                    {
                        zcl.chunks = zcl.chunks.Union(selectedSceneChunks).ToArray();
                    }
                    else
                    {
                        zcl.chunks = selectedSceneChunks.ToArray();
                    }
                }
            };
            Button overwriteSelectedSceneChunksButton = tree.Q<Button>("overwriteSelectedSceneChunksButton");
            overwriteSelectedSceneChunksButton.clickable.clicked += () =>
            {
                List<ZoneChunkLoader> selectedZoneChunkLoaders = new List<ZoneChunkLoader>();
                List<SceneChunk> selectedSceneChunks = new List<SceneChunk>();
                foreach (GameObject go in Selection.gameObjects)
                {
                    ZoneChunkLoader zcLoader = go.GetComponent<ZoneChunkLoader>();
                    if (zcLoader != null && !selectedZoneChunkLoaders.Contains(zcLoader))
                    {
                        selectedZoneChunkLoaders.Add(zcLoader);
                    }

                    SceneChunk sceneChunk = go.GetComponent<SceneChunk>();
                    if (sceneChunk != null && !selectedSceneChunks.Contains(sceneChunk))
                    {
                        selectedSceneChunks.Add(sceneChunk);
                    }
                }

                foreach (ZoneChunkLoader zcl in selectedZoneChunkLoaders)
                {
                    zcl.chunks = selectedSceneChunks.ToArray();
                }
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            return tree;
        }
    }
}
#endif
