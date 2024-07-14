using System;
using System.Linq;
using UnityEditor;

namespace SLZ.MarrowEditor
{
    public static class SerializedPropertyExtensions
    {
        public static bool TryFindParentArrayProperty(this SerializedProperty serializedProperty, out SerializedProperty parentProperty)
        {
            var propertyPaths = serializedProperty.propertyPath.Split('.');
            parentProperty = default;
            if (propertyPaths.Length > 1 && propertyPaths[^2] == "Array")
            {
                var arrayPath = string.Join('.', propertyPaths.SkipLast(1));
                var arrayProp = serializedProperty.serializedObject.FindProperty(arrayPath);
                if (arrayProp != null)
                {
                    parentProperty = arrayProp;
                    return true;
                }
            }

            return false;
        }

        public static SerializedProperty FindAutoProperty(this SerializedObject @this, string name)
        {
            var fieldName = string.Create("<>k__BackingField".Length + name.Length, name, CreateFieldName);
            return @this.FindProperty(fieldName);
        }

        public static SerializedProperty FindAutoPropertyRelative(this SerializedProperty @this, string name)
        {
            var fieldName = string.Create("<>k__BackingField".Length + name.Length, name, CreateFieldName);
            return @this.FindPropertyRelative(fieldName);
        }

        private static void CreateFieldName(Span<char> fieldName, string name)
        {
            fieldName[0] = '<';
            name.AsSpan().CopyTo(fieldName[1..]);
            var offset = name.Length + 1;
            ">k__BackingField".AsSpan().CopyTo(fieldName[offset..]);
        }
    }
}