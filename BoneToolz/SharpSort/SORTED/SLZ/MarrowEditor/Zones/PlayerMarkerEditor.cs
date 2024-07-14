#if UNITY_EDITOR
using SLZ.Marrow;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Utilities;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(PlayerMarker))]
    public class PlayerMarkerEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("105fcf4ae79ed4845b52781ab981fee1");
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
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/PlayerMarker");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            return tree;
        }

        [DrawGizmo(GizmoType.Selected | GizmoType.Active | GizmoType.NonSelected | GizmoType.Pickable)]
        static void DrawPlayerMarkerGizmo(PlayerMarker playerMarker, GizmoType gizmoType)
        {
            if (!Application.isPlaying && playerMarker.gameObject.scene != default)
            {
                EditorMeshGizmo.Draw("PlayerMarker Preview", playerMarker.gameObject, MarrowSDK.GenericHumanMesh, MarrowSDK.VoidMaterialAlt, MarrowSDK.GenericHumanMesh.bounds);
            }
        }

        [DrawGizmo(GizmoType.Selected | GizmoType.Pickable)]
        static void DrawSelectedPlayerMarkerInfoGizmo(PlayerMarker playerMarker, GizmoType gizmoType)
        {
            if (!Application.isPlaying && playerMarker.gameObject.scene != default)
            {
                DrawGizmoHelper.DrawText("Default: Mortal / Level Reloads on Death", playerMarker.transform.position + new Vector3(0f, -0.25f, 0f));
            }
        }

        [MenuItem("GameObject/MarrowSDK/Player Marker", priority = 1)]
        private static void MenuCreatePlacer(MenuCommand menuCommand)
        {
            GameObject go = new GameObject("Player Marker", typeof(PlayerMarker));
            go.transform.localScale = Vector3.one;
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            Selection.activeObject = go;
        }
    }
}
#endif
