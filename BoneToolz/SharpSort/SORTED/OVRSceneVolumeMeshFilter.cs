using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_volume_mesh_filter")]
[RequireComponent(typeof(MeshFilter))]
public class OVRSceneVolumeMeshFilter : MonoBehaviour
{
	private struct GetTriangleMeshCountsJob : IJob
	{
		public OVRSpace Space;

		[WriteOnly]
		public NativeArray<int> Results;

		public void Execute()
		{
		}
	}

	private struct GetTriangleMeshJob : IJob
	{
		public OVRSpace Space;

		[WriteOnly]
		public NativeArray<Vector3> Vertices;

		[WriteOnly]
		public NativeArray<int> Triangles;

		public void Execute()
		{
		}
	}

	private struct PopulateMeshDataJob : IJob
	{
		[ReadOnly]
		public NativeArray<Vector3> Vertices;

		[ReadOnly]
		public NativeArray<int> Triangles;

		[WriteOnly]
		public Mesh.MeshData MeshData;

		public void Execute()
		{
		}
	}

	private struct BakeMeshJob : IJob
	{
		public int MeshID;

		public bool Convex;

		public void Execute()
		{
		}
	}
	private Mesh _mesh;

	private MeshFilter _meshFilter;

	public bool IsCompleted { get; private set; }

	private void Start()
	{
	}
	private IEnumerator CreateVolumeMesh()
	{
		return null;
	}

	private static bool IsJobDone(JobHandle job)
	{
		return false;
	}
}
