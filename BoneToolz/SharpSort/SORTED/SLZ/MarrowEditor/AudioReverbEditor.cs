#if UNITY_EDITOR
using SLZ.Marrow.Data;
using UnityEditor;
using UnityEngine;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(AudioReverbData))]
    public class AudioReverbEditor : Editor
    {
    }
}
#endif
