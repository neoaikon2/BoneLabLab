using System;
using System.Collections.Generic;
using UnityEngine;

public class OVRUnityHumanoidSkeletonRetargeter : OVRSkeleton
{
	public static class OVRHumanBodyBonesMappings
	{
		public enum BodySection
		{
			LeftLeg = 0,
			LeftFoot = 1,
			RightLeg = 2,
			RightFoot = 3,
			LeftArm = 4,
			LeftHand = 5,
			RightArm = 6,
			RightHand = 7,
			Hips = 8,
			Back = 9,
			Neck = 10,
			Head = 11
		}

		public enum FullBodyTrackingBoneId
		{
			FullBody_Start = 0,
			FullBody_Root = 0,
			FullBody_Hips = 1,
			FullBody_SpineLower = 2,
			FullBody_SpineMiddle = 3,
			FullBody_SpineUpper = 4,
			FullBody_Chest = 5,
			FullBody_Neck = 6,
			FullBody_Head = 7,
			FullBody_LeftShoulder = 8,
			FullBody_LeftScapula = 9,
			FullBody_LeftArmUpper = 10,
			FullBody_LeftArmLower = 11,
			FullBody_LeftHandWristTwist = 12,
			FullBody_RightShoulder = 13,
			FullBody_RightScapula = 14,
			FullBody_RightArmUpper = 15,
			FullBody_RightArmLower = 16,
			FullBody_RightHandWristTwist = 17,
			FullBody_LeftHandPalm = 18,
			FullBody_LeftHandWrist = 19,
			FullBody_LeftHandThumbMetacarpal = 20,
			FullBody_LeftHandThumbProximal = 21,
			FullBody_LeftHandThumbDistal = 22,
			FullBody_LeftHandThumbTip = 23,
			FullBody_LeftHandIndexMetacarpal = 24,
			FullBody_LeftHandIndexProximal = 25,
			FullBody_LeftHandIndexIntermediate = 26,
			FullBody_LeftHandIndexDistal = 27,
			FullBody_LeftHandIndexTip = 28,
			FullBody_LeftHandMiddleMetacarpal = 29,
			FullBody_LeftHandMiddleProximal = 30,
			FullBody_LeftHandMiddleIntermediate = 31,
			FullBody_LeftHandMiddleDistal = 32,
			FullBody_LeftHandMiddleTip = 33,
			FullBody_LeftHandRingMetacarpal = 34,
			FullBody_LeftHandRingProximal = 35,
			FullBody_LeftHandRingIntermediate = 36,
			FullBody_LeftHandRingDistal = 37,
			FullBody_LeftHandRingTip = 38,
			FullBody_LeftHandLittleMetacarpal = 39,
			FullBody_LeftHandLittleProximal = 40,
			FullBody_LeftHandLittleIntermediate = 41,
			FullBody_LeftHandLittleDistal = 42,
			FullBody_LeftHandLittleTip = 43,
			FullBody_RightHandPalm = 44,
			FullBody_RightHandWrist = 45,
			FullBody_RightHandThumbMetacarpal = 46,
			FullBody_RightHandThumbProximal = 47,
			FullBody_RightHandThumbDistal = 48,
			FullBody_RightHandThumbTip = 49,
			FullBody_RightHandIndexMetacarpal = 50,
			FullBody_RightHandIndexProximal = 51,
			FullBody_RightHandIndexIntermediate = 52,
			FullBody_RightHandIndexDistal = 53,
			FullBody_RightHandIndexTip = 54,
			FullBody_RightHandMiddleMetacarpal = 55,
			FullBody_RightHandMiddleProximal = 56,
			FullBody_RightHandMiddleIntermediate = 57,
			FullBody_RightHandMiddleDistal = 58,
			FullBody_RightHandMiddleTip = 59,
			FullBody_RightHandRingMetacarpal = 60,
			FullBody_RightHandRingProximal = 61,
			FullBody_RightHandRingIntermediate = 62,
			FullBody_RightHandRingDistal = 63,
			FullBody_RightHandRingTip = 64,
			FullBody_RightHandLittleMetacarpal = 65,
			FullBody_RightHandLittleProximal = 66,
			FullBody_RightHandLittleIntermediate = 67,
			FullBody_RightHandLittleDistal = 68,
			FullBody_RightHandLittleTip = 69,
			FullBody_LeftUpperLeg = 70,
			FullBody_LeftLowerLeg = 71,
			FullBody_LeftFootAnkleTwist = 72,
			FullBody_LeftFootAnkle = 73,
			FullBody_LeftFootSubtalar = 74,
			FullBody_LeftFootTransverse = 75,
			FullBody_LeftFootBall = 76,
			FullBody_RightUpperLeg = 77,
			FullBody_RightLowerLeg = 78,
			FullBody_RightFootAnkleTwist = 79,
			FullBody_RightFootAnkle = 80,
			FullBody_RightFootSubtalar = 81,
			FullBody_RightFootTransverse = 82,
			FullBody_RightFootBall = 83,
			FullBody_End = 84,
			NoOverride = 85,
			Remove = 86
		}

