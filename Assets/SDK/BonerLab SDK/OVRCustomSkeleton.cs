using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_custom_skeleton")]
public class OVRCustomSkeleton : OVRSkeleton, ISerializationCallbackReceiver
{
	public enum RetargetingType
	{
		OculusSkeleton = 0
	}

	[HideInInspector]
	[SerializeField]
	private List<Transform> _customBones_V2;

	[SerializeField]
	[HideInInspector]
	internal RetargetingType retargetingType;

	public List<Transform> CustomBones => null;

	protected override Transform GetBoneTransform(BoneId boneId)
	{
		return null;
	}

	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	private void AllocateBones()
	{
	}

	internal override void SetSkeletonType(SkeletonType skeletonType)
	{
	}

	public void OnBeforeSerialize()
	{
		throw new System.NotImplementedException();
	}

	public void OnAfterDeserialize()
	{
		throw new System.NotImplementedException();
	}
}
