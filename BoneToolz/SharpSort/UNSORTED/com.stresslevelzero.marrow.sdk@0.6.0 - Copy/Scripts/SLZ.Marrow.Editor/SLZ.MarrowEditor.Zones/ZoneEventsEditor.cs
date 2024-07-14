#if UNITY_EDITOR
  
 
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(ZoneEvents))]
    [CanEditMultipleObjects]
    public class ZoneEventsEditor : Editor
    {
        ZoneEvents script;
        public virtual void OnEnable()
        {
            script = (ZoneEvents)target;
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("c3f7d84fcbc974541a988a1ed243a152");
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
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneEvents");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            return tree;
        }

        [MenuItem("GameObject/MarrowSDK/Zone Event", priority = 5)]
        private static void MenuCreateSpawner(MenuCommand menuCommand)
        {
            GameObject go = new GameObject("Zone Event");
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            if (go.GetComponent<Zone>() == null)
                go.AddComponent<Zone>();
            BoxCollider boxCol = go.GetComponent<BoxCollider>();
            if (go.GetComponent<BoxCollider>() == null)
            {
                boxCol = go.AddComponent<BoxCollider>();
            }

            boxCol.isTrigger = true;
            ZoneEvents zoneEvent = go.GetComponent<ZoneEvents>();
            if (zoneEvent == null)
            {
                zoneEvent = go.AddComponent<ZoneEvents>();
                zoneEvent.activatorTags.Tags.Clear();
            }

            Selection.activeObject = go;
        }
    }
}
#endif
