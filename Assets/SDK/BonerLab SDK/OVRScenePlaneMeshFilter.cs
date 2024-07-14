using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_plane_mesh_filter")]
[RequireComponent(typeof(MeshFilter))]
public class OVRScenePlaneMeshFilter : MonoBehaviour
{
	private struct TriangulateBoundaryJob : IJob
	{
		private struct NList : IDisposable
		{
			private NativeArray<int> _data;

			public int Count { get; private set; }

			public int this[int index] => 0;

			public NList(int capacity, Allocator allocator)
			{
				Count = 0;
				_data = default(NativeArray<int>);
			}

			public void RemoveAt(int index)
			{
			}

			public int GetAt(int index)
			{
				return 0;
			}

			public void Dispose()
			{
			}
		}

		[ReadOnly]
		public NativeArray<Vector2> Boundary;

		[WriteOnly]
		public NativeArray<int> Triangles;

		public void Execute()
		{
		}

		private static float Cross(Vector2 a, Vector2 b)
		{
			return 0f;
		}

		private static bool PointInTriangle(Vector2 p, Vector2 a, Vector2 b, Vector2 c)
		{
			return false;
		}
	}

	private MeshFilter _meshFilter;

	private Mesh _mesh;

	private JobHandle? _jobHandle;

	private bool _meshRequested;

	private NativeArray<Vector2> _boundary;

	private NativeArray<int> _triangles;

	private void Start()
	{
	}

	internal void ScheduleMeshGeneration()
	{
	}

	private void Update()
	{
	}

	internal void RequestMeshGeneration()
	{
	}

	private void OnDisable()
	{
	}
}
