using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		public Transform bone;

		[Range(0f, 1f)]
		public float maintainRotationWeight;

		private BoneMap boneMap;

		public override bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		public IKMappingBone()
		{
		}

		public IKMappingBone(Transform bone)
		{
		}

		public void StoreDefaultLocalState()
		{
		}

		public void FixTransforms()
		{
		}

		public override void Initiate(IKSolverFullBody solver)
		{
		}

		public void ReadPose()
		{
		}

		public void WritePose(float solverWeight)
		{
		}
	}
}
