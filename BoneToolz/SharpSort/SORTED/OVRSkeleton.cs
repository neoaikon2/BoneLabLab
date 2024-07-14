using System.Collections.Generic;
using UnityEngine;

public class OVRSkeleton : MonoBehaviour
{
	public interface IOVRSkeletonDataProvider
	{
		bool enabled { get; }

		SkeletonType GetSkeletonType();

		SkeletonPoseData GetSkeletonPoseData();
	}

	public struct SkeletonPoseData
	{
		public OVRPlugin.Posef RootPose { get; set; }

		public float RootScale { get; set; }

		public OVRPlugin.Quatf[] BoneRotations { get; set; }

		public bool IsDataValid { get; set; }

		public bool IsDataHighConfidence { get; set; }

		public OVRPlugin.Vector3f[] BoneTranslations { get; set; }

		public int SkeletonChangedCount { get; set; }
	}

	public enum SkeletonType
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1,
		[InspectorName("Body (Upper Body)")]
		Body = 2,
		FullBody = 3
	}

	public enum BoneId
	{
		Invalid = -1,
		Hand_Start = 0,
		Hand_WristRoot = 0,
		Hand_ForearmStub = 1,
		Hand_Thumb0 = 2,
		Hand_Thumb1 = 3,
		Hand_Thumb2 = 4,
		Hand_Thumb3 = 5,
		Hand_Index1 = 6,
		Hand_Index2 = 7,
		Hand_Index3 = 8,
		Hand_Middle1 = 9,
		Hand_Middle2 = 10,
		Hand_Middle3 = 11,
		Hand_Ring1 = 12,
		Hand_Ring2 = 13,
		Hand_Ring3 = 14,
		Hand_Pinky0 = 15,
		Hand_Pinky1 = 16,
		Hand_Pinky2 = 17,
		Hand_Pinky3 = 18,
		Hand_MaxSkinnable = 19,
		Hand_ThumbTip = 19,
		Hand_IndexTip = 20,
		Hand_MiddleTip = 21,
		Hand_RingTip = 22,
		Hand_PinkyTip = 23,
		Hand_End = 24,
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
		Max = 84
	}

	[SerializeField]
	protected SkeletonType _skeletonType;

	[SerializeField]
	private IOVRSkeletonDataProvider _dataProvider;

	[SerializeField]
	private bool _updateRootPose;

	[SerializeField]
	private bool _updateRootScale;

	[SerializeField]
	private bool _enablePhysicsCapsules;

	[SerializeField]
	private bool _applyBoneTranslations;

	private GameObject _bonesGO;

	private GameObject _bindPosesGO;

	private GameObject _capsulesGO;

	protected List<OVRBone> _bones;

	private List<OVRBone> _bindPoses;

	private List<OVRBoneCapsule> _capsules;

	protected OVRPlugin.Skeleton2 _skeleton;

	private readonly Quaternion wristFixupRotation;

	public bool IsInitialized { get; private set; }

	public bool IsDataValid { get; private set; }

	public bool IsDataHighConfidence { get; private set; }

	public IList<OVRBone> Bones { get; protected set; }

	public IList<OVRBone> BindPoses { get; private set; }

	public IList<OVRBoneCapsule> Capsules { get; private set; }

	public int SkeletonChangedCount { get; private set; }

	public SkeletonType GetSkeletonType()
	{
		return default(SkeletonType);
	}

	internal virtual void SetSkeletonType(SkeletonType type)
	{
	}

	internal OVRPlugin.BodyJointSet GetRequiredBodyJointSet()
	{
		return default(OVRPlugin.BodyJointSet);
	}

	public bool IsValidBone(BoneId bone)
	{
		return false;
	}

	protected virtual void Awake()
	{
	}

	internal IOVRSkeletonDataProvider SearchSkeletonDataProvider()
	{
		return null;
	}

	protected virtual void Start()
	{
	}

	private bool ShouldInitialize()
	{
		return false;
	}

	private void Initialize()
	{
	}

	protected virtual Transform GetBoneTransform(BoneId boneId)
	{
		return null;
	}

	protected virtual void InitializeBones()
	{
	}

	private void InitializeBindPose()
	{
	}

	private void InitializeCapsules()
	{
	}

	protected virtual void Update()
	{
	}

	protected void UpdateSkeleton()
	{
	}

	private void FixedUpdate()
	{
	}

	public BoneId GetCurrentStartBoneId()
	{
		return default(BoneId);
	}

	public BoneId GetCurrentEndBoneId()
	{
		return default(BoneId);
	}

	private BoneId GetCurrentMaxSkinnableBoneId()
	{
		return default(BoneId);
	}

	public int GetCurrentNumBones()
	{
		return 0;
	}

	public int GetCurrentNumSkinnableBones()
	{
		return 0;
	}

	public static string BoneLabelFromBoneId(SkeletonType skeletonType, BoneId boneId)
	{
		return null;
	}

	internal static bool IsBodySkeleton(SkeletonType type)
	{
		return false;
	}

	private static bool IsHandSkeleton(SkeletonType type)
	{
		return false;
	}
}