		public enum BodyTrackingBoneId
		{
			Body_Start = 0,
			Body_Root = 0,
			Body_Hips = 1,
			Body_SpineLower = 2,
			Body_SpineMiddle = 3,
			Body_SpineUpper = 4,
			Body_Chest = 5,
			Body_Neck = 6,
			Body_Head = 7,
			Body_LeftShoulder = 8,
			Body_LeftScapula = 9,
			Body_LeftArmUpper = 10,
			Body_LeftArmLower = 11,
			Body_LeftHandWristTwist = 12,
			Body_RightShoulder = 13,
			Body_RightScapula = 14,
			Body_RightArmUpper = 15,
			Body_RightArmLower = 16,
			Body_RightHandWristTwist = 17,
			Body_LeftHandPalm = 18,
			Body_LeftHandWrist = 19,
			Body_LeftHandThumbMetacarpal = 20,
			Body_LeftHandThumbProximal = 21,
			Body_LeftHandThumbDistal = 22,
			Body_LeftHandThumbTip = 23,
			Body_LeftHandIndexMetacarpal = 24,
			Body_LeftHandIndexProximal = 25,
			Body_LeftHandIndexIntermediate = 26,
			Body_LeftHandIndexDistal = 27,
			Body_LeftHandIndexTip = 28,
			Body_LeftHandMiddleMetacarpal = 29,
			Body_LeftHandMiddleProximal = 30,
			Body_LeftHandMiddleIntermediate = 31,
			Body_LeftHandMiddleDistal = 32,
			Body_LeftHandMiddleTip = 33,
			Body_LeftHandRingMetacarpal = 34,
			Body_LeftHandRingProximal = 35,
			Body_LeftHandRingIntermediate = 36,
			Body_LeftHandRingDistal = 37,
			Body_LeftHandRingTip = 38,
			Body_LeftHandLittleMetacarpal = 39,
			Body_LeftHandLittleProximal = 40,
			Body_LeftHandLittleIntermediate = 41,
			Body_LeftHandLittleDistal = 42,
			Body_LeftHandLittleTip = 43,
			Body_RightHandPalm = 44,
			Body_RightHandWrist = 45,
			Body_RightHandThumbMetacarpal = 46,
			Body_RightHandThumbProximal = 47,
			Body_RightHandThumbDistal = 48,
			Body_RightHandThumbTip = 49,
			Body_RightHandIndexMetacarpal = 50,
			Body_RightHandIndexProximal = 51,
			Body_RightHandIndexIntermediate = 52,
			Body_RightHandIndexDistal = 53,
			Body_RightHandIndexTip = 54,
			Body_RightHandMiddleMetacarpal = 55,
			Body_RightHandMiddleProximal = 56,
			Body_RightHandMiddleIntermediate = 57,
			Body_RightHandMiddleDistal = 58,
			Body_RightHandMiddleTip = 59,
			Body_RightHandRingMetacarpal = 60,
			Body_RightHandRingProximal = 61,
			Body_RightHandRingIntermediate = 62,
			Body_RightHandRingDistal = 63,
			Body_RightHandRingTip = 64,
			Body_RightHandLittleMetacarpal = 65,
			Body_RightHandLittleProximal = 66,
			Body_RightHandLittleIntermediate = 67,
			Body_RightHandLittleDistal = 68,
			Body_RightHandLittleTip = 69,
			Body_End = 70,
			NoOverride = 71,
			Remove = 72
		}

