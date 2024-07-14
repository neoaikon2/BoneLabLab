using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_passthrough_layer")]
public class OVRPassthroughLayer : MonoBehaviour
{
	public enum ProjectionSurfaceType
	{
		Reconstructed = 0,
		UserDefined = 1
	}

	public enum ColorMapEditorType
	{
		None = 0,
		GrayscaleToColor = 1,
		Controls = 1,
		Custom = 2,
		Grayscale = 3,
		ColorAdjustment = 4,
		ColorLut = 5,
		InterpolatedColorLut = 6
	}

	private struct Settings
	{
		public Texture2D colorLutTargetTexture;

		public Texture2D colorLutSourceTexture;

		public float saturation;

		public float posterize;

		public float brightness;

		public float contrast;

		public Gradient gradient;

		public float lutWeight;

		public bool flipLutY;

		public Settings(Texture2D colorLutTargetTexture, Texture2D colorLutSourceTexture, float saturation, float posterize, float brightness, float contrast, Gradient gradient, float lutWeight, bool flipLutY)
		{
			this.colorLutTargetTexture = null;
			this.colorLutSourceTexture = null;
			this.saturation = 0f;
			this.posterize = 0f;
			this.brightness = 0f;
			this.contrast = 0f;
			this.gradient = null;
			this.lutWeight = 0f;
			this.flipLutY = false;
		}
	}

	private struct PassthroughMeshInstance
	{
		public ulong meshHandle;

		public ulong instanceHandle;

		public bool updateTransform;

		public Matrix4x4 localToWorld;
	}

	[Serializable]
	internal struct SerializedSurfaceGeometry
	{
		public MeshFilter meshFilter;

		public bool updateTransform;
	}

	private struct DeferredPassthroughMeshAddition
	{
		public GameObject gameObject;

		public bool updateTransform;
	}

	private interface IStyleHandler
	{
		bool IsValid { get; }

		void ApplyStyleSettings(ref OVRPlugin.InsightPassthroughStyle2 style);

		void Update(Settings settings);

		void Clear();
	}

	private class StylesHandler
	{
		private NoneStyleHandler _noneHandler;

		private ColorLutHandler _lutHandler;

		private InterpolatedColorLutHandler _interpolatedLutHandler;

		private MonoToRgbaStyleHandler _monoToRgbaHandler;

		private MonoToMonoStyleHandler _monoToMonoHandler;

		private BCSStyleHandler _bcsHandler;

		private GCHandle _colorMapDataHandle;

		private byte[] _colorMapData;

		public IStyleHandler CurrentStyleHandler;

		public void SetStyleHandler(OVRPlugin.InsightPassthroughColorMapType type)
		{
		}

		private IStyleHandler GetStyleHandler(OVRPlugin.InsightPassthroughColorMapType type)
		{
			return null;
		}

		public void SetColorLutHandler(OVRPassthroughColorLut lut, float weight)
		{
		}

		internal void SetInterpolatedColorLutHandler(OVRPassthroughColorLut lutSource, OVRPassthroughColorLut lutTarget, float weight)
		{
		}

		internal void SetMonoToRgbaHandler(Color[] values)
		{
		}

		internal void SetMonoToMonoHandler(byte[] values)
		{
		}
	}

	private class NoneStyleHandler : IStyleHandler
	{
		public bool IsValid => false;

		public void ApplyStyleSettings(ref OVRPlugin.InsightPassthroughStyle2 style)
		{
		}

		public void Update(Settings settings)
		{
		}

		public void Clear()
		{
		}
	}

	private abstract class BaseGeneratedStyleHandler : IStyleHandler
	{
		private GCHandle _colorMapDataHandle;

		protected byte[] _colorMapData;

		protected abstract uint MapSize { get; }

		public bool IsValid => false;

		public BaseGeneratedStyleHandler(ref GCHandle colorMapDataHandler, byte[] colorMapData)
		{
		}

		public virtual void Update(Settings settings)
		{
		}

		public virtual void ApplyStyleSettings(ref OVRPlugin.InsightPassthroughStyle2 style)
		{
		}

