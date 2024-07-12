using SLZ.Interaction;
using SLZ.Marrow.VoidLogic;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Nodes/VoidLogic Lever")]
	[Support(SupportFlags.BetaSupported, "This works, but should use Marrow primitives.")]
	public class LeverNode : BaseNode, IVoidLogicActuator, IVoidLogicNode, IVoidLogicSensor
	{
		[SerializeField]
		[Tooltip("Output response curve (multiplied by input)")]
		private AnimationCurve _curve;

		[Min(0f)]
		[Tooltip("Lever Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		[SerializeField]
		private int _steps;

		[Tooltip("Lever joint that drives the output power value")]
		[SerializeField]
		private Rigidbody _leverRigidBody;

		[FormerlySerializedAs("servo")]
		[SerializeField]
		private Servo _servo;

		[Tooltip("Interactable host i.e. for running haptics")]
		[SerializeField]
		private InteractableHost _interactableHost;

		[Header("Force")]
		[SerializeField]
		private float force_Spring;

		[SerializeField]
		private float force_Damper;

		[SerializeField]
		private float force_Max;

		[SerializeField]
		[Tooltip("Only measures value and do not dive joint")]
		private bool justMeasure;

		[Header("Audio")]
		[SerializeField]
		private AudioClip clip_clickOn;

		[SerializeField]
		private AudioClip clip_clickOff;

		private bool _canHaptic;

		private bool _leverThresholdHit;

		private bool _performedInitialRead;

		private static readonly PortMetadata _portMetadata;

		public ConfigurableJoint LeverConfigurableJoint
		{
			get
			{
				return null;
			}
		}

		public Servo Servo
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public InteractableHost InteractableHost
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public int Steps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float ForceSpring
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ForceDamper
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ForceMax
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Reset()
		{
		}

		private void Start()
		{
		}

		void IVoidLogicSensor.ReadSensors(NodeState nodeState)
		{
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		void IVoidLogicActuator.Actuate(NodeState nodeState)
		{
		}

		public LeverNode()
			: base()
		{
		}
	}
}
