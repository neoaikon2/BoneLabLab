#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
    public class DrawGizmoHelper
    {
        public enum ArrowType
        {
            Default,
            Double
        }

        public static void Arrow(Vector3 start, Vector3 end, Vector3 normal = default(Vector3), ArrowType type = ArrowType.Default, float arrowHeadLength = 0.2f, float arrowHeadAngle = 30.0f)
        {
            if (normal.sqrMagnitude <= 0)
            {
                normal = Vector3.up;
            }

            Vector3 pos = start;
            Vector3 direction = end - start;
            Vector3 headRight = Vector3.zero;
            Vector3 headLeft = Vector3.zero;
            if (direction != Vector3.zero)
            {
                headRight = Quaternion.LookRotation(direction, normal) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
                headLeft = Quaternion.LookRotation(direction, normal) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            }

            Gizmos.DrawRay(pos + direction, headRight * arrowHeadLength);
            Gizmos.DrawRay(pos + direction, headLeft * arrowHeadLength);
            switch (type)
            {
                case ArrowType.Default:
                    Gizmos.DrawRay(pos, direction);
                    break;
                case ArrowType.Double:
                    Gizmos.DrawRay(pos, direction);
                    Gizmos.DrawRay(pos, -headRight * arrowHeadLength);
                    Gizmos.DrawRay(pos, -headLeft * arrowHeadLength);
                    break;
            }
        }

        public static void DrawText(string text, Vector3 position = default(Vector3))
        {
            Handles.BeginGUI();
            GUI.color = Gizmos.color;
            position = Gizmos.matrix.MultiplyPoint(position);
            var view = SceneView.currentDrawingSceneView;
            if (view == null)
                return;
            Vector3 screenPos = view.camera.WorldToScreenPoint(position);
            if (screenPos.y < 0 || screenPos.y > Screen.height || screenPos.x < 0 || screenPos.x > Screen.width || screenPos.z < 0)
            {
                Handles.EndGUI();
                return;
            }

            Vector2 size = GUI.skin.label.CalcSize(new GUIContent(text));
            GUI.Label(new Rect(screenPos.x - (size.x / 2), view.position.height - screenPos.y - (size.y * 2f), size.x, size.y), text);
            Handles.EndGUI();
        }
    }
}
#endif
