public static class OVREnumExtensions
{
	public static bool IsHand(this OVRSkeleton.SkeletonType skeletonType)
	{
		return false;
	}

	public static OVRHand.Hand AsHandType(this OVRSkeleton.SkeletonType skeletonType)
	{
		return default(OVRHand.Hand);
	}

	public static OVRSkeleton.SkeletonType AsSkeletonType(this OVRHand.Hand hand)
	{
		return default(OVRSkeleton.SkeletonType);
	}

	public static OVRMesh.MeshType AsMeshType(this OVRHand.Hand hand)
	{
		return default(OVRMesh.MeshType);
	}

	public static OVRHand.Hand AsHandType(this OVRMesh.MeshType meshType)
	{
		return default(OVRHand.Hand);
	}
}
