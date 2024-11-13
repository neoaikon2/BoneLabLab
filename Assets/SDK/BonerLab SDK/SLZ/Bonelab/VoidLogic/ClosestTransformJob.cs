using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace SLZ.Bonelab.VoidLogic
{
	[BurstCompile]
	public struct ClosestTransformJob : IJobParallelForTransform
	{
		[ReadOnly]
		public float3 targetPosition;

		public NativeArray<float> distances;

		public void Execute(int index, TransformAccess transform)
		{
		}
	}
}
