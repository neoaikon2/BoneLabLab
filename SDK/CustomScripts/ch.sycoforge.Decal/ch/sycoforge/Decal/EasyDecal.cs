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

		public static Camera renderCamera;

		public LayerMask Mask;

		public int id;

		internal bool evenID;

		public Action<EasyDecal> OnFadedOut_;

		public Action<EasyDecal> OnFadedIn_;

		public Action<EasyDecal> OnFadeOutStarted_;

		public Action<EasyDecal, Mesh> OnProjectionFinished_;

		public Action<EasyDecal> OnAtlasIndexChanged_;

		public Action<EasyDecal> OnSourceChanged_;

		[SerializeField]
		//[HideInInspector]
		public GameObject projectionTarget;

		[SerializeField]
		//[HideInInspector]
		public ProjectionMode mode;

		//[HideInInspector]
		[SerializeField]
		public SourceMode source;

		//[HideInInspector]
		[SerializeField]
		public AspectMode aspectCorrectionMode;

		//[HideInInspector]
		[SerializeField]
		public LookupMode recursiveMode;

		[SerializeField]
		//[HideInInspector]
		public SkinQuality skinningQuality;

		//[HideInInspector]
		[SerializeField]
		internal Material material;

		[SerializeField]
		//[HideInInspector]
		public DecalTextureAtlas atlas;

		//[HideInInspector]
		[SerializeField]
		public int atlasRegionIndex;

		//[HideInInspector]
		[SerializeField]
		public float maxDistance;

		////[HideInInspector]
		[SerializeField]
		public float projectionDistance;

		//[HideInInspector]
		[SerializeField]
		public bool smoothNormals;

		//[HideInInspector]
		[SerializeField]
		public float normalSmoothFactor;

		//[HideInInspector]
		[SerializeField]
		public float normalSmoothThreshold;

		[SerializeField]
		//[HideInInspector]
		internal int resolution;

		//[HideInInspector]
		[SerializeField]
		public bool multiMeshEnabled;

		[SerializeField]
		//[HideInInspector]
		public bool cullInvisible;

		//[HideInInspector]
		[SerializeField]
		public bool cullUnreachable;

		[SerializeField]
		//[HideInInspector]
		public bool showVertices;

		[SerializeField]
		//[HideInInspector]
		public bool showDir;

		//[HideInInspector]
		[SerializeField]
		public bool showNormals;

		[SerializeField]
		//[HideInInspector]
		public bool enableVertexColorFade;

		//[HideInInspector]
		[SerializeField]
		public bool onlyColliders;

		[SerializeField]
		[FormerlySerializedAs("tangents")]
		//[HideInInspector]
		public bool calculateTangents;

		//[HideInInspector]
		[SerializeField]
		public bool calculateNormals;

		[SerializeField]
		//[HideInInspector]
		public MeshChannelMode normalChannelMode;

		//[HideInInspector]
		[SerializeField]
		public MeshChannelMode tangentChannelMode;

		[SerializeField]
		//[HideInInspector]
		public bool recursiceLookup;

		//[HideInInspector]
		[SerializeField]
		public bool randomIndexEnabled;

		//[HideInInspector]
		[SerializeField]
		public int recursiceLookupSteps;

		//[HideInInspector]
		[SerializeField]
		public bool autoDestroy;

		//[HideInInspector]
		[SerializeField]
		public OpacityMode opacityMode;

		//[HideInInspector]
		[SerializeField]
		public bool fadeOnly;

		[SerializeField]
		//[HideInInspector]
		public bool useLightProbes;

		//[HideInInspector]
		[SerializeField]
		public float lifetime;

		//[HideInInspector]
		[SerializeField]
		public float fadeoutTime;

		//[HideInInspector]
		[SerializeField]
		public float fadeinTime;

		[SerializeField]
		//[HideInInspector]
		public AnimationCurve fadeoutCurve;

		//[HideInInspector]
		[SerializeField]
		public AnimationCurve fadeinCurve;

		[SerializeField]
		//[HideInInspector]
		public float surfaceRotation;

		//[HideInInspector]
		[SerializeField]
		public int quality;

		public GameObject receiver;

		public GameObject meshContainer;

		public GameObject skinnedMeshContainer;

		public List<IMeshProcessor> meshProcessors;

		public float creationTime;

		public float alpha;

		public int creationFrameNumber;

		public int bakeInFrameNumber;

		public bool needUVRecreation;

		public bool needGeometryRecreation;

		//[HideInInspector]
		[SerializeField]
		public Mesh sharedMesh;

		[SerializeField]
		//[HideInInspector]
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

		public float CurrentFadeoutTime { get; set; }

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

		public Vector3 InverseProjectionDirection { get; set; }

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

		public void StartFadeOut()
		{
		}

		public void StartFade(FadingMode mode = FadingMode.Out)
		{
		}

		public IEnumerator ProcessFadeOut()
		{
			return null;
		}

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

		public void CreateDecalGameObject()
		{
		}

		public void SetChildTransform(GameObject child)
		{
		}

		public void ResetMesh()
		{
		}

		public Mesh FindSharedMesh()
		{
			return null;
		}

		public GameObject Search(string name)
		{
			return null;
		}

		internal void AddDynamicMesh(DynamicMesh dynamicMesh, bool isStatic = false)
		{
		}

		public void ConvertAndAssign(DynamicMesh dynamicMesh, bool forceRecreation)
		{
		}

		public void AssignSharedMesh(Mesh mesh)
		{
		}

		public void PostProcessMesh(DynamicMesh mesh)
		{
		}

		public void PostProcessMesh(Mesh mesh)
		{
		}

		internal void TransformUV(DynamicMesh dynamicMesh)
		{
		}

		public void DrawMeshGeometryGizmos(Vector3[] vertices, Vector3[] normals)
		{
		}

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

		public void CallOnProjectionFinished(Mesh mesh)
		{
		}

		public void CallOnFadeOutStarted()
		{
		}

		public void CallOnFadedOut()
		{
		}

		public void CallOnFadedIn()
		{
		}

		public void CallOnAtlasIndexChanged()
		{
		}

		public void CallOnSourceChanged()
		{
		}

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

		public static EasyDecal ProjectInternal(GameObject decalPrefab, GameObject parent, Vector3 position, Quaternion rotation, Vector3 scale, bool instantiate)
		{
			return null;
		}

		public static List<EasyDecal> SearchChildren(Transform parent)
		{
			return null;
		}

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