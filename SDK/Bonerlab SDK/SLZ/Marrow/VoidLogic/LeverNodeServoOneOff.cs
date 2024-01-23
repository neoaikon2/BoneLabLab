using System.Collections.Generic;
using System.Text;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Lever Servo One Off")]
	[RequireComponent(typeof(Servo))]
	public class LeverNodeServoOneOff : BaseNode
	{
		public Servo servo;

		[Tooltip("Output response curve (multiplied by input)")]
		[SerializeField]
		private AnimationCurve _curve;

		[SerializeField]
		[Tooltip("Lever Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		[Min(0f)]
		private int _steps;

		[Tooltip("Lever joint that drives the output power value")]
		[SerializeField]
		private ConfigurableJoint _leverConfigurableJoint;

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
		[Header("Audio")]
		private AudioMixerGroup _mixerGroup;

		[SerializeField]
		private AudioClip clip_clickOn;

		[SerializeField]
		private AudioClip clip_clickOff;

		[SerializeField]
		private AudioClip clip_clickEnd;

		private bool _canHaptic;

		private bool _leverThresholdHit;

		private float _localPowerValue;

		public Transform warpOnStart;

		private bool leverCycle;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public ConfigurableJoint LeverConfigurableJoint
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Rigidbody LeverRigidBody { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LEVERCHECK(bool canSound = false)
		{
		}

		protected override float CalculateValue()
		{
			return 0f;
		}

		private void HAPTOUT()
		{
		}

		public override void AppendNodeInfo(StringBuilder sb)
		{
		}

		public override IReadOnlyList<InputDescription> DescribeInputs()
		{
			return null;
		}
	}
}
