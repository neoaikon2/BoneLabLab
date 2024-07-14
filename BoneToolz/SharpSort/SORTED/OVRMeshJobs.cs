using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class OVRMeshJobs
{
	public struct TransformToUnitySpaceJob : IJobParallelFor
	{
		public NativeArray<Vector3> Vertices;

		public NativeArray<Vector3> Normals;

		public NativeArray<Vector2> UV;

		public NativeArray<BoneWeight> BoneWeights;

		public NativeArray<OVRPlugin.Vector3f> MeshVerticesPosition;

		public NativeArray<OVRPlugin.Vector3f> MeshNormals;

		public NativeArray<OVRPlugin.Vector2f> MeshUV;

		public NativeArray<OVRPlugin.Vector4f> MeshBoneWeights;

		public NativeArray<OVRPlugin.Vector4s> MeshBoneIndices;

		public void Execute(int index)
		{
		}
	}

	public struct TransformTrianglesJob : IJobParallelFor
	{
		public NativeArray<uint> Triangles;

		[ReadOnly]
		public NativeArray<short> MeshIndices;

		public int NumIndices;

		public void Execute(int index)
		{
		}
	}

	public struct NativeArrayHelper<T> : IDisposable where T : struct
	{
		public NativeArray<T> UnityNativeArray;

		private GCHandle _handle;

		public NativeArrayHelper(T[] ovrArray, int length)
		{
			UnityNativeArray = default(NativeArray<T>);
			_handle = default(GCHandle);
		}

		public void Dispose()
		{
		}
	}
}
