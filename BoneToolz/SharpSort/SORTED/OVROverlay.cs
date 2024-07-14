using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.XR;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_overlay")]
[ExecuteInEditMode]
public class OVROverlay : MonoBehaviour
{
	public enum OverlayShape
	{
		Quad = 0,
		Cylinder = 1,
		Cubemap = 2,
		OffcenterCubemap = 4,
		Equirect = 5,
		ReconstructionPassthrough = 7,
		SurfaceProjectedPassthrough = 8,
		Fisheye = 9,
		KeyboardHandsPassthrough = 10,
		KeyboardMaskedHandsPassthrough = 11
	}

	public enum OverlayType
	{
		None = 0,
		Underlay = 1,
		Overlay = 2
	}

	public delegate void ExternalSurfaceObjectCreated();

	protected struct LayerTexture
	{
		public Texture appTexture;

		public IntPtr appTexturePtr;

		public Texture[] swapChain;

		public IntPtr[] swapChainPtr;
	}

	[Tooltip("Specify overlay's type")]
	public OverlayType currentOverlayType;

	[Tooltip("If true, the texture's content is copied to the compositor each frame.")]
	public bool isDynamic;

	[Tooltip("If true, the layer would be used to present protected content (e.g. HDCP), the content won't be shown in screenshots or recordings.")]
	public bool isProtectedContent;

	public Rect srcRectLeft;

	public Rect srcRectRight;

	public Rect destRectLeft;

	public Rect destRectRight;

	public bool invertTextureRects;

	private OVRPlugin.TextureRectMatrixf textureRectMatrix;

	public bool overrideTextureRectMatrix;

	public bool overridePerLayerColorScaleAndOffset;

	public Vector4 colorScale;

	public Vector4 colorOffset;

	public bool useExpensiveSuperSample;

	public bool useExpensiveSharpen;

	public bool hidden;

	[Tooltip("If true, the layer will be created as an external surface. externalSurfaceObject contains the Surface object. It's effective only on Android.")]
	public bool isExternalSurface;

	[Tooltip("The width which will be used to create the external surface. It's effective only on Android.")]
	public int externalSurfaceWidth;

	[Tooltip("The height which will be used to create the external surface. It's effective only on Android.")]
	public int externalSurfaceHeight;

	[Tooltip("The compositionDepth defines the order of the OVROverlays in composition. The overlay/underlay with smaller compositionDepth would be composited in the front of the overlay/underlay with larger compositionDepth.")]
	public int compositionDepth;

	private int layerCompositionDepth;

	[Tooltip("The noDepthBufferTesting will stop layer's depth buffer compositing even if the engine has \"Shared Depth Buffer\" enabled. The layer's ordering will be used instead which is determined by it's composition depth and overlay/underlay type.")]
	public bool noDepthBufferTesting;

	public OVRPlugin.EyeTextureFormat layerTextureFormat;

	[Tooltip("Specify overlay's shape")]
	public OverlayShape currentOverlayShape;

	private OverlayShape prevOverlayShape;

	[Tooltip("The left- and right-eye Textures to show in the layer.")]
	public Texture[] textures;

	[Tooltip("When checked, the texture is treated as if the alpha was already premultiplied")]
	public bool isAlphaPremultiplied;

	[Tooltip("When checked, the layer will use bicubic filtering")]
	public bool useBicubicFiltering;

	[Tooltip("When checked, the cubemap will retain the legacy rotation which was rotated 180 degrees around the Y axis comapred to Unity's definition of cubemaps. This setting will be deprecated in the near future, therefore it is recommended to fix the cubemap texture instead.")]
	public bool useLegacyCubemapRotation;

	[Tooltip("When checked, the layer will use efficient super sampling")]
	public bool useEfficientSupersample;

	[Tooltip("When checked, the layer will use efficient sharpen.")]
	public bool useEfficientSharpen;

	[Tooltip("When checked, The runtime automatically chooses the appropriate sharpening or super sampling filter")]
	public bool useAutomaticFiltering;

