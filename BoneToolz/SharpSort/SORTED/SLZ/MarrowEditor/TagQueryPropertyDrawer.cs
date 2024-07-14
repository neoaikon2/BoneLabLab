 
 
using UnityEditor;
using UnityEngine;
using SLZ.Marrow.Warehouse;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    [CustomPropertyDrawer(typeof(TagQuery))]
    public class TagQueryPropertyDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var container = new VisualElement();
            container.style.flexDirection = FlexDirection.Row;
            var includeField = new Toggle();
            var tagField = new PropertyField(property.FindPropertyRelative("_boneTag"));
            includeField.value = !property.FindPropertyRelative("_invert").boolValue;
            includeField.RegisterValueChangedCallback(evt =>
            {
                property.serializedObject.Update();
                property.FindPropertyRelative("_invert").boolValue = !evt.newValue;
                property.serializedObject.ApplyModifiedProperties();
            });
            includeField.tooltip = "Include";
            includeField.style.paddingRight = EditorGUIUtility.singleLineHeight / 4f;
            tagField.style.flexShrink = 0;
            tagField.style.flexGrow = 1;
            container.Add(includeField);
            container.Add(tagField);
            return container;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            var amountRect = new Rect(position.x, position.y, EditorGUIUtility.singleLineHeight, position.height);
            var unitRect = new Rect(position.x + EditorGUIUtility.singleLineHeight + 5f, position.y, position.width - (EditorGUIUtility.singleLineHeight + 5f), position.height);
            EditorGUI.PropertyField(amountRect, property.FindPropertyRelative("_invert"), new GUIContent("", "Exclude"));
            EditorGUI.PropertyField(unitRect, property.FindPropertyRelative("_boneTag"), new GUIContent("", "Enable UI Toolkit Default Inspector"));
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}