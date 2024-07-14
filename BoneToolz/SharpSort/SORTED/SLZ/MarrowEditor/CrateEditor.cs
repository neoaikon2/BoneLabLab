 
 
 
 
using UnityEngine;
using UnityEditor;
using SLZ.Marrow.Warehouse;
 
using UnityEditor.Callbacks;
using UnityEditor.SceneManagement;
 
 
 
using System;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(CrateT<>), true)]
    public class CrateTEditor : CrateEditor
    {
    }

    [CustomEditor(typeof(Crate))]
    [CanEditMultipleObjects]
    public class CrateEditor : ScannableEditor
    {
        SerializedProperty tagsProperty;
        SerializedProperty assetReferenceProperty;
        protected SerializedProperty additionalAssetReferencesProperty;
        protected Crate crate = null;
        Crate script;
        protected virtual string AssetReferenceDisplayName
        {
            get
            {
                return "Asset Reference";
            }
        }

        protected virtual string AdditionalAssetReferencesDisplayName
        {
            get
            {
                return "Additional Asset References";
            }
        }

        public override void OnEnable()
        {
            base.OnEnable();
            tagsProperty = serializedObject.FindProperty("_tags");
            assetReferenceProperty = serializedObject.FindProperty("_mainAsset");
            additionalAssetReferencesProperty = serializedObject.FindProperty("_additionalAssetReferences");
            crate = serializedObject.targetObject as Crate;
            script = (Crate)target;
        }

        public override void OnDisable()
        {
            base.OnDisable();
        }

        [OnOpenAsset]
        public static bool OpenAssetHandler(int instanceID, int line)
        {
            var obj = EditorUtility.InstanceIDToObject(instanceID);
            if (obj is Crate crate && crate.MainAsset.EditorAsset != null)
            {
                switch (crate)
                {
                    case LevelCrate levelCrate:
                        if (AssetDatabase.CanOpenAssetInEditor(levelCrate.MainAsset.EditorAsset.GetInstanceID()))
                        {
                            if (levelCrate.MultiScene)
                            {
                                if (!EditorApplication.isPlaying && EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                                {
                                    EditorSceneManager.RestoreSceneManagerSetup(levelCrate.ToEditorSceneSetups());
                                    Selection.activeObject = crate;
                                }

                                return true;
                            }
                            else
                            {
                                AssetDatabase.OpenAsset(levelCrate.MainAsset.EditorAsset);
                                Selection.activeObject = crate;
                                return true;
                            }
                        }

                        break;
                    case SpawnableCrate spawnableCrate:
                    default:
                        if (AssetDatabase.CanOpenAssetInEditor(crate.MainAsset.EditorAsset.GetInstanceID()))
                        {
                            AssetDatabase.OpenAsset(crate.MainAsset.EditorAsset);
                            Selection.activeObject = crate;
                            return true;
                        }

                        break;
                }
            }

            return false;
        }

        public virtual void OnInspectorGUIBody()
        {
        }

        public virtual void OnInspectorGUIPackedAssets()
        {
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();
            if (!string.IsNullOrEmpty(AssetReferenceDisplayName))
                EditorGUILayout.PropertyField(assetReferenceProperty, new GUIContent(AssetReferenceDisplayName));
            else
                EditorGUILayout.PropertyField(assetReferenceProperty);
            EditorGUI.BeginChangeCheck();
            OnInspectorGUIBody();
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.ObjectField("Pallet", crate.Pallet, typeof(Pallet), false);
            EditorGUI.EndDisabledGroup();
            bool tagIsNull = false;
            if (script.Tags != null && script.Tags.Count > 0)
            {
                for (var t = 0; t < script.Tags.Count; t++)
                {
                    if (script.Tags[t].ToLower().ToString() == "null.empty.barcode")
                    {
                        tagIsNull = true;
                    }

                    if (String.IsNullOrEmpty(script.Tags[t]))
                    {
                        tagIsNull = true;
                        script.Tags[t] = "null.empty.barcode";
                    }
                }
            }

            if (tagIsNull)
            {
                EditorGUILayout.HelpBox("A Tag on this Crate is null or empty.", MessageType.Error);
            }

            bool bonetagIsNull = false;
            if (script.BoneTags != null && script.BoneTags.Tags != null && script.BoneTags.Tags.Count > 0)
            {
                for (var bt = 0; bt < script.BoneTags.Tags.Count; bt++)
                {
                    if (script.BoneTags.Tags[bt] != null && script.BoneTags.Tags[bt].Barcode != null && script.BoneTags.Tags[bt].Barcode.ToString().ToLower() == "null.empty.barcode")
                    {
                        bonetagIsNull = true;
                    }

                    if (script.BoneTags.Tags[bt] != null && script.BoneTags.Tags[bt].Barcode != null && String.IsNullOrEmpty(script.BoneTags.Tags[bt].Barcode))
                    {
                        bonetagIsNull = true;
                        script.BoneTags.Tags[bt].Barcode = (Barcode)"null.empty.barcode";
                    }
                }
            }

            if (bonetagIsNull)
            {
                EditorGUILayout.HelpBox("A BoneTag on this Crate is null or empty.", MessageType.Error);
            }

            LockedPropertyField(tagsProperty, false);
            if (EditorGUI.EndChangeCheck())
            {
            }

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Packed Assets", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope())
            {
                if (GUILayout.Button("Generate Packed Assets", GUILayout.ExpandWidth(false)))
                {
                    foreach (var tar in targets)
                    {
                        if (tar is Crate tarCrate)
                        {
                            tarCrate.GeneratePackedAssets();
                        }
                    }
                }

                OnInspectorGUIPackedAssets();
            }

            serializedObject.ApplyModifiedProperties();
        }
    }

    [InitializeOnLoad]
    static class CrateEditorGUI
    {
        static CrateEditorGUI()
        {
            Editor.finishedDefaultHeaderGUI += OnPostHeaderGUI;
        }

        static void OnPostHeaderGUI(Editor editor)
        {
            using (new GUILayout.VerticalScope())
            {
                if (editor != null && editor.targets.Length > 0)
                {
                    UnityEngine.Object target = editor.target;
                    if (target != null && AssetWarehouse.ready)
                    {
                        if (AssetWarehouse.Instance.EditorObjectCrateLookup.TryGetValue(target, out Crate crate))
                        {
                            EditorGUILayout.ObjectField("Crate", crate, crate.GetType(), false);
                        }
                    }
                }
            }
        }
    }
}