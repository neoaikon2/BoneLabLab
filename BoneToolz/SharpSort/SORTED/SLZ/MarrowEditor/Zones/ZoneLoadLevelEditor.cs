#if UNITY_EDITOR
  
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(ZoneLoadLevel))]
    [CanEditMultipleObjects]
    public class ZoneLoadLevelEditor : Editor
    {
        ZoneLoadLevel script;
        public virtual void OnEnable()
        {
            script = (ZoneLoadLevel)target;
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("a370a12f2faa65f419fa06fd2c69a65e");
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
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneLoadLevel");
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
