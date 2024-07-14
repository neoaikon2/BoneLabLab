using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	public struct BipedRagdollReferences
	{
		public Transform root;

		public Transform hips;

		public Transform spine;

		public Transform chest;

		public Transform head;

		public Transform leftUpperLeg;

		public Transform leftLowerLeg;

		public Transform leftFoot;

		public Transform rightUpperLeg;

		public Transform rightLowerLeg;

		public Transform rightFoot;

		public Transform leftUpperArm;

		public Transform leftLowerArm;

		public Transform leftHand;

		public Transform rightUpperArm;

		public Transform rightLowerArm;

		public Transform rightHand;

		public bool IsValid(ref string msg)
		{
			return false;
		}

		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return false;
		}

		public Transform[] GetRagdollTransforms()
		{
			return null;
		}
	}
}
