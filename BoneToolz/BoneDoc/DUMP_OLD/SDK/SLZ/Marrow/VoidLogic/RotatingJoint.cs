using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/RotatingJoint")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Rotating Joint")]
	[Support(SupportFlags.BetaSupported, "This works, but uses ConfigurableJoint instead of Marrow primitives.")]
	public sealed class RotatingJoint : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		private float? _priorValue;

		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		private Rigidbody _rigidBody;

		[Header("Joint Control")]
		[SerializeField]
		private bool _varyTargetRotation;

		[SerializeField]
		private float _minDegreesX;

		[SerializeField]
		private float _maxDegreesX;

		[SerializeField]
		private bool _varyTargetAngVelocity;

		[SerializeField]
		private Vector3 _minAngVelocity;

		[SerializeField]
		private Vector3 _maxAngVelocity;

		[SerializeField]
		private bool _varyAngularDrive;

		[SerializeField]
		private Vector3 _xAngMinSpringDamperForce;

		[SerializeField]
		private Vector3 _xAngMaxSpringDamperForce;

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

		private void SETJOINT(float voltage = 1f)
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

		public RotatingJoint()
			: base()
		{
		}
	}
}
