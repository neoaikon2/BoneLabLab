using UnityEngine;
using UnityEngine.Serialization;

[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : OVRRayTransformer
{
	public enum DrawMode
	{
		Opaque = 0,
		OpaqueWithClip = 1,
		TransparentDefaultAlpha = 2,
		TransparentCorrectAlpha = 3
	}

	public enum CanvasShape
	{
		Flat = 0,
		Curved = 1
	}

	[HideInInspector]
	[SerializeField]
	private Shader _overrideCanvasShader;

	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("_transparentShader")]
	private Shader _transparentImposterShader;

	[FormerlySerializedAs("_opaqueShader")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueImposterShader;

	private RectTransform _rectTransform;

	private Canvas _canvas;

	private Camera _camera;

	private OVROverlay _overlay;

	private MeshRenderer _meshRenderer;

	private OVROverlayMeshGenerator _meshGenerator;

	private RenderTexture _renderTexture;

	private Material _imposterMaterial;

	private float _optimalResolutionWidth;

	private float _optimalResolutionHeight;

	private float _lastPixelWidth;

	private float _lastPixelHeight;

	private Vector2 _imposterTextureOffset;

	private Vector2 _imposterTextureScale;

	private bool _hasRenderedFirstFrame;

	private readonly bool _scaleViewport;

	[FormerlySerializedAs("MaxTextureSize")]
	public int maxTextureSize;

	[FormerlySerializedAs("DrawRate")]
	public int renderInterval;

	[FormerlySerializedAs("DrawFrameOffset")]
	public int renderIntervalFrameOffset;

	[FormerlySerializedAs("Expensive")]
	public bool expensive;

	[FormerlySerializedAs("Layer")]
	public int layer;

	[FormerlySerializedAs("Opacity")]
	public DrawMode opacity;

	public bool overrideDefaultCanvasMaterial;

	public CanvasShape shape;

	public float curveRadius;

	[SerializeField]
	private bool _overlayEnabled;

	private static readonly Plane[] _FrustumPlanes;

	private static readonly Vector3[] _WorldCorners;

	public bool overlayEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void InitializeRenderTexture()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual bool ShouldRender()
	{
		return false;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void ApplyViewportScale()
	{
	}

	public override Ray TransformRay(Ray ray)
	{
		return default(Ray);
	}

	private static bool LineCircleIntersection(Vector2 p1, Vector2 dp, Vector2 center, float radius, out float distance)
	{
		distance = default(float);
		return false;
	}
}
