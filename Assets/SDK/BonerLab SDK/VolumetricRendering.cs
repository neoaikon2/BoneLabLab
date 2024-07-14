using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class VolumetricRendering : MonoBehaviour
{
	[HideInInspector]
	public enum BlurType
	{
		None = 0,
		Gaussian = 1
	}

	private struct MediaSphere
	{
		public Vector3 CenterPosition;

		public float LocalExtinction;

		public float LocalFalloff;

		public float LocalRange;
	}

	private struct ShaderConstants
	{
		public Matrix4x4 TransposedCameraProjectionMatrix;

		public Matrix4x4 CameraProjectionMatrix;

		public Vector4 _VBufferDistanceEncodingParams;

		public Vector4 _VolumetricResultDim;

		public Vector3 _VolCameraPos;
	}

	private struct ScatteringPerFrameConstants
	{
		public Matrix4x4 _VBufferCoordToViewDirWS;

		public Matrix4x4 _PrevViewProjMatrix;

		public Matrix4x4 _ViewMatrix;

		public Matrix4x4 TransposedCameraProjectionMatrix;

		public Matrix4x4 CameraProjectionMatrix;

		public Vector4 _VBufferDistanceEncodingParams;

		public Vector4 _VBufferDistanceDecodingParams;

		public Vector4 SeqOffset;

		public Vector4 CameraPosition;

		public Vector4 CameraMotionVector;
	}

	private struct StepAddPerFrameConstants
	{
		public Vector4 _VBufferDistanceDecodingParams;

		public Vector3 SeqOffset;
	}

	public enum Clipmap
	{
		Near = 0,
		Far = 1
	}

	private struct VBufferParameters
	{
		public Vector3Int viewportSize;

		public Vector4 depthEncodingParams;

		public Vector4 depthDecodingParams;

		public VBufferParameters(Vector3Int viewportResolution, float depthExtent, float camNear, float camFar, float camVFoV, float sliceDistributionUniformity)
		{
			viewportSize = default(Vector3Int);
			depthEncodingParams = default(Vector4);
			depthDecodingParams = default(Vector4);
		}

		internal Vector4 ComputeUvScaleAndLimit(Vector2Int bufferSize)
		{
			return default(Vector4);
		}

		internal float ComputeLastSliceDistance(int sliceCount)
		{
			return 0f;
		}

		private static Vector4 ComputeLogarithmicDepthEncodingParams(float nearPlane, float farPlane, float c)
		{
			return default(Vector4);
		}

		private static Vector4 ComputeLogarithmicDepthDecodingParams(float nearPlane, float farPlane, float c)
		{
			return default(Vector4);
		}
	}

	private static ProfilingSampler profileUpdateFunc;

	private static ProfilingSampler profileUpdateClipmap;

	public float tempOffset;

	private Texture3D BlackTex;

	private Color clearColor;

	private static VolumetricRendering lastClipmapUpdate;

	private static VolumetricRendering lastBlur;

	private static VolumetricRendering lastFroxelFog;

	private static VolumetricRendering lastFroxelIntegrate;

	public Camera cam;

	private Camera activeCam;

	private UniversalAdditionalCameraData activeCamData;

	private bool hasInitialized;

	private bool VolumetricRegisterEmpty;

	[HideInInspector]
	public bool VolumetricRegisterForceRefresh;

	private int debugHeartBeatCount;

	private int debugHeartBeat;

	public VolumetricData volumetricData;

	[Range(0f, 1f)]
	public float reprojectionAmount;

	public BlurType FroxelBlur;

	[Range(0f, 1f)]
	public float SliceDistributionUniformity;

	[HideInInspector]
	public bool enableEditorPreview;

	private Vector3 ClipmapTransform;

	private Vector3 ClipmapCurrentPos;

	private ComputeBuffer participatingMediaSphereBuffer;

	private const int MediaSphereStride = 24;

	private int MediaCount;

	[HideInInspector]
	[SerializeField]
	private ComputeShader FroxelFogCompute;

	[SerializeField]
	[HideInInspector]
	private ComputeShader FroxelIntegrationCompute;

	[HideInInspector]
	[SerializeField]
	private ComputeShader FroxelLocalFogCompute;

	[HideInInspector]
	[SerializeField]
	private ComputeShader ClipmapCompute;

	[HideInInspector]
	[SerializeField]
	private ComputeShader BlurCompute;

	private RenderTexture ClipmapBufferA;

	private RenderTexture ClipmapBufferB;

	private RenderTexture ClipmapBufferC;

	private RenderTexture ClipmapBufferD;

	private bool FlipClipBufferNear;

	private bool FlipClipBufferFar;

	private RenderTexture FroxelBufferA;

	private RenderTexture FroxelBufferB;

	private RenderTexture IntegrationBuffer;

	private RenderTexture BlurBuffer;

	private RenderTexture BlurBufferB;

	private RenderTexture VolumetricResult;

	private float[] m_zSeq;

	private Vector2[] m_xySeq;

	private float CamAspectRatio;

	protected int ScatteringKernel;

	protected int IntegrateKernel;

	protected int BlurKernelX;

	protected int BlurKernelY;

	private Matrix4x4 matScaleBias;

	private Vector3 ThreadsToDispatch;

	public const string resultTextureName = "_VolumetricResult";

	public const string shaderCBName = "VolumetricsCB";

	public const string volumetricKWName = "_VOLUMETRICS_ENABLED";

	private int ID_VolumetricResult;

	private int ID_VolumetricsCB;

	private int ID_Result;

	private int ID_InLightingTexture;

	private int ID_InTex;

	private int ID_LightProjectionTextureArray;

	private int ID_VolumetricClipmapTexture;

	private int ID_VolumetricClipmapTexture2;

	private int ID_PreResult;

	private int ID_VolumeMap;

	private int ID_PreviousFrameLighting;

	private int ID_HistoryBuffer;

	private int ID_LeftEyeMatrix;

	private int ID_RightEyeMatrix;

	private int ID_ClipmapScale0;

	private int ID_ClipmapScale1;

	private int ID_ClipmapScale2;

	private int ID_ClipmapWorldPosition;

	private int ID_VBufferUnitDepthTexelSpacing;

	private int ID_VolZBufferParams;

	private int ID_GlobalExtinction;

	private int ID_StaticLightMultiplier;

	private int ID_GlobalScattering;

	private int ID_VolumeWorldSize;

	private int ID_VolumeWorldPosition;

	private int ID_media_sphere_buffer_length;

	private int ID_media_sphere_buffer;

	private int ID_ClipMapGenKern;

	private int ID_ClipMapClearKern;

	private int ID_ClipMapHeightKern;

	private int PerFrameConstBufferID;

	private int PreviousFrameMatrixID;

	private int ClipmapScaleID;

	private int ClipmapTransformID;

	private int tempjitter;

	[Range(0f, 1f)]
	[Header("Extra variables")]
	private float[] jitters;

	private Matrix4x4 PreviousFrameMatrix;

	private Matrix4x4 LeftEyeMatrix;

	private Matrix4x4 RightEyeMatrix;

	private Vector3 PreviousCameraPosition;

	private Vector3 previousPos;

	private Quaternion previousQuat;

	private Vector4 VolZBufferParams;

	private float ZPlaneTexelSpacing;

	[Header("Base values that are overridden by Volumes")]
	public Color albedo;

	public float meanFreePath;

	public float StaticLightMultiplier;

	private ComputeBuffer ShaderConstantBuffer;

	private ComputeBuffer ComputePerFrameConstantBuffer;

	private ComputeBuffer StepAddPerFrameConstantBuffer;

	public const int ShaderConstantsCount = 43;

	public const int ShaderConstantsSize = 172;

	private const int ScatterPerFrameCount = 100;

	private const int StepAddPerFrameCount = 7;

	private bool ClipFar;

	private bool FlopIntegralBuffer;

	private Matrix4x4 PrevViewProjMatrix;

	private static void GetHexagonalClosePackedSpheres7(Vector2[] coords)
	{
	}

	private static float[] VolStructToArray<T>(T rawData, int count, int size) where T : struct
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private bool VerifyVolumetricRegisters()
	{
		return false;
	}

	private void CheckOverrideVolumes()
	{
	}

	private void IntializeBlur(RenderTextureDescriptor rtdiscrpt)
	{
	}

	private void Intialize()
	{
	}

	private void SetFroxelFogUniforms(bool forceUpdate = false)
	{
	}

	private void SetFroxelIntegrationUniforms(bool forceUpdate = false)
	{
	}

	private void SetBlurUniforms(bool forceUpdate = false)
	{
	}

	public void ClearAllBuffers()
	{
	}

	private void SetupClipmap()
	{
	}

	private void ClearClipmap(RenderTexture buffer)
	{
	}

	private void CheckClipmap()
	{
	}

	public void UpdateClipmaps()
	{
	}

	public void UpdateClipmap(Clipmap clipmap)
	{
	}

	private void SetClipmap(RenderTexture ClipmapTexture, float ClipmapScale, Vector3 ClipmapTransform, Clipmap clipmap)
	{
	}

	private void FlopIntegralBuffers()
	{
	}

	public void SetVariables()
	{
	}

	private float GetAspectRatio()
	{
		return 0f;
	}

	private void UpdatePreRender(ScriptableRenderContext ctxt, Camera cam1)
	{
	}

	private void UpdateFunc()
	{
	}

	internal static float ComputZPlaneTexelSpacing(float planeDepth, float verticalFoV, float resolutionY)
	{
		return 0f;
	}

	internal static Vector4 ComputeUvScaleAndLimitFun(Vector2Int viewportResolution, Vector2Int bufferSize)
	{
		return default(Vector4);
	}

	public void disable()
	{
	}

	public void enable()
	{
	}

	public void StartSceneViewRendering()
	{
	}

	public void UpdateStateAfterReload()
	{
	}

	public void CleanupOnReload()
	{
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

	private void DestroyAllTextureAssets()
	{
	}

	private Matrix4x4 ComputePixelCoordToWorldSpaceViewDirectionMatrix(Camera cam, Vector4 resolution)
	{
		return default(Matrix4x4);
	}

	private void SetComputeVariables()
	{
	}

	private void SetComputeBuffer(string name, ComputeShader shader, int kernel, ComputeBuffer buffer)
	{
	}

	private static void CreateComputeBuffer<T>(ref ComputeBuffer buffer, List<T> data, int stride) where T : struct
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void ReleaseAssets()
	{
	}

	private void CleanupCameraData()
	{
	}

	private void SetCameraData()
	{
	}

	private void Clear3DTexture(RenderTexture buffer)
	{
	}

	private void RefreshOnSceneChange(Scene oldS, Scene newS)
	{
	}
}
