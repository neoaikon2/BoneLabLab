using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_body")]
public class OVRBody : MonoBehaviour, OVRSkeleton.IOVRSkeletonDataProvider, OVRSkeletonRenderer.IOVRSkeletonRendererDataProvider
{
	private OVRPlugin.BodyState _bodyState;

	private OVRPlugin.Quatf[] _boneRotations;

	private OVRPlugin.Vector3f[] _boneTranslations;

	private bool _dataChangedSinceLastQuery;

	private bool _hasData;

	private const OVRPermissionsRequester.Permission BodyTrackingPermission = OVRPermissionsRequester.Permission.BodyTracking;

	private Action<string> _onPermissionGranted;

	[Tooltip("The skeleton data type to be provided. Should be sync with OVRSkeleton. For selecting the tracking mode on the device, check settings in OVRManager.")]
	[SerializeField]
	private OVRPlugin.BodyJointSet _providedSkeletonType;

	private static int _trackingInstanceCount;

	public OVRPlugin.BodyJointSet ProvidedSkeletonType
	{
		get
		{
			return default(OVRPlugin.BodyJointSet);
		}
		set
		{
		}
	}

	public OVRPlugin.BodyState? BodyState => null;

	public static OVRPlugin.BodyTrackingFidelity2 Fidelity
	{
		get
		{
			return default(OVRPlugin.BodyTrackingFidelity2);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnPermissionGranted(string permissionId)
	{
	}

	private static bool StartBodyTracking()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static bool SetRequestedJointSet(OVRPlugin.BodyJointSet jointSet)
	{
		return false;
	}

	public static bool SuggestBodyTrackingCalibrationOverride(float height)
	{
		return false;
	}

	public static bool ResetBodyTrackingCalibration()
	{
		return false;
	}

	public OVRPlugin.BodyTrackingCalibrationState GetBodyTrackingCalibrationStatus()
	{
		return default(OVRPlugin.BodyTrackingCalibrationState);
	}

	public OVRPlugin.BodyTrackingFidelity2 GetBodyTrackingFidelityStatus()
	{
		return default(OVRPlugin.BodyTrackingFidelity2);
	}

	private void GetBodyState(OVRPlugin.Step step)
	{
	}

	private OVRSkeleton.SkeletonType OVRSkeleton_002EIOVRSkeletonDataProvider_002EGetSkeletonType()
	{
		return default(OVRSkeleton.SkeletonType);
	}

	private OVRSkeleton.SkeletonPoseData OVRSkeleton_002EIOVRSkeletonDataProvider_002EGetSkeletonPoseData()
	{
		return default(OVRSkeleton.SkeletonPoseData);
	}

	private OVRSkeletonRenderer.SkeletonRendererData OVRSkeletonRenderer_002EIOVRSkeletonRendererDataProvider_002EGetSkeletonRendererData()
	{
		return default(OVRSkeletonRenderer.SkeletonRendererData);
	}

	[SpecialName]
	private bool OVRSkeleton_002EIOVRSkeletonDataProvider_002Eget_enabled()
	{
		return false;
	}

	public OVRSkeletonRenderer.SkeletonRendererData GetSkeletonRendererData()
	{
		throw new NotImplementedException();
	}

	public OVRSkeleton.SkeletonType GetSkeletonType()
	{
		throw new NotImplementedException();
	}

	public OVRSkeleton.SkeletonPoseData GetSkeletonPoseData()
	{
		throw new NotImplementedException();
	}
}
