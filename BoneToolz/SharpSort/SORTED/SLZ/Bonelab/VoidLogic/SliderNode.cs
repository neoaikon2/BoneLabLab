using SLZ.Interaction;
using SLZ.Marrow.VoidLogic;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.BetaSupported, "This works, but should use Marrow primitives.")]
	[AddComponentMenu("VoidLogic/Bonelab/Nodes/VoidLogic Slider")]
	public class SliderNode : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[Tooltip("Output response curve (multiplied by input)")]
		private AnimationCurve _curve;

		[SerializeField]
		[Tooltip("Slider Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		[Min(0f)]
		private int _steps;

		[Tooltip("Slider joint that drives the output power value")]
		[SerializeField]
		private ConfigurableJoint _sliderConfigurableJoint;

		[SerializeField]
		[Tooltip("Interactable host i.e. for running haptics")]
		private InteractableHost _interactableHost;

		[SerializeField]
		[Header("Force")]
		private float force_Spring;

		[SerializeField]
		private float force_Damper;

		[SerializeField]
		private float force_Max;

		[SerializeField]
		[Tooltip("Only measures value and do not drive joint")]
		private bool justMeasure;

		[Header("Audio")]
		[SerializeField]
		private AudioClip clip_clickOn;

		[SerializeField]
		private AudioClip clip_clickOff;

		private Haptor _haptor;

		private bool _canHaptic;

		private bool _sliderThresholdHit;

		private float _localPowerValue;

		private bool _performedInitialRead;

		private static readonly PortMetadata _portMetadata;

		public ConfigurableJoint SliderConfigurableJoint
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Rigidbody SliderRigidBody { get; private set; }

		public Haptor Haptor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override PortMetadata PortMetadata => default(PortMetadata);

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSensor_002EReadSensors(ref NodeState nodeState)
		{
		}

		public override void Calculate(ref NodeState nodeState)
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicActuator_002EActuate(ref NodeState nodeState)
		{
		}
	}
}
