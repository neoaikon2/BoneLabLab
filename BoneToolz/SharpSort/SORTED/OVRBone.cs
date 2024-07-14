using UnityEngine;

public class OVRBone
{
	public OVRSkeleton.BoneId Id { get; set; }

	public short ParentBoneIndex { get; set; }

	public Transform Transform { get; set; }

	public OVRBone()
	{
	}

	public OVRBone(OVRSkeleton.BoneId id, short parentBoneIndex, Transform trans)
	{
	}
}
