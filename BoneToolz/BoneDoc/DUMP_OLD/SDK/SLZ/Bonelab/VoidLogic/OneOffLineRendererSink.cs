using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Line Renderer One-off Sink")]
	[Support(SupportFlags.CowboySupported, "This is a one-off. Your bugs are your own unless or until we have a plan to generalize this into Marrow.")]
	public sealed class OneOffLineRendererSink : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		private MonoBehaviour _previousNode;

		private float _priorValue;

		[SerializeField]
		private Renderer[] _renderers;

		[SerializeField]
		private int[] _materialIndex;

		[SerializeField]
		private Material _offMat;

		[SerializeField]
		private Material _onMat;

		[SerializeField]
		private float lowThreshold;

		[SerializeField]
		private float highThreshold;

		private bool _isHigh;

		[Interface(typeof(IVoidLogicSink), false)]
		[SerializeField]
		private MonoBehaviour nextNode;

		[SerializeField]
		private Mesh segmentMesh;

		[SerializeField]
		private Mesh endMesh;

		[SerializeField]
		private bool movingEndPoint;

		[SerializeField]
		private Transform overrideStartPoint;

		[SerializeField]
		private Transform overrideEndPoint;

		public float lineEdgeOffset;

		public float scale;

		private Vector3 startPoint;

		private Vector3 endPoint;

		public GameObject testMesh;

		public GameObject testMeshArrow;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		PortMetadata IVoidLogicNode.PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Awake()
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

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateLine()
		{
		}

		private void AddSegment()
		{
		}

		private void RemoveSegment()
		{
		}

		private void UpdateMats(Material mat)
		{
		}

		public bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input)
		{
			return default(bool);
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return default(bool);
		}

		public OneOffLineRendererSink()
			: base()
		{
		}
	}
}
