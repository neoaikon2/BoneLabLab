using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Material Switcher")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MaterialSwitcher")]
	public class MaterialSwitcher : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node in the chain")]
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

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		public PortMetadata PortMetadata
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

		void IVoidLogicActuator.Actuate(NodeState nodeState)
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

		public MaterialSwitcher()
			: base()
		{
		}
	}
}
