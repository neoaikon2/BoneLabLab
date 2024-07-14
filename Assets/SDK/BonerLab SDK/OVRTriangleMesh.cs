using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public readonly struct OVRTriangleMesh : IOVRAnchorComponent<OVRTriangleMesh>, IEquatable<OVRTriangleMesh>
{
	private struct GetMeshJob : IJob
	{
		public ulong Space;

		public NativeArray<Vector3> Positions;

		public NativeArray<int> Indices;

		public void Execute()
		{
		}
	}

	private struct Triangle
	{
		public int A;

		public int B;

		public int C;
	}

	private struct FlipTriangleWindingJob : IJobParallelFor
	{
		public NativeArray<Triangle> Triangles;

		public void Execute(int index)
		{
		}
	}

	private struct NegateXJob : IJobParallelFor
	{
		public NativeArray<Vector3> Positions;

		public void Execute(int index)
		{
		}
	}

	public static readonly OVRTriangleMesh Null;

	private OVRPlugin.SpaceComponentType IOVRAnchorComponent_003COVRTriangleMesh_003E_002EType => default(OVRPlugin.SpaceComponentType);

	private ulong IOVRAnchorComponent_003COVRTriangleMesh_003E_002EHandle => 0uL;

	public bool IsNull => false;

	public bool IsEnabled => false;

	internal OVRPlugin.SpaceComponentType Type => default(OVRPlugin.SpaceComponentType);

	internal ulong Handle { get; }

	bool IOVRAnchorComponent<OVRTriangleMesh>.IsNull => throw new NotImplementedException();

	bool IOVRAnchorComponent<OVRTriangleMesh>.IsEnabled => throw new NotImplementedException();

	OVRPlugin.SpaceComponentType IOVRAnchorComponent<OVRTriangleMesh>.Type => throw new NotImplementedException();

	ulong IOVRAnchorComponent<OVRTriangleMesh>.Handle => throw new NotImplementedException();

	private OVRTriangleMesh IOVRAnchorComponent_003COVRTriangleMesh_003E_002EFromAnchor(OVRAnchor anchor)
	{
		return default(OVRTriangleMesh);
	}

	private OVRTask<bool> IOVRAnchorComponent_003COVRTriangleMesh_003E_002ESetEnabledAsync(bool enabled, double timeout)
	{
		return default(OVRTask<bool>);
	}

	public bool Equals(OVRTriangleMesh other)
	{
		return false;
	}

	public static bool operator ==(OVRTriangleMesh lhs, OVRTriangleMesh rhs)
	{
		return false;
	}

	public static bool operator !=(OVRTriangleMesh lhs, OVRTriangleMesh rhs)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	private OVRTriangleMesh(OVRAnchor anchor)
	{
		Handle = 0uL;
	}

	public bool TryGetCounts(out int vertexCount, out int triangleCount)
	{
		vertexCount = default(int);
		triangleCount = default(int);
		return false;
	}

	public bool TryGetMeshRawUntransformed(NativeArray<Vector3> positions, NativeArray<int> indices)
	{
		return false;
	}

	public bool TryGetMesh(NativeArray<Vector3> positions, NativeArray<int> indices)
	{
		return false;
	}

	public JobHandle ScheduleGetMeshJob(NativeArray<Vector3> positions, NativeArray<int> indices, JobHandle dependencies = default(JobHandle))
	{
		return default(JobHandle);
	}

	public OVRTask<bool> SetEnabledAsync(bool enable, double timeout = 0)
	{
		throw new NotImplementedException();
	}

	OVRTask<bool> IOVRAnchorComponent<OVRTriangleMesh>.SetEnabledAsync(bool enable, double timeout)
	{
		throw new NotImplementedException();
	}

	OVRTriangleMesh IOVRAnchorComponent<OVRTriangleMesh>.FromAnchor(OVRAnchor anchor)
	{
		throw new NotImplementedException();
	}
}
