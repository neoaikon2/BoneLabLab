using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Camera))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_vignette")]
[ExecuteInEditMode]
public class OVRVignette : MonoBehaviour
{
	public enum MeshComplexityLevel
	{
		VerySimple = 0,
		Simple = 1,
		Normal = 2,
		Detailed = 3,
		VeryDetailed = 4
	}

	public enum FalloffType
	{
		Linear = 0,
		Quadratic = 1
	}

	private static readonly string QUADRATIC_FALLOFF;

	[SerializeField]
	[HideInInspector]
	private Shader VignetteShader;

	[SerializeField]
	[Tooltip("Controls the number of triangles used for the vignette mesh. Normal is best for most purposes.")]
	private MeshComplexityLevel MeshComplexity;

	[Tooltip("Controls how the falloff looks.")]
	[SerializeField]
	private FalloffType Falloff;

	[Tooltip("The Vertical FOV of the vignette")]
	public float VignetteFieldOfView;

	[Tooltip("The Aspect ratio of the vignette controls the Horizontal FOV. (Larger numbers are wider)")]
	public float VignetteAspectRatio;

	[Tooltip("The width of the falloff for the vignette in degrees")]
	public float VignetteFalloffDegrees;

	[Tooltip("The color of the vignette. Alpha value is ignored")]
	[ColorUsage(false)]
	public Color VignetteColor;

	private Camera _Camera;

	private MeshFilter _OpaqueMeshFilter;

	private MeshFilter _TransparentMeshFilter;

	private MeshRenderer _OpaqueMeshRenderer;

	private MeshRenderer _TransparentMeshRenderer;

	private Mesh _OpaqueMesh;

	private Mesh _TransparentMesh;

	private Material _OpaqueMaterial;

	private Material _TransparentMaterial;

	private int _ShaderScaleAndOffset0Property;

	private int _ShaderScaleAndOffset1Property;

	private Vector4[] _TransparentScaleAndOffset0;

	private Vector4[] _TransparentScaleAndOffset1;

	private Vector4[] _OpaqueScaleAndOffset0;

	private Vector4[] _OpaqueScaleAndOffset1;

	private bool _OpaqueVignetteVisible;

	private bool _TransparentVignetteVisible;

	private int GetTriangleCount()
	{
		return 0;
	}

	private void BuildMeshes()
	{
	}

	private void BuildMaterials()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void GetTanFovAndOffsetForStereoEye(Camera.StereoscopicEye eye, out float tanFovX, out float tanFovY, out float offsetX, out float offsetY)
	{
		tanFovX = default(float);
		tanFovY = default(float);
		offsetX = default(float);
		offsetY = default(float);
	}

	private void GetTanFovAndOffsetForMonoEye(out float tanFovX, out float tanFovY, out float offsetX, out float offsetY)
	{
		tanFovX = default(float);
		tanFovY = default(float);
		offsetX = default(float);
		offsetY = default(float);
	}

	private bool VisibilityTest(float scaleX, float scaleY, float offsetX, float offsetY)
	{
		return false;
	}

	private void Update()
	{
	}

	private void EnableRenderers()
	{
	}

	private void DisableRenderers()
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
	{
	}
}
