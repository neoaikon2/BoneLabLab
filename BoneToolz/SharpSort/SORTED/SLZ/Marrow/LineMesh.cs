using System.Diagnostics;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow
{
	public class LineMesh : MonoBehaviour
	{
		[Conditional("UNITY_EDITOR")]
		private static void Initialize()
		{
		}

		[Conditional("UNITY_EDITOR")]
		private static void Uninitialize()
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float duration = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float time, float duration)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(Vector3 position, Quaternion rotation, float duration = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(RigidTransform t, float duration = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 position, Quaternion rotation, Vector3 halfExtends, Color color = default(Color), float duration = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, int segments = 16, float duration = 0f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawConfigJoint(ConfigurableJoint joint, Quaternion startRotation, float scale = 1f)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private static void DrawJointAnchor(SimpleTransform anchorT, float scale)
		{
		}
	}
}
