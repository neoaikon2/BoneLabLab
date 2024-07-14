using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Android;

public static class OVRPermissionsRequester
{
	public enum Permission
	{
		FaceTracking = 0,
		BodyTracking = 1,
		EyeTracking = 2,
		Scene = 3,
		RecordAudio = 4
	}

	public const string FaceTrackingPermission = "com.oculus.permission.FACE_TRACKING";

	public const string EyeTrackingPermission = "com.oculus.permission.EYE_TRACKING";

	public const string BodyTrackingPermission = "com.oculus.permission.BODY_TRACKING";

	public const string ScenePermission = "com.oculus.permission.USE_SCENE";

	public const string RecordAudioPermission = "android.permission.RECORD_AUDIO";

	public static event Action<string> PermissionGranted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static string GetPermissionId(Permission permission)
	{
		return null;
	}

	private static bool IsPermissionSupportedByPlatform(Permission permission)
	{
		return false;
	}

	public static bool IsPermissionGranted(Permission permission)
	{
		return false;
	}

	public static void Request(IEnumerable<Permission> permissions)
	{
	}

	private static void RequestPermissions(IEnumerable<Permission> permissions)
	{
	}

	private static bool ShouldRequestPermission(Permission permission)
	{
		return false;
	}

	private static PermissionCallbacks BuildPermissionCallbacks()
	{
		return null;
	}
}
