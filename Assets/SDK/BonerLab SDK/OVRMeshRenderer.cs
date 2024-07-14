using UnityEngine;

public class OVRMeshRenderer : MonoBehaviour
{
	public interface IOVRMeshRendererDataProvider
	{
		MeshRendererData GetMeshRendererData();
	}

	public struct MeshRendererData
	{
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

	[SerializeField]
	private IOVRMeshRendererDataProvider _dataProvider;

	[SerializeField]
	private OVRMesh _ovrMesh;

	[SerializeField]
	private OVRSkeleton _ovrSkeleton;

	[SerializeField]
	private ConfidenceBehavior _confidenceBehavior;

	[SerializeField]
	private SystemGestureBehavior _systemGestureBehavior;

	[SerializeField]
	private Material _systemGestureMaterial;

	private Material _originalMaterial;

	private SkinnedMeshRenderer _skinnedMeshRenderer;

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

	private void Update()
	{
	}
}
