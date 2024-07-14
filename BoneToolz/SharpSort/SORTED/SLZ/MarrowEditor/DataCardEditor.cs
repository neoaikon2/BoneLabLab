 
 
using UnityEditor;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(DataCard))]
    [CanEditMultipleObjects]
    public class DataCardEditor : ScannableEditor
    {
        protected DataCard dataCard = null;
        public override void OnEnable()
        {
            base.OnEnable();
            dataCard = serializedObject.targetObject as DataCard;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();
            EditorGUI.BeginChangeCheck();
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.ObjectField("Pallet", dataCard.Pallet, typeof(Pallet), false);
            EditorGUI.EndDisabledGroup();
            if (EditorGUI.EndChangeCheck())
            {
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}