		public static readonly Dictionary<HumanBodyBones, Tuple<HumanBodyBones, HumanBodyBones>> BoneToJointPair;

		public static readonly Dictionary<HumanBodyBones, BodySection> BoneToBodySection;

		public static readonly Dictionary<BoneId, HumanBodyBones> FullBodyBoneIdToHumanBodyBone;

		public static readonly Dictionary<BoneId, HumanBodyBones> BoneIdToHumanBodyBone;

		public static readonly Dictionary<BoneId, Tuple<BoneId, BoneId>> FullBoneIdToJointPair;

		public static readonly Dictionary<BoneId, Tuple<BoneId, BoneId>> BoneIdToJointPair;
	}

	protected class OVRSkeletonMetadata
	{
		public class BoneData
		{
			public Transform OriginalJoint;

			public Vector3 FromPosition;

			public Vector3 ToPosition;

			public Transform JointPairStart;

			public Transform JointPairEnd;

			public Quaternion JointPairOrientation;

			public Quaternion? CorrectionQuaternion;

			public Transform ParentTransform;

			public bool DegenerateJoint;

			public BoneData()
			{
			}

			public BoneData(BoneData otherBoneData)
			{
			}
		}

		private readonly HumanBodyBones[] _boneEnumValues;

		public Dictionary<HumanBodyBones, BoneData> BodyToBoneData { get; }

		public OVRSkeletonMetadata(OVRSkeletonMetadata otherSkeletonMetaData)
		{
		}

		public OVRSkeletonMetadata(Animator animator)
		{
		}

		public OVRSkeletonMetadata(OVRSkeleton skeleton, bool useBindPose, Dictionary<BoneId, HumanBodyBones> customBoneIdToHumanBodyBone)
		{
		}

		public OVRSkeletonMetadata(OVRSkeleton skeleton, bool useBindPose, Dictionary<BoneId, HumanBodyBones> customBoneIdToHumanBodyBone, bool useFullBody)
		{
		}

		public void BuildBoneDataSkeleton(OVRSkeleton skeleton, bool useBindPose, Dictionary<BoneId, HumanBodyBones> customBoneIdToHumanBodyBone)
		{
		}

		public void BuildBoneDataSkeletonFullBody(OVRSkeleton skeleton, bool useBindPose, Dictionary<BoneId, HumanBodyBones> customBoneIdToHumanBodyBone)
		{
		}

		private void AssembleSkeleton(OVRSkeleton skeleton, bool useBindPose, Dictionary<BoneId, HumanBodyBones> customBoneIdToHumanBodyBone, bool useFullBody = false)
		{
		}

		private static OVRBone FindBoneWithBoneId(IList<OVRBone> bones, BoneId boneId)
		{
			return null;
		}

		private void BuildBoneData(Animator animator)
		{
		}

		public void BuildCoordinateAxesForAllBones()
		{
		}

		private Vector3 FixJointPairEndPositionHand(Vector3 jointPairEndPosition, HumanBodyBones humanBodyBone)
		{
			return default(Vector3);
		}

		private static Transform FindFirstChild(Transform startTransform, Transform currTransform)
		{
			return null;
		}

		private static Quaternion CreateQuaternionForBoneDataWithRightVec(Vector3 fromPosition, Vector3 toPosition, Vector3 rightVector)
		{
			return default(Quaternion);
		}

		private static Quaternion CreateQuaternionForBoneData(Vector3 fromPosition, Vector3 toPosition)
		{
			return default(Quaternion);
		}
	}

	[Serializable]
	public class JointAdjustment
	{
		public HumanBodyBones Joint;

		public Vector3 PositionChange;

		public Quaternion RotationChange;

		public Quaternion[] RotationTweaks;

		public bool DisableRotationTransform;

		public bool DisablePositionTransform;

		public OVRHumanBodyBonesMappings.FullBodyTrackingBoneId FullBodyBoneIdOverrideValue;

		public OVRHumanBodyBonesMappings.BodyTrackingBoneId BoneIdOverrideValue;

		public Quaternion PrecomputedRotationTweaks { get; private set; }

