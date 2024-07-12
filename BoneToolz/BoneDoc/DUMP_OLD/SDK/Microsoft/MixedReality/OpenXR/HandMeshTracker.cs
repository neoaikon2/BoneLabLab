using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	public class HandMeshTracker
	{
		private readonly NativeLibToken m_token;

		private readonly Handedness m_handedness;

		private Vector3[] m_handMeshVertices;

		private Vector3[] m_handMeshNormals;

		private int[] m_handMeshIndices;

		private Mesh m_currentMesh;

		private uint m_indexBufferKey;

		private ulong m_vertexBufferkey;

		public static HandMeshTracker Left { get; }

		public static HandMeshTracker Right { get; }

		private HandMeshTracker(Handedness trackerHandedness)
			: base()
		{
		}

		public bool TryLocateHandMesh(FrameTime frameTime, [Out] Pose pose, HandPoseType handPoseType = HandPoseType.Tracked)
		{
			return default(bool);
		}

		public bool TryGetHandMesh(FrameTime frameTime, Mesh handMesh, HandPoseType handPoseType = HandPoseType.Tracked)
		{
			return default(bool);
		}
	}
}
