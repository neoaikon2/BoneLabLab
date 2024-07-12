using SLZ.Interaction;
using UnityEngine;

namespace SLZ.VRMK
{
	public class PhysLimb : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody _endRb;

		[SerializeField]
		private Rigidbody _upperRb;

		[SerializeField]
		private Rigidbody _lowerRb;

		[SerializeField]
		private Servo _endBaseServo;

		[SerializeField]
		private Servo _upperServo;

		[SerializeField]
		private Servo _lowerServo;

		[SerializeField]
		private Servo _endServo;

		public MeshCollider cUpper;

		public MeshCollider cLower;

		public BoxCollider endCol;

		public bool shutdown;

		public float forceMultiplier;

		[SerializeField]
		private float _limbInternalMult;

		[SerializeField]
		private PhysicMaterial _naturalFriction;

		[SerializeField]
		private PhysicMaterial _lowFriction;

		private int _playerLayer;

		private int _noCollideLayer;

		private bool _isKinematic;

		private float _lastForceMult;

		public Rigidbody rbEnd
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbUpper
		{
			get
			{
				return null;
			}
		}

		public Rigidbody rbLower
		{
			get
			{
				return null;
			}
		}

		public Servo endBaseServo
		{
			get
			{
				return null;
			}
		}

		public Servo upperServo
		{
			get
			{
				return null;
			}
		}

		public Servo lowerServo
		{
			get
			{
				return null;
			}
		}

		public Servo endServo
		{
			get
			{
				return null;
			}
		}

		public float limbInternalMult
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void IgnorePhysLimb(PhysLimb physLimb, bool ignore = true)
		{
		}

		public void IgnoreWholeLimbColliders(Collider col, bool ignore = true)
		{
		}

		public void IgnoreWholeLimbColliders(Collider[] col, bool ignore = true)
		{
		}

		public void CalibrateLimbColliders(Avatar avatar, bool isLeg = false, bool isRight = false)
		{
		}

		public void CalibrateLimbJoints(Avatar avatar, bool isRight = false)
		{
		}

		public void EarlyUpdateLimb()
		{
		}

		public void UpdateLimbTargets(Transform root, Transform upper, Transform lower, Transform end, float deltaTime)
		{
		}

		public void UpdateLimbDrives(float slerpForceMult, float slerpSpringMult, float slerpDampMult)
		{
		}

		public void UpdateLimbSupportDrives(float slerpForceMult, float slerpSpringMult, float slerpDampMult)
		{
		}

		public void SetLimbMass(float mass, bool isLeg = false)
		{
		}

		public void SetKinematic()
		{
		}

		public void SetPhysical()
		{
		}

		public void SetFrictionNatural()
		{
		}

		public void SetFrictionLow()
		{
		}

		public PhysLimb()
			: base()
		{
		}
	}
}