		public void Clear()
		{
		}

		protected virtual void AllocateColorMapData(uint size = 4096u)
		{
		}

		protected virtual void DeallocateColorMapData()
		{
		}

		protected void WriteColorToColorMap(int colorIndex, ref Color color)
		{
		}

		protected void WriteFloatToColorMap(int index, float value)
		{
		}

		protected static void ComputeBrightnessContrastPosterizeMap(byte[] result, float brightness, float contrast, float posterize)
		{
		}
	}

	private class MonoToRgbaStyleHandler : BaseGeneratedStyleHandler
	{
		protected byte[] _tmpColorMapData;

		protected override uint MapSize => 0u;

		public unsafe MonoToRgbaStyleHandler(ref GCHandle colorMapDataHandler, byte[] colorMapData)
			: base(ref *(GCHandle*)null, null)
		{
		}

		public override void Update(Settings settings)
		{
		}

		public void Update(Color[] values)
		{
		}

		protected override void AllocateColorMapData(uint size = 4096u)
		{
		}

		protected override void DeallocateColorMapData()
		{
		}
	}

	private class MonoToMonoStyleHandler : BaseGeneratedStyleHandler
	{
		protected override uint MapSize => 0u;

		public unsafe MonoToMonoStyleHandler(ref GCHandle colorMapDataHandler, byte[] colorMapData)
			: base(ref *(GCHandle*)null, null)
		{
		}

		public override void Update(Settings settings)
		{
		}

		public void Update(byte[] values)
		{
		}
	}

	private class BCSStyleHandler : BaseGeneratedStyleHandler
	{
		protected override uint MapSize => 0u;

		public unsafe BCSStyleHandler(ref GCHandle colorMapDataHandler, byte[] colorMapData)
			: base(ref *(GCHandle*)null, null)
		{
		}

		public override void Update(Settings settings)
		{
		}
	}

	private class ColorLutHandler : IStyleHandler
	{
		protected bool _currentFlipLutY;

		protected Texture2D _currentColorLutSourceTexture;

		public OVRPassthroughColorLut Lut { get; set; }

		public float Weight { get; set; }

		public bool IsValid { get; protected set; }

		public virtual void ApplyStyleSettings(ref OVRPlugin.InsightPassthroughStyle2 style)
		{
		}

		public virtual void Update(Settings settings)
		{
		}

		protected OVRPassthroughColorLut GetColorLutForTexture(Texture2D newTexture, OVRPassthroughColorLut lut, ref Texture2D lastTexture, bool flipY)
		{
			return null;
		}

		internal void Update(OVRPassthroughColorLut lut, float weight)
		{
		}

		public virtual void Clear()
		{
		}
	}

	private class InterpolatedColorLutHandler : ColorLutHandler
	{
		private Texture2D _currentColorLutTargetTexture;

		public OVRPassthroughColorLut LutTarget { get; set; }

		public override void ApplyStyleSettings(ref OVRPlugin.InsightPassthroughStyle2 style)
		{
		}

		public override void Update(Settings settings)
		{
		}

		public void Update(OVRPassthroughColorLut lutSource, OVRPassthroughColorLut lutTarget, float weight)
		{
		}

		public override void Clear()
		{
		}
	}

	public ProjectionSurfaceType projectionSurfaceType;

	public OVROverlay.OverlayType overlayType;

	public int compositionDepth;

	public bool hidden;

	public bool overridePerLayerColorScaleAndOffset;

	public Vector4 colorScale;

	public Vector4 colorOffset;

	[SerializeField]
	internal ColorMapEditorType colorMapEditorType_;

	private static Dictionary<ColorMapEditorType, OVRPlugin.InsightPassthroughColorMapType> _editorToColorMapType;

	public Gradient colorMapEditorGradient;

	[Range(-1f, 1f)]
	public float colorMapEditorContrast;

	[Range(-1f, 1f)]
	public float colorMapEditorBrightness;

	[Range(0f, 1f)]
	public float colorMapEditorPosterize;

	[Range(-1f, 1f)]
	public float colorMapEditorSaturation;

