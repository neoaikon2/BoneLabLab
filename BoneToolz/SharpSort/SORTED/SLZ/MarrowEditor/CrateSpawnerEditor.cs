using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(CrateSpawner))]
    [CanEditMultipleObjects]
    public class CrateSpawnerEditor : Editor
    {
        SerializedProperty spawnableCrateReferenceProperty;
        SerializedProperty policyDataProperty;
        SerializedProperty crateQueryProperty;
        SerializedProperty useQueryProperty;
        SerializedProperty manualModeProperty;
        SerializedProperty onPlaceEventProperty;
        private static GUIContent previewMeshGizmoIcon = null;
        private static GUIContent colliderBoundsGizmoIcon = null;
        private static GUIContent materialIconOn = null;
        private static GUIContent materialIconOff = null;
        private bool helpText = false;
        private bool defaultInspector = false;
        private int padding = 5;
        public virtual void OnEnable()
        {
            EditorApplication.contextualPropertyMenu += OnPropertyContextMenu;
            spawnableCrateReferenceProperty = serializedObject.FindProperty("spawnableCrateReference");
            policyDataProperty = serializedObject.FindProperty("policyData");
            crateQueryProperty = serializedObject.FindProperty("crateQuery");
            useQueryProperty = serializedObject.FindProperty("useQuery");
            manualModeProperty = serializedObject.FindProperty("manualMode");
            onPlaceEventProperty = serializedObject.FindProperty("onSpawnEvent");
            var castedTarget = (CrateSpawner)target;
            if (castedTarget.transform.gameObject.activeInHierarchy)
            {
                if (PrefabUtility.GetPrefabAssetType(castedTarget.transform.gameObject) == PrefabAssetType.Regular)
                {
                    PrefabUtility.UnpackPrefabInstance(castedTarget.transform.gameObject, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
                    Collider[] collidersAroundSpawnable = Physics.OverlapSphere(castedTarget.transform.position, 1f, ~0, QueryTriggerInteraction.Collide);
                    foreach (Collider col in collidersAroundSpawnable)
                    {
                        if (col != null && col.GetComponent<ZoneLink>() != null)
                        {
                            castedTarget.transform.parent = col.transform;
                        }
                    }
                }
            }

            if (previewMeshGizmoIcon == null)
            {
                previewMeshGizmoIcon = new GUIContent(EditorGUIUtility.IconContent("d_GizmosToggle On@2x"));
                previewMeshGizmoIcon.tooltip = "Toggle Preview Mesh Gizmo";
            }

            if (colliderBoundsGizmoIcon == null)
            {
                colliderBoundsGizmoIcon = new GUIContent(EditorGUIUtility.IconContent("d_BoxCollider2D Icon"));
                colliderBoundsGizmoIcon.tooltip = "Toggle Collider Bounds";
            }

            if (materialIconOn == null)
            {
                materialIconOn = new GUIContent(EditorGUIUtility.IconContent("d_Material On Icon"));
                materialIconOn.tooltip = "Swap Preview Mesh Material";
            }

            if (materialIconOff == null)
            {
                materialIconOff = new GUIContent(EditorGUIUtility.IconContent("d_Material On Icon"));
                materialIconOff.tooltip = "Swap Preview Mesh Material";
            }
        }

        void OnDestroy()
        {
            EditorApplication.contextualPropertyMenu -= OnPropertyContextMenu;
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("de672589595164d43bfb622a18720ba6");
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
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Spawnables");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            Toggle useQueryToggle = tree.Q<Toggle>("useQueryToggle");
            PropertyField crateQuery = tree.Q<PropertyField>("crateQuery");
            PropertyField spawnableCrateReference = tree.Q<PropertyField>("spawnableCrateReference");
            if (serializedObject.FindProperty("policyData") == null)
            {
                tree.Q<PropertyField>("policyData").style.display = DisplayStyle.None;
            }

            useQueryToggle.RegisterValueChangedCallback((evt) =>
            {
                useQueryToggle.style.display = DisplayStyle.None;
                spawnableCrateReference.style.display = DisplayStyle.Flex;
            });
            useQueryToggle.style.display = DisplayStyle.None;
            spawnableCrateReference.style.display = DisplayStyle.Flex;
            IMGUIContainer imguiRuntimeDebugContainer = tree.Q<IMGUIContainer>("imguiRuntimeDebugContainer");
#if false
#endif
            ToolbarToggle showPreviewMeshToolbarToggle = tree.Q<ToolbarToggle>("showPreviewMeshToolbarToggle");
            Image showPreviewMeshIconImage = new Image
            {
                image = previewMeshGizmoIcon.image
            };
            showPreviewMeshToolbarToggle.Add(showPreviewMeshIconImage);
            showPreviewMeshToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                CrateSpawner.showPreviewMesh = showPreviewMeshToolbarToggle.value;
                InternalEditorUtility.RepaintAllViews();
            });
            ToolbarToggle showColliderBoundsToolbarToggle = tree.Q<ToolbarToggle>("showColliderBoundsToolbarToggle");
            Image showColliderBoundsIconImage = new Image
            {
                image = colliderBoundsGizmoIcon.image
            };
            showColliderBoundsToolbarToggle.Add(showColliderBoundsIconImage);
            showColliderBoundsToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                CrateSpawner.showColliderBounds = showColliderBoundsToolbarToggle.value;
                InternalEditorUtility.RepaintAllViews();
            });
            ToolbarToggle showLitMaterialPreviewToolbarToggle = tree.Q<ToolbarToggle>("showLitMaterialPreviewToolbarToggle");
            Image showLitMaterialPreviewIconImage = new Image
            {
                image = materialIconOff.image
            };
            showLitMaterialPreviewToolbarToggle.Add(showLitMaterialPreviewIconImage);
            showLitMaterialPreviewToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                CrateSpawner.showLitMaterialPreview = showLitMaterialPreviewToolbarToggle.value;
                InternalEditorUtility.RepaintAllViews();
                if (showLitMaterialPreviewToolbarToggle.value)
                {
                    showLitMaterialPreviewIconImage.image = materialIconOff.image;
                }
                else
                {
                    showLitMaterialPreviewIconImage.image = materialIconOn.image;
                }
            });
            SliderInt gizmoVisRangeSlider = tree.Q<SliderInt>("gizmoVisRangeSlider");
            gizmoVisRangeSlider.RegisterValueChangedCallback(evt =>
            {
                CrateSpawner.gizmoVisRange = gizmoVisRangeSlider.value;
            });
            showPreviewMeshToolbarToggle.SetValueWithoutNotify(CrateSpawner.showPreviewMesh);
            showColliderBoundsToolbarToggle.SetValueWithoutNotify(CrateSpawner.showColliderBounds);
            showLitMaterialPreviewToolbarToggle.SetValueWithoutNotify(CrateSpawner.showLitMaterialPreview);
            gizmoVisRangeSlider.SetValueWithoutNotify((int)CrateSpawner.gizmoVisRange);
            return tree;
        }

        void OnPropertyContextMenu(GenericMenu menu, SerializedProperty property)
        {
            if (property.type != "CrateQuery")
                return;
            menu.AddItem(new GUIContent("Run Query"), false, () =>
            {
                foreach (var targetObject in serializedObject.targetObjects)
                {
                    if (targetObject is CrateSpawner spawner)
                    {
                        if (spawner.useQuery)
                            spawner.crateQuery.RunQuery();
                    }
                }
            });
        }

        [MenuItem("GameObject/MarrowSDK/Crate Spawner", priority = 1)]
        private static void MenuCreateSpawner(MenuCommand menuCommand)
        {
            GameObject go = CrateSpawner.EditorCreateCrateSpawner();
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            Selection.activeObject = go;
            bool overlayShown = false;
            bool overlayCollapsed = false;
            AWSpawnerOverlayToolbar.DoWithInstances(instance => overlayShown = instance.displayed);
            AWSpawnerOverlayToolbar.DoWithInstances(instance => overlayCollapsed = instance.collapsed);
            if (overlayShown == false)
            {
                if (UnityEngine.Object.FindObjectsOfType<CrateSpawner>().Length == 1)
                {
                    AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.displayed = true);
                    AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
                }
            }

            if (overlayCollapsed == true)
            {
                if (UnityEngine.Object.FindObjectsOfType<CrateSpawner>().Length == 1)
                {
                    AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
                }
            }
        }
    }
}