using System.Diagnostics;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow
{
	public class DebugDraw : MonoBehaviour
	{
		[Conditional("UNITY_EDITOR")]
		public static void DrawText(string text, Vector3 position, Color color, int size = 36)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float time = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, int segments = 16, float time = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 position, Color color = default(Color), float time = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(Transform transform, float time = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(SimpleTransform st, float time = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(Vector3 position, Quaternion rotation, float time = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawLog(string text, Vector3 position, float time = 1f, float scale = 1f)
		{
		}
	}
}
