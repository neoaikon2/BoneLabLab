using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		public enum BoneMapType
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}

		public Transform parentBone;

		public Transform bone1;

		public Transform bone2;

		public Transform bone3;

		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Range(0f, 1f)]
		public float weight;

		private BoneMap boneMapParent;

		private BoneMap boneMap1;

		private BoneMap boneMap2;

		private BoneMap boneMap3;

		public override bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		public IKMappingLimb()
		{
		}

		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
		}

		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
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

		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
}