	[SerializeField]
	internal bool _previewInEditor;

	protected IntPtr[] texturePtrs;

	public IntPtr externalSurfaceObject;

	public ExternalSurfaceObjectCreated externalSurfaceObjectCreated;

	protected bool isOverridePending;

	internal const int maxInstances = 15;

	public static OVROverlay[] instances;

	protected static Material tex2DMaterial;

	protected static Material cubeMaterial;

	protected LayerTexture[] layerTextures;

	protected OVRPlugin.LayerDesc layerDesc;

	protected int stageCount;

	protected int layerIndex;

	protected GCHandle layerIdHandle;

	protected IntPtr layerIdPtr;

	protected int frameIndex;

	protected int prevFrameIndex;

	protected Renderer rend;

	private ulong OpenVROverlayHandle;

	private Vector4 OpenVRUVOffsetAndScale;

	private Vector2 OpenVRMouseScale;

	private OVRManager.XRDevice constructedOverlayXRDevice;

	private bool xrDeviceConstructed;

	public bool previewInEditor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int layerId { get; private set; }

	protected OVRPlugin.LayerLayout layout => default(OVRPlugin.LayerLayout);

	public bool isOverlayVisible { get; private set; }

	protected int texturesPerStage => 0;

	public static string OpenVROverlayKey => null;

	public void OverrideOverlayTextureInfo(Texture srcTexture, IntPtr nativePtr, XRNode node)
	{
	}

	protected static bool NeedsTexturesForShape(OverlayShape shape)
	{
		return false;
	}

	protected bool CreateLayer(int mipLevels, int sampleCount, OVRPlugin.EyeTextureFormat etFormat, int flags, OVRPlugin.Sizei size, OVRPlugin.OverlayShape shape)
	{
		return false;
	}

	protected bool CreateLayerTextures(bool useMipmaps, OVRPlugin.Sizei size, bool isHdr)
	{
		return false;
	}

	protected void DestroyLayerTextures()
	{
	}

	protected void DestroyLayer()
	{
	}

	public void SetSrcDestRects(Rect srcLeft, Rect srcRight, Rect destLeft, Rect destRight)
	{
	}

	public void UpdateTextureRectMatrix()
	{
	}

	public void SetPerLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
	{
	}

	protected bool LatchLayerTextures()
	{
		return false;
	}

	protected OVRPlugin.LayerDesc GetCurrentLayerDesc()
	{
		return default(OVRPlugin.LayerDesc);
	}

	protected Rect GetBlitRect(int eyeId)
	{
		return default(Rect);
	}

	protected void BlitSubImage(Texture src, RenderTexture dst, Material mat, Rect rect, bool invertRect = false)
	{
	}

	protected bool PopulateLayer(int mipLevels, bool isHdr, OVRPlugin.Sizei size, int sampleCount, int stage)
	{
		return false;
	}

	protected bool SubmitLayer(bool overlay, bool headLocked, bool noDepthBufferTesting, OVRPose pose, Vector3 scale, int frameIndex)
	{
		return false;
	}

	protected void SetupEditorPreview()
	{
	}

	public void ResetEditorPreview()
	{
	}

	public static bool IsPassthroughShape(OverlayShape shape)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void InitOVROverlay()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void ComputePoseAndScale(out OVRPose pose, out Vector3 scale, out bool overlay, out bool headLocked)
	{
		pose = default(OVRPose);
		scale = default(Vector3);
		overlay = default(bool);
		headLocked = default(bool);
	}

	private bool ComputeSubmit(out OVRPose pose, out Vector3 scale, out bool overlay, out bool headLocked)
	{
		pose = default(OVRPose);
		scale = default(Vector3);
		overlay = default(bool);
		headLocked = default(bool);
		return false;
	}

	private bool OpenVROverlayUpdate(Vector3 scale, OVRPose pose)
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	private bool TrySubmitLayer()
	{
		return false;
	}
}
