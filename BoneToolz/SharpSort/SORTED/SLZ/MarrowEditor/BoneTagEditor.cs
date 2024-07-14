 
 
 
using UnityEditor;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(BoneTag))]
    [CanEditMultipleObjects]
    public class BoneTagEditor : DataCardEditor
    {
        public override bool ShowUnlockableRedactedFields()
        {
            return false;
        }
    }
}