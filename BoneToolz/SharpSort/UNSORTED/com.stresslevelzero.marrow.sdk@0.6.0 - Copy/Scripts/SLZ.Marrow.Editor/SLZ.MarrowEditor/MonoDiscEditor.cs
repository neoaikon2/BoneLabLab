using System;
 
using System.Collections.Generic;
 
using System.Reflection;
using Cysharp.Threading.Tasks;
using UnityEditor;
using SLZ.Marrow.Warehouse;
using UnityEngine;
 
using Object = UnityEngine.Object;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(MonoDisc))]
    [CanEditMultipleObjects]
    public class MonoDiscEditor : DataCardEditor
    {
        private SerializedProperty audioClipProperty;
        private PreviewRenderUtility previewRenderUtility;
        private Editor audioClipEditor;
        private ObjectPreview objectPreview;
        private bool initialized = false;
        private List<AudioClip> clips;
        public override bool ShowUnlockableRedactedFields()
        {
            return true;
        }

        public override void OnEnable()
        {
            base.OnEnable();
            audioClipProperty = serializedObject.FindProperty("_audioClip");
            InitializeObjectPreviewAsync().Forget();
        }

        public override void OnDisable()
        {
            base.OnDisable();
            ObjectPreviewCleanup();
        }

        private void ObjectPreviewCleanup()
        {
            if (objectPreview != null)
            {
                objectPreview.Cleanup();
            }
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();
            using (var check = new EditorGUI.ChangeCheckScope())
            {
                LockedPropertyField(audioClipProperty, false);
                if (check.changed)
                {
                    ObjectPreviewCleanup();
                }
            }

            serializedObject.ApplyModifiedProperties();
        }

        private async UniTaskVoid InitializeObjectPreviewAsync()
        {
            List<Object> audioClipObjects = new List<Object>();
            var loadTasks = new List<UniTask<AudioClip>>();
            foreach (var target in targets)
            {
                var monoDisc = target as MonoDisc;
                if (monoDisc != null)
                {
                    if (monoDisc.AudioClip.EditorAsset != null)
                    {
                        audioClipObjects.Add(monoDisc.AudioClip.EditorAsset);
                    }
                    else
                    {
                        loadTasks.Add(monoDisc.AudioClip.LoadAssetAsync());
                    }
                }
            }

            if (loadTasks.Count > 0)
                QueueEditorUpdateLoop.StartEditorUpdateLoop();
            Object[] loadedAudioClips = await UniTask.WhenAll(loadTasks);
            audioClipObjects.AddRange(loadedAudioClips);
            if (loadTasks.Count > 0)
                QueueEditorUpdateLoop.StopEditorUpdateLoop();
            objectPreview = new AudioClipPreview();
            objectPreview.Initialize(audioClipObjects.ToArray());
            initialized = true;
        }

        public override bool HasPreviewGUI()
        {
            return objectPreview != null && objectPreview.HasPreviewGUI();
        }

        public override void DrawPreview(Rect previewArea)
        {
            if (objectPreview != null)
                objectPreview.DrawPreview(previewArea);
        }

        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
            if (initialized && objectPreview != null)
            {
                objectPreview.OnPreviewGUI(r, background);
            }
        }

        public override void OnPreviewSettings()
        {
            base.OnPreviewSettings();
            if (initialized && objectPreview != null)
            {
                objectPreview.OnPreviewSettings();
            }
        }
    }

    [CustomPreview(typeof(AudioClip))]
    public class AudioClipPreview : ObjectPreview
    {
        private Editor dummyEditor;
        private MethodInfo reflectedEditorOnDisable;
        public override void Initialize(Object[] targets)
        {
            base.Initialize(targets);
            var audioClipInspectorType = Type.GetType("UnityEditor.AudioClipInspector, UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
            reflectedEditorOnDisable = audioClipInspectorType.GetMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public);
            dummyEditor = Editor.CreateEditor(targets);
        }

        public override void Cleanup()
        {
            base.Cleanup();
            if (dummyEditor != null)
            {
                reflectedEditorOnDisable.Invoke(dummyEditor, null);
            }
        }

        public override bool HasPreviewGUI()
        {
            return ValidTargets();
        }

        private bool ValidTargets()
        {
            bool valid = m_Targets.Length > 0;
            foreach (var target in m_Targets)
            {
                valid &= target != null;
            }

            return valid;
        }

        public override void OnPreviewSettings()
        {
            base.OnPreviewSettings();
            if (dummyEditor != null)
            {
                dummyEditor.OnPreviewSettings();
            }
        }

        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
            if (dummyEditor != null && ValidTargets())
            {
                dummyEditor.OnPreviewGUI(r, background);
            }
        }
    }
}