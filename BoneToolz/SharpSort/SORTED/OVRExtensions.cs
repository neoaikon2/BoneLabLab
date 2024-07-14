using System;
using System.Collections.Generic;
using OVR.OpenVR;
using Unity.Collections;
using UnityEngine;

public static class OVRExtensions
{
	public static OVRPose ToTrackingSpacePose(this Transform transform, Camera camera)
	{
		return default(OVRPose);
	}

	[Obsolete("ToWorldSpacePose should be invoked with an explicit mainCamera parameter")]
	public static OVRPose ToWorldSpacePose(this OVRPose trackingSpacePose)
	{
		return default(OVRPose);
	}

	public static OVRPose ToWorldSpacePose(this OVRPose trackingSpacePose, Camera mainCamera)
	{
		return default(OVRPose);
	}

	public static OVRPose ToHeadSpacePose(this OVRPose trackingSpacePose)
	{
		return default(OVRPose);
	}

	public static OVRPose ToHeadSpacePose(this Transform transform, Camera camera)
	{
		return default(OVRPose);
	}

	public static OVRPose ToOVRPose(this Transform t, bool isLocal = false)
	{
		return default(OVRPose);
	}

	public static void FromOVRPose(this Transform t, OVRPose pose, bool isLocal = false)
	{
	}

	public static OVRPose ToOVRPose(this OVRPlugin.Posef p)
	{
		return default(OVRPose);
	}

	public static OVRTracker.Frustum ToFrustum(this OVRPlugin.Frustumf f)
	{
		return default(OVRTracker.Frustum);
	}

	public static Color FromColorf(this OVRPlugin.Colorf c)
	{
		return default(Color);
	}

	public static OVRPlugin.Colorf ToColorf(this Color c)
	{
		return default(OVRPlugin.Colorf);
	}

	public static Vector2 FromSizef(this OVRPlugin.Sizef v)
	{
		return default(Vector2);
	}

	public static OVRPlugin.Sizef ToSizef(this Vector2 v)
	{
		return default(OVRPlugin.Sizef);
	}

	public static Vector2 FromVector2f(this OVRPlugin.Vector2f v)
	{
		return default(Vector2);
	}

	public static Vector2 FromFlippedXVector2f(this OVRPlugin.Vector2f v)
	{
		return default(Vector2);
	}

	public static OVRPlugin.Vector2f ToVector2f(this Vector2 v)
	{
		return default(OVRPlugin.Vector2f);
	}

	public static Vector3 FromSize3f(this OVRPlugin.Size3f v)
	{
		return default(Vector3);
	}

	public static OVRPlugin.Size3f ToSize3f(this Vector3 v)
	{
		return default(OVRPlugin.Size3f);
	}

	public static Vector3 FromVector3f(this OVRPlugin.Vector3f v)
	{
		return default(Vector3);
	}

	public static Vector3 FromFlippedXVector3f(this OVRPlugin.Vector3f v)
	{
		return default(Vector3);
	}

	public static Vector3 FromFlippedZVector3f(this OVRPlugin.Vector3f v)
	{
		return default(Vector3);
	}

	public static OVRPlugin.Vector3f ToVector3f(this Vector3 v)
	{
		return default(OVRPlugin.Vector3f);
	}

	public static OVRPlugin.Vector3f ToFlippedXVector3f(this Vector3 v)
	{
		return default(OVRPlugin.Vector3f);
	}

	public static OVRPlugin.Vector3f ToFlippedZVector3f(this Vector3 v)
	{
		return default(OVRPlugin.Vector3f);
	}

	public static Vector4 FromVector4f(this OVRPlugin.Vector4f v)
	{
		return default(Vector4);
	}

	public static OVRPlugin.Vector4f ToVector4f(this Vector4 v)
	{
		return default(OVRPlugin.Vector4f);
	}

	public static Quaternion FromQuatf(this OVRPlugin.Quatf q)
	{
		return default(Quaternion);
	}

	public static Quaternion FromFlippedXQuatf(this OVRPlugin.Quatf q)
	{
		return default(Quaternion);
	}

	public static Quaternion FromFlippedZQuatf(this OVRPlugin.Quatf q)
	{
		return default(Quaternion);
	}

	public static OVRPlugin.Quatf ToQuatf(this Quaternion q)
	{
		return default(OVRPlugin.Quatf);
	}

	public static OVRPlugin.Quatf ToFlippedXQuatf(this Quaternion q)
	{
		return default(OVRPlugin.Quatf);
	}

	public static OVRPlugin.Quatf ToFlippedZQuatf(this Quaternion q)
	{
		return default(OVRPlugin.Quatf);
	}

	public static HmdMatrix34_t ConvertToHMDMatrix34(this Matrix4x4 m)
	{
		return default(HmdMatrix34_t);
	}

	public static Transform FindChildRecursive(this Transform parent, string name)
	{
		return null;
	}

	public static bool Equals(this Gradient gradient, Gradient otherGradient)
	{
		return false;
	}

	public static void CopyFrom(this Gradient gradient, Gradient otherGradient)
	{
	}

	internal static OVRPlugin.SpaceStorageLocation ToSpaceStorageLocation(this OVRSpace.StorageLocation storageLocation)
	{
		return default(OVRPlugin.SpaceStorageLocation);
	}

	internal static OVREnumerable<T> ToNonAlloc<T>(this IEnumerable<T> enumerable)
	{
		return default(OVREnumerable<T>);
	}

	internal static NativeArray<T> ToNativeArray<T>(this IEnumerable<T> enumerable, Allocator allocator) where T : struct
	{
		return default(NativeArray<T>);
	}
}
