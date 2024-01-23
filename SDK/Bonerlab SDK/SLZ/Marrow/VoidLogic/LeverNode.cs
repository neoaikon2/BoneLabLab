using System.Collections.Generic;
using System.Text;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Lever")]
	public class LeverNode : BaseNode
	{
		[SerializeField]
		[Tooltip("Output response curve (multiplied by input)")]
		private AnimationCurve _curve;

		[Min(0f)]
		[SerializeField]
		[Tooltip("Lever Types:\n0 => Free\n1 => Momentary\n2+ => Stepped")]
		private int _steps;

		[SerializeField]
		[Tooltip("Lever joint that drives the output power value")]
		private ConfigurableJoint _leverConfigurableJoint;

		[SerializeField]
		[Tooltip("Interactable host i.e. for running haptics")]
		private InteractableHost _interactableHost;

		[Header("Force")]
		[SerializeField]
		private float force_Spring;

		[SerializeField]
		private float force_Damper;

		[SerializeField]
		private float force_Max;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup _mixerGroup;

		[SerializeField]
		private AudioClip clip_clickOn;

		[SerializeField]
		private AudioClip clip_clickOff;

		private bool _canHaptic;

		private bool _leverThresholdHit;

		private float _localPowerValue;

		public Transform warpOnStart;

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