	[SerializeField]
	internal Texture2D _colorLutSourceTexture;

	[SerializeField]
	internal Texture2D _colorLutTargetTexture;

	[SerializeField]
	[Range(0f, 1f)]
	internal float _lutWeight;

	[SerializeField]
	internal bool _flipLutY;

	private Settings _settings;

	private OVRCameraRig cameraRig;

	private bool cameraRigInitialized;

	private GameObject auxGameObject;

	private OVROverlay passthroughOverlay;

	private Dictionary<GameObject, PassthroughMeshInstance> surfaceGameObjects;

	private List<DeferredPassthroughMeshAddition> deferredSurfaceGameObjects;

	[HideInInspector]
	[SerializeField]
	internal List<SerializedSurfaceGeometry> serializedSurfaceGeometry;

	[SerializeField]
	[Range(0f, 1f)]
	internal float textureOpacity_;

	[SerializeField]
	internal bool edgeRenderingEnabled_;

	[SerializeField]
	internal Color edgeColor_;

	[SerializeField]
	private OVRPlugin.InsightPassthroughColorMapType colorMapType;

	private bool styleDirty;

	private StylesHandler _stylesHandler;

	private static readonly Gradient colorMapNeutralGradient;

	public float textureOpacity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool edgeRenderingEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color edgeColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public ColorMapEditorType colorMapEditorType
	{
		get
		{
			return default(ColorMapEditorType);
		}
		set
		{
		}
	}

	private OVROverlay.OverlayShape overlayShape => default(OVROverlay.OverlayShape);

	public void AddSurfaceGeometry(GameObject obj, bool updateTransform = false)
	{
	}

	public void RemoveSurfaceGeometry(GameObject obj)
	{
	}

	public bool IsSurfaceGeometry(GameObject obj)
	{
		return false;
	}

	public void SetColorMap(Color[] values)
	{
	}

	public void SetColorLut(OVRPassthroughColorLut lut, float weight = 1f)
	{
	}

	public void SetColorLut(OVRPassthroughColorLut lutSource, OVRPassthroughColorLut lutTarget, float weight)
	{
	}

	public void SetColorMapControls(float contrast, float brightness = 0f, float posterize = 0f, Gradient gradient = null, ColorMapEditorType colorMapType = ColorMapEditorType.GrayscaleToColor)
	{
	}

	public void SetColorMapMonochromatic(byte[] values)
	{
	}

	public void SetBrightnessContrastSaturation(float brightness = 0f, float contrast = 0f, float saturation = 0f)
	{
	}

	public void DisableColorMap()
	{
	}

	public void SetStyleDirty()
	{
	}

	private void AddDeferredSurfaceGeometries()
	{
	}

	private Matrix4x4 GetTransformMatrixForPassthroughSurfaceObject(Matrix4x4 worldFromObj)
	{
		return default(Matrix4x4);
	}

	private bool CreateAndAddMesh(GameObject obj, out ulong meshHandle, out ulong instanceHandle, out Matrix4x4 localToWorld)
	{
		meshHandle = default(ulong);
		instanceHandle = default(ulong);
		localToWorld = default(Matrix4x4);
		return false;
	}

	private void DestroySurfaceGeometries(bool addBackToDeferredQueue = false)
	{
	}

	private void UpdateSurfaceGeometryTransforms()
	{
	}

	private void UpdateSurfaceGeometryTransform(ulong instanceHandle, Matrix4x4 localToWorld)
	{
	}

	internal static Gradient CreateNeutralColorMapGradient()
	{
		return null;
	}

	private bool HasControlsBasedColorMap()
	{
		return false;
	}

	private void UpdateColorMapFromControls(bool forceUpdate = false)
	{
	}

	private void SyncToOverlay()
	{
	}

	private bool IsUserDefinedAndDoesNotContainSurfaceGeometry()
	{
		return false;
	}

	private static float ClampWeight(float weight)
	{
		return 0f;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private OVRPlugin.InsightPassthroughStyle2 CreateOvrPluginStyleObject()
	{
		return default(OVRPlugin.InsightPassthroughStyle2);
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
