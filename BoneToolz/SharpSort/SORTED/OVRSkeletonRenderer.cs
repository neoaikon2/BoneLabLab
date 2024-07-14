using System.Collections.Generic;
using UnityEngine;

public class OVRSkeletonRenderer : MonoBehaviour
{
	public interface IOVRSkeletonRendererDataProvider
	{
		SkeletonRendererData GetSkeletonRendererData();
	}

	public struct SkeletonRendererData
	{
		public float RootScale { get; set; }

		public bool IsDataValid { get; set; }

		public bool IsDataHighConfidence { get; set; }

		public bool ShouldUseSystemGestureMaterial { get; set; }
	}

	public enum ConfidenceBehavior
	{
		None = 0,
		ToggleRenderer = 1
	}

	public enum SystemGestureBehavior
	{
		None = 0,
		SwapMaterial = 1
	}

	private class BoneVisualization
	{
		private GameObject BoneGO;

		private Transform BoneBegin;

		private Transform BoneEnd;

		private LineRenderer Line;

		private Material RenderMaterial;

		private Material SystemGestureMaterial;

		public BoneVisualization(GameObject rootGO, Material renderMat, Material systemGestureMat, float scale, Transform begin, Transform end)
		{
		}

		public void Update(float scale, bool shouldRender, bool shouldUseSystemGestureMaterial, ConfidenceBehavior confidenceBehavior, SystemGestureBehavior systemGestureBehavior)
		{
		}
	}

	private class CapsuleVisualization
	{
		private GameObject CapsuleGO;

		private OVRBoneCapsule BoneCapsule;

		private Vector3 capsuleScale;

		private MeshRenderer Renderer;

		private Material RenderMaterial;

		private Material SystemGestureMaterial;

		public CapsuleVisualization(GameObject rootGO, Material renderMat, Material systemGestureMat, float scale, OVRBoneCapsule boneCapsule)
		{
		}

		public void Update(float scale, bool shouldRender, bool shouldUseSystemGestureMaterial, ConfidenceBehavior confidenceBehavior, SystemGestureBehavior systemGestureBehavior)
		{
		}
	}

	[SerializeField]
	private IOVRSkeletonRendererDataProvider _dataProvider;

	[SerializeField]
	private ConfidenceBehavior _confidenceBehavior;

	[SerializeField]
	private SystemGestureBehavior _systemGestureBehavior;

	[SerializeField]
	private bool _renderPhysicsCapsules;

	[SerializeField]
	private Material _skeletonMaterial;

	private Material _skeletonDefaultMaterial;

	[SerializeField]
	private Material _capsuleMaterial;

	private Material _capsuleDefaultMaterial;

	[SerializeField]
	private Material _systemGestureMaterial;

	private Material _systemGestureDefaultMaterial;

	private const float LINE_RENDERER_WIDTH = 0.005f;

	private List<BoneVisualization> _boneVisualizations;

	private List<CapsuleVisualization> _capsuleVisualizations;

	private OVRSkeleton _ovrSkeleton;

	private GameObject _skeletonGO;

	private float _scale;

	private static readonly Quaternion _capsuleRotationOffset;

	public bool IsInitialized { get; private set; }

	public bool IsDataValid { get; private set; }

	public bool IsDataHighConfidence { get; private set; }

	public bool ShouldUseSystemGestureMaterial { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private bool ShouldInitialize()
	{
		return false;
	}

	private void Initialize()
	{
	}

	public void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
