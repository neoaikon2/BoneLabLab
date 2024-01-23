using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Button")]
	public class ButtonNode : BaseNode
	{
		[SerializeField]
		protected float _lowThreshold;

		[SerializeField]
		protected float _highThreshold;

		[SerializeField]
		protected ConfigurableJoint _joint;

		[SerializeField]
		protected Transform _endTransform;

		[Header("Audio")]
		[Tooltip("Clip(s) to be played on button press")]
		[SerializeField]
		protected AudioClip[] _pressClips;

		[SerializeField]
		[Tooltip("Clip(s) to be played on button unpress")]
		protected AudioClip[] _depressClips;

		[SerializeField]
		[Tooltip("Mixer group for pressed/unpressed clips")]
		protected AudioMixerGroup _mixerGroup;

		[Tooltip("Colliders that the button shaft collider will ignore")]
		[SerializeField]
		protected Collider[] _ignoreColliders;

		[SerializeField]
		protected Collider _buttonShaftCollider;

		protected Rigidbody _rigidBody;

		private Vector3 _initialDisplacement;

		protected bool _isPressed;

		protected float _previousPercent;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		private Vector3 Displacement => default(Vector3);

		protected float Percent => 0f;

		private void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Update()
		{
		}

		protected override float CalculateValue()
		{
			return 0f;
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
