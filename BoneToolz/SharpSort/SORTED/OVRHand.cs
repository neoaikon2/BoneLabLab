using System.Runtime.CompilerServices;
using UnityEngine;

public class OVRHand : MonoBehaviour, OVRSkeleton.IOVRSkeletonDataProvider, OVRSkeletonRenderer.IOVRSkeletonRendererDataProvider, OVRMesh.IOVRMeshDataProvider, OVRMeshRenderer.IOVRMeshRendererDataProvider
{
	public enum Hand
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	public enum HandFinger
	{
		Thumb = 0,
		Index = 1,
		Middle = 2,
		Ring = 3,
		Pinky = 4,
		Max = 5
	}

	public enum TrackingConfidence
	{
		Low = 0,
		High = 1065353216
	}

	[SerializeField]
	internal Hand HandType;

	[SerializeField]
	private Transform _pointerPoseRoot;

	public OVRInput.InputDeviceShowState m_showState;

	private GameObject _pointerPoseGO;

	private OVRPlugin.HandState _handState;

	public bool IsDataValid { get; private set; }

	public bool IsDataHighConfidence { get; private set; }

	public bool IsTracked { get; private set; }

	public bool IsSystemGestureInProgress { get; private set; }

	public bool IsPointerPoseValid { get; private set; }

	public Transform PointerPose { get; private set; }

	public float HandScale { get; private set; }

	public TrackingConfidence HandConfidence { get; private set; }

	public bool IsDominantHand { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void GetHandState(OVRPlugin.Step step)
	{
	}

	public bool GetFingerIsPinching(HandFinger finger)
	{
		return false;
	}

	public float GetFingerPinchStrength(HandFinger finger)
	{
		return 0f;
	}

	public TrackingConfidence GetFingerConfidence(HandFinger finger)
	{
		return default(TrackingConfidence);
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

	private OVRMesh.MeshType OVRMesh_002EIOVRMeshDataProvider_002EGetMeshType()
	{
		return default(OVRMesh.MeshType);
	}

	private OVRMeshRenderer.MeshRendererData OVRMeshRenderer_002EIOVRMeshRendererDataProvider_002EGetMeshRendererData()
	{
		return default(OVRMeshRenderer.MeshRendererData);
	}

	public void OnValidate()
	{
	}

	[SpecialName]
	private bool OVRSkeleton_002EIOVRSkeletonDataProvider_002Eget_enabled()
	{
		return false;
	}

	public OVRMeshRenderer.MeshRendererData GetMeshRendererData()
	{
		throw new System.NotImplementedException();
	}

	public OVRMesh.MeshType GetMeshType()
	{
		throw new System.NotImplementedException();
	}

	public OVRSkeletonRenderer.SkeletonRendererData GetSkeletonRendererData()
	{
		throw new System.NotImplementedException();
	}

	public OVRSkeleton.SkeletonType GetSkeletonType()
	{
		throw new System.NotImplementedException();
	}

	public OVRSkeleton.SkeletonPoseData GetSkeletonPoseData()
	{
		throw new System.NotImplementedException();
	}
}
