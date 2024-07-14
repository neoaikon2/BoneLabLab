using UnityEngine;

public class OVRBoneCapsule
{
	public short BoneIndex { get; set; }

	public Rigidbody CapsuleRigidbody { get; set; }

	public CapsuleCollider CapsuleCollider { get; set; }

	public OVRBoneCapsule()
	{
	}

	public OVRBoneCapsule(short boneIndex, Rigidbody capsuleRigidBody, CapsuleCollider capsuleCollider)
	{
	}
}
