using System;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	public class BipedReferences
	{
		public struct AutoDetectParams
		{
			public bool legsParentInSpine;

			public bool includeEyes;

			public static AutoDetectParams Default => default(AutoDetectParams);

			public AutoDetectParams(bool _legsParentInSpine, bool _includeEyes)
			{
				legsParentInSpine = _legsParentInSpine;
				includeEyes = _includeEyes;
			}
		}

		public Transform root;

		public Transform pelvis;

		public Transform leftThigh;

		public Transform leftCalf;

		public Transform leftFoot;

		public Transform rightThigh;

		public Transform rightCalf;

		public Transform rightFoot;

		public Transform leftUpperArm;

		public Transform leftForearm;

		public Transform leftHand;

		public Transform rightUpperArm;

		public Transform rightForearm;

		public Transform rightHand;

		public Transform head;

		public Transform[] spine;

		public Transform[] eyes;

		public virtual bool isFilled => false;

		public bool isEmpty => false;

		public virtual bool IsEmpty(bool includeRoot)
		{
			return false;
		}

		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return false;
		}

		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return false;
		}

		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return false;
		}

		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return false;
		}

		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return false;
		}

		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return false;
		}

		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return false;
		}

		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return false;
		}

		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return false;
		}

		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return false;
		}

		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return 0f;
		}
	}
}
