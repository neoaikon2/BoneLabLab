using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		public Transform rootNode;

		[Range(0f, 1f)]
		public float spineStiffness;

		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		private Vector3 offset;

		public IKEffector bodyEffector => null;

		public IKEffector leftShoulderEffector => null;

		public IKEffector rightShoulderEffector => null;

		public IKEffector leftThighEffector => null;

		public IKEffector rightThighEffector => null;

		public IKEffector leftHandEffector => null;

		public IKEffector rightHandEffector => null;

		public IKEffector leftFootEffector => null;

		public IKEffector rightFootEffector => null;

		public FBIKChain leftArmChain => null;

		public FBIKChain rightArmChain => null;

		public IKMappingLimb leftLegMapping => null;

		public IKMappingLimb rightLegMapping => null;

		public Vector3 pullBodyOffset { get; private set; }

		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		public override bool IsValid(ref string message)
		{
			return false;
		}

		public void SetToReferences(BipedReferences references, Transform rootNode = null)
		{
		}

		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		private static bool Contains(Transform[] array, Transform transform)
		{
			return false;
		}

		protected override void ReadPose()
		{
		}

		private void PullBody()
		{
		}

		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		protected override void ApplyBendConstraints()
		{
		}

		protected override void WritePose()
		{
		}
	}
}