		public void PrecomputeRotationTweaks()
		{
		}
	}

	public enum UpdateType
	{
		FixedUpdateOnly = 0,
		UpdateOnly = 1,
		FixedUpdateAndUpdate = 2
	}

	private OVRSkeletonMetadata _sourceSkeletonData;

	private OVRSkeletonMetadata _sourceSkeletonTPoseData;

	private OVRSkeletonMetadata _targetSkeletonData;

	private Animator _animatorTargetSkeleton;

	private Dictionary<BoneId, HumanBodyBones> _customBoneIdToHumanBodyBone;

	private readonly Dictionary<HumanBodyBones, Quaternion> _targetTPoseRotations;

	private Dictionary<HumanBodyBones, Transform> _targetTPoseTransformDup;

	private int _lastSkelChangeCount;

	private Vector3 _lastTrackedScale;

	[SerializeField]
	protected JointAdjustment[] _adjustments;

	[SerializeField]
	protected OVRHumanBodyBonesMappings.BodySection[] _fullBodySectionsToAlign;

	[SerializeField]
	protected OVRHumanBodyBonesMappings.BodySection[] _bodySectionsToAlign;

	[SerializeField]
	protected OVRHumanBodyBonesMappings.BodySection[] _fullBodySectionToPosition;

	[SerializeField]
	protected OVRHumanBodyBonesMappings.BodySection[] _bodySectionToPosition;

	[SerializeField]
	[Tooltip("Controls if we run retargeting from FixedUpdate, Update, or both.")]
	protected UpdateType _updateType;

	protected OVRSkeletonMetadata SourceSkeletonData => null;

	protected OVRSkeletonMetadata SourceSkeletonTPoseData => null;

	protected OVRSkeletonMetadata TargetSkeletonData => null;

	protected Animator AnimatorTargetSkeleton => null;

	protected Dictionary<BoneId, HumanBodyBones> CustomBoneIdToHumanBodyBone => null;

	protected Dictionary<HumanBodyBones, Quaternion> TargetTPoseRotations => null;

	protected JointAdjustment[] Adjustments => null;

	protected OVRHumanBodyBonesMappings.BodySection[] FullBodySectionsToAlign => null;

	protected OVRHumanBodyBonesMappings.BodySection[] BodySectionsToAlign => null;

	protected OVRHumanBodyBonesMappings.BodySection[] FullBodySectionToPosition => null;

	protected OVRHumanBodyBonesMappings.BodySection[] BodySectionToPosition => null;

	protected override void Start()
	{
	}

	private void PrecomputeAllRotationTweaks()
	{
	}

	protected virtual void OnValidate()
	{
	}

	internal static void ValidateGameObjectForUnityHumanoidRetargeting(GameObject go)
	{
	}

	private void StoreTTargetPoseRotations()
	{
	}

	private Transform CreateDuplicateTransformHierarchy(Transform transformFromOriginalHierarchy)
	{
		return null;
	}

	private HumanBodyBones FindHumanBodyBoneFromTransform(Transform candidateTransform)
	{
		return default(HumanBodyBones);
	}

	private void AlignHierarchies(Transform transformToAlign, Transform referenceTransform)
	{
	}

	private void CreateCustomBoneIdToHumanBodyBoneMapping()
	{
	}

	private void CopyBoneIdToHumanBodyBoneMapping()
	{
	}

	private void AdjustCustomBoneIdToHumanBodyBoneMapping()
	{
	}

	private void RemoveMappingCorrespondingToHumanBodyBone(HumanBodyBones boneId)
	{
	}

	protected override void Update()
	{
	}

	protected bool ShouldRunUpdateThisFrame()
	{
		return false;
	}

	protected void RecomputeSkeletalOffsetsIfNecessary()
	{
	}

	private void ComputeOffsetsUsingSkeletonComponent()
	{
	}

	protected static bool IsBodySectionInArray(OVRHumanBodyBonesMappings.BodySection bodySectionToCheck, OVRHumanBodyBonesMappings.BodySection[] sectionArrayToCheck)
	{
		return false;
	}

	private void AlignTargetWithSource()
	{
	}

	protected JointAdjustment FindAdjustment(HumanBodyBones boneId)
	{
		return null;
	}
}
