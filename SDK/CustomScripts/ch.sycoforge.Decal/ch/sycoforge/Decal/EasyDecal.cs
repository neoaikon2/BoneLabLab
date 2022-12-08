using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[ExecuteInEditMode]
	public class EasyDecal : DecalBase
	{
		public const int MaxQuality = 6;

		internal const string CHILD_NAME = "PROC_PLANE";

		internal const string SKINNED_CHILD_NAME = "SKINNED_PROC_PLANE";

		// was private
		public static Camera renderCamera;

		public LayerMask Mask = 8192;

		// was private
		public int id;

		internal bool evenID;

		// was private
		public Action<EasyDecal> OnFadedOut_;

		// was private
		public Action<EasyDecal> OnFadedIn_;

		// was private
		public Action<EasyDecal> OnFadeOutStarted_;

		// was private
		public Action<EasyDecal, Mesh> OnProjectionFinished_;

		// was private
		public Action<EasyDecal> OnAtlasIndexChanged_;

		// was private
		public Action<EasyDecal> OnSourceChanged_;

		[SerializeField]
		// [HideInInspector]
		// was private
		public GameObject projectionTarget;

		[SerializeField]
		// [HideInInspector]
		// was private
		public ProjectionMode mode;

		// [HideInInspector]
		[SerializeField]
		// was private
		public SourceMode source = SourceMode.Atlas;

		// [HideInInspector]
		[SerializeField]
		// was private
		public AspectMode aspectCorrectionMode;

		// [HideInInspector]
		[SerializeField]
		// was private
		public LookupMode recursiveMode;

		[SerializeField]
		// [HideInInspector]
		// was private
		public SkinQuality skinningQuality;

		// [HideInInspector]
		[SerializeField]
		internal Material material;

		[SerializeField]
		// [HideInInspector]
		// was private
		public DecalTextureAtlas atlas;

		// [HideInInspector]
		[SerializeField]
		// was private
		public int atlasRegionIndex;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float maxDistance = .1f;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float projectionDistance = 1.0f;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool smoothNormals;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float normalSmoothFactor;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float normalSmoothThreshold;

		[SerializeField]
		// [HideInInspector]
		internal int resolution = 2;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool multiMeshEnabled;

		[SerializeField]
		// [HideInInspector]
		// was private
		public bool cullInvisible;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool cullUnreachable;

		[SerializeField]
		// [HideInInspector]
		// was private
		public bool showVertices;

		[SerializeField]
		// [HideInInspector]
		// was private
		public bool showDir;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool showNormals;

		[SerializeField]
		// [HideInInspector]
		// was private
		public bool enableVertexColorFade;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool onlyColliders = true;

		[SerializeField]
		[FormerlySerializedAs("tangents")]
		// [HideInInspector]
		// was private
		public bool calculateTangents;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool calculateNormals;

		[SerializeField]
		// [HideInInspector]
		// was private
		public MeshChannelMode normalChannelMode;

		// [HideInInspector]
		[SerializeField]
		// was private
		public MeshChannelMode tangentChannelMode;

		[SerializeField]
		// [HideInInspector]
		// was private
		public bool recursiceLookup;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool randomIndexEnabled = true;

		// [HideInInspector]
		[SerializeField]
		// was private
		public int recursiceLookupSteps = 1;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool autoDestroy;

		// [HideInInspector]
		[SerializeField]
		// was private
		public OpacityMode opacityMode;

		// [HideInInspector]
		[SerializeField]
		// was private
		public bool fadeOnly = true;

		[SerializeField]
		// [HideInInspector]
		// was private
		public bool useLightProbes;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float lifetime = 5;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float fadeoutTime = 1;

		// [HideInInspector]
		[SerializeField]
		// was private
		public float fadeinTime;

		[SerializeField]
		// [HideInInspector]
		// was private
		public AnimationCurve fadeoutCurve;

		// [HideInInspector]
		[SerializeField]
		// was private
		public AnimationCurve fadeinCurve;

		[SerializeField]
		// [HideInInspector]
		// was private
		public float surfaceRotation;

		// [HideInInspector]
		[SerializeField]
		// was private
		public int quality = 1;

		// was private
		public GameObject receiver;

		// was private
		public GameObject meshContainer;

		// was private
		public GameObject skinnedMeshContainer;

		// was private
		public List<IMeshProcessor> meshProcessors;

		// was private
		public float creationTime;

		// was private
		public float alpha;

		// was private
		public int creationFrameNumber;

		// was private
		public int bakeInFrameNumber;

		// was private
		public bool needUVRecreation;

		// was private
		public bool needGeometryRecreation;

		// [HideInInspector]
		[SerializeField]
		// was private
		public Mesh sharedMesh;

		[SerializeField]
		// [HideInInspector]
		// was private
		public int instanceID;

		internal bool projectBake;

		public static StaticProxyCollection ProxyCollection;

		public static bool HideMesh;

		public static InstantiationDelegate Instantiation;

		public static Camera RenderCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ID
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}
		
		public SkinQuality SkinningQuality
		{
			get
			{
				return default(SkinQuality);
			}
			set
			{
			}
		}

		public Mesh SharedMesh
		{
			get
			{
				return null;
			}
		}

		public bool IsVisible
		{
			get
			{
				return default(bool);
			}
		}

		public int Quality
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool MultiMeshEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CullInvisibles
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CullUnreachable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public GameObject Receiver
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool CalculateTangents
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public MeshChannelMode TangentChannelMode
		{
			get
			{
				return default(MeshChannelMode);
			}
			set
			{
			}
		}

		public bool CalculateNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public MeshChannelMode NormalChannelMode
		{
			get
			{
				return default(MeshChannelMode);
			}
			set
			{
			}
		}

		public bool ShowDir
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ShowVertices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ShowNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float MaxDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ProjectionDistance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool SmoothNormals
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float NormalSmoothFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalSmoothThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool DontDestroy
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool FadeOut
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public OpacityMode OpacityMode
		{
			get
			{
				return default(OpacityMode);
			}
			set
			{
			}
		}

		public float Lifetime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float RemainingLifetime
		{
			get
			{
				return default(float);
			}
		}

		public float CurrentFadeoutTime { get; private set; }

		public float FadeoutTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float FadeinTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public AnimationCurve FadeoutCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 InverseProjectionDirection { get; private set; }

		public float SurfaceRotation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Material DecalMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DecalTextureAtlas Atlas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int AtlasRegionIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public GameObject MeshContainer
		{
			get
			{
				return null;
			}
		}

		public ProjectionMode Mode
		{
			get
			{
				return default(ProjectionMode);
			}
			set
			{
			}
		}

		public SourceMode Source
		{
			get
			{
				return default(SourceMode);
			}
			set
			{
			}
		}

		public AspectMode AspectCorrectionMode
		{
			get
			{
				return default(AspectMode);
			}
			set
			{
			}
		}

		public LookupMode RecursiveMode
		{
			get
			{
				return default(LookupMode);
			}
			set
			{
			}
		}

		public float Alpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[Obsolete("Use EasyDecal.IsFading instead.")]
		public bool IsFadingOut
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFading
		{
			get
			{
				return default(bool);
			}
		}

		public bool OnlyColliders
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnableVertexColorBleed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool RecursiveLookup
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool RandomIndexEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int RecursiveLookupSteps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public List<IMeshProcessor> MeshProcessors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseLightProbes
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public GameObject ProjectionTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<EasyDecal> OnFadedOut
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnFadedIn
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnFadeOutStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal, Mesh> OnProjectionFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnAtlasIndexChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnSourceChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal void CalculateResolutionFromQuality(int quality)
		{
		}

		public void Reset()
		{
		}

		public void Reset(bool unbake)
		{
		}

		public void Reset(bool unbake, bool recreate)
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void StartFade()
		{
		}

		public void CancelFade()
		{
		}

		public void SelectRandom()
		{
		}

		public void CorrectAspect()
		{
		}

		// was private
		public void StartFadeOut()
		{
		}

		public void StartFade(FadingMode mode = FadingMode.Out)
		{
		}

		// was private
		public IEnumerator ProcessFadeOut()
		{
			return null;
		}

		// was private
		public IEnumerator ProcessFadeIn()
		{
			return null;
		}

		public Vector3[] GetBoundingVertices()
		{
			return null;
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		protected virtual void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		protected override void Update()
		{
		}

		protected override void Initialize()
		{
		}

		protected override void InitalizeProjector()
		{
		}

		// was private
		public void Log(string msg)
		{
		}

		protected override void OnChangedTechnique()
		{
		}

		protected virtual void OnChangedAtlasIndex()
		{
		}

		protected virtual void OnChangedSource()
		{
		}

		protected virtual void OnChangedAlpha()
		{
		}

		protected override void OnChangedBakeStatus()
		{
		}

		protected override void AskForGeometryRecreation()
		{
		}

		protected override void AskForUVRecreation()
		{
		}

		// was private
		public void CreateDecalGameObject()
		{
		}

		// was private
		public void SetChildTransform(GameObject child)
		{
		}

		// was private
		public void ResetMesh()
		{
		}

		// was private
		public Mesh FindSharedMesh()
		{
			return null;
		}

		// was private
		public GameObject Search(string name)
		{
			return null;
		}

		internal void AddDynamicMesh(DynamicMesh dynamicMesh, bool isStatic = false)
		{
		}

		// was private
		public void ConvertAndAssign(DynamicMesh dynamicMesh, bool forceRecreation)
		{
		}

		// was private
		public void AssignSharedMesh(Mesh mesh)
		{
		}

		// was private
		public void PostProcessMesh(DynamicMesh mesh)
		{
		}

		public void PostProcessMesh(Mesh mesh)
		{
		}

		internal void TransformUV(DynamicMesh dynamicMesh)
		{
		}

		// was private
		public void DrawMeshGeometryGizmos(Vector3[] vertices, Vector3[] normals)
		{
		}

		// was private
		public void ResetPlanes()
		{
		}

		protected void UpdateDecal()
		{
		}

		[Obsolete("Use LateBake() instead.")]
		protected void ProjectBake()
		{
		}

		public void LateUnbake()
		{
		}

		public void LateBake()
		{
		}

		public void LateBake(uint frames)
		{
		}

		internal Color GetFadeoutColor()
		{
			return default(Color);
		}

		// was private
		public void CallOnProjectionFinished(Mesh mesh)
		{
		}

		// was private
		public void CallOnFadeOutStarted()
		{
		}

		// was private
		public void CallOnFadedOut()
		{
		}

		// was private
		public void CallOnFadedIn()
		{
		}

		// was private
		public void CallOnAtlasIndexChanged()
		{
		}

		// was private
		public void CallOnSourceChanged()
		{
		}

		// was private
		public void CallOnAlphaChanged()
		{
		}

		public static EasyDecal Clone(EasyDecal decal)
		{
			return null;
		}

		public static void CopyProperties(EasyDecal from, EasyDecal to)
		{
		}

		public static void SetStaticProxyCollection(StaticProxyCollection proxyCollection)
		{
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 forward, Vector3 up, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Quaternion rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation, Vector3 scale, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Quaternion rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal, float rotation, bool instantiate = true)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Ray ray, bool instantiate = true)
		{
			return null;
		}

		// was private
		public static EasyDecal ProjectInternal(GameObject decalPrefab, GameObject parent, Vector3 position, Quaternion rotation, Vector3 scale, bool instantiate)
		{
			return null;
		}

		// was private
		public static List<EasyDecal> SearchChildren(Transform parent)
		{
			return null;
		}

		// was private
		public static bool ContainsLayer(LayerMask mask, int layer)
		{
			return default(bool);
		}

		public EasyDecal()
			: base()
		{
		}
	}
}
