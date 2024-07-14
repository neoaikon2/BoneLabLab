using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.BetaSupported, "This works, but uses ConfigurableJoint instead of Marrow primitives.")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/LinearJoint")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Linear Joint (Sliding)")]
	public sealed class LinearJoint : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		private float? _priorValue;

		[SerializeField]
		private bool _warpOnStart;

		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		private Rigidbody _rigidBody;

		[Header("Joint Control")]
		[SerializeField]
		private bool _varyTargetPosition;

		[SerializeField]
		private Vector3 _minPosition;

		[SerializeField]
		private Vector3 _maxPosition;

		[SerializeField]
		private bool _varyTargetVelocity;

		[SerializeField]
		private Vector3 _minVelocity;

		[SerializeField]
		private Vector3 _maxVelocity;

		[SerializeField]
		private bool _varyPrismaticDrive;

		[SerializeField]
		private Vector3 _xMinSpringDamperForce;

		[SerializeField]
		private Vector3 _xMaxSpringDamperForce;

		[SerializeField]
		private bool _varyPrismaticY;

		[SerializeField]
		private Vector3 _yMinSpringDamperForce;

		[SerializeField]
		private Vector3 _yMaxSpringDamperForce;

		[SerializeField]
		private bool _varyPrismaticZ;

		[SerializeField]
		private Vector3 _zMinSpringDamperForce;

		[SerializeField]
		private Vector3 _zMaxSpringDamperForce;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

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

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicActuator_002EActuate(ref NodeState nodeState)
		{
		}

		private void SETJOINT(float voltage = 1f)
		{
		}

		private void WarpJoint()
		{
		}

		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		public void Actuate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}
	}
}
