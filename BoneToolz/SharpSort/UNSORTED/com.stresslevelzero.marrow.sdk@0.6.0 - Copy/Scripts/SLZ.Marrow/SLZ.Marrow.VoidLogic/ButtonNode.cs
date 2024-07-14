using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Button")]
	public class ButtonNode : BaseNode, IVoidLogicSensor, IVoidLogicNode, IVoidLogicActuator
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

		[Tooltip("Clip(s) to be played on button unpress")]
		[SerializeField]
		protected AudioClip[] _depressClips;

		[Tooltip("Colliders that the button shaft collider will ignore")]
		[SerializeField]
		protected Collider[] _ignoreColliders;

		[SerializeField]
		protected Collider _buttonShaftCollider;

		protected Rigidbody _rigidBody;

		private Vector3 _initialDisplacement;

		protected bool _isPressed;

		private bool _performedInitialRead;

		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata => default(PortMetadata);

		private new void Awake()
		{
		}

		protected override void OnEnable()
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

		public void Actuate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}

		public void ReadSensors(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}
	}
}
