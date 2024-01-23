using System;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class RemapRig : HeptaRig
	{
		public enum TraversalState
		{
			Walk = 0,
			Jog = 1,
			Run = 2,
			Jump = 3,
			Leap = 4,
			Airborne = 5,
			HandClimb = 6,
			QuadClimb = 7,
			FootClimb = 8
		}

		public enum VertState
		{
			Stand = 0,
			Crouch = 1,
			Kneel = 2,
			Prone = 3,
			Supine = 4,
			SitChair = 5,
			SitFloor = 6
		}

		[Header("RemapHeptaRig")]
		public Transform testGazeTarget;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		[Header("Movement")]
		public float maxVelocity;

		public float maxAcceleration;

		public float jumpVelocity;

		public float dragPerSec;

		public float brakingMult;

		public float doubleJumpPower;

		public TraversalState travState;

		public VertState vertState;

		private Vector2 _currentVelocity;

		private Vector2 _currentAcceleration;

		private float _currentVelocityY;

		private float _lastChestHeight;

		private float _smoothTwist;

		protected float currentMaxVelocity;

		public float feetOffset;

		public AnimationCurve JumpCurve;

		public AnimationCurve SwingCounterCurve;

		protected bool _feetThisFrame;

		protected float _crouchTarget;

		private float _crouchSpeedLimit;

		private bool _jumping;

		private int _jumpStage;

		private float _jumpCycle;

		private float _timeOfFlight;

		private float _jumpCharge;

		private float _spineCrouchOff;

		private Vector2 _trackedDebt;

		private Vector2 _locoDebt;

		private Vector2 _physDebt;

		private Vector2 _trackedApplied;

		private Vector2 _locoApplied;

		private Vector2 _physApplied;

		private Vector2 _artificialDelta;

		protected Vector3 _lastTrackedHead;

		protected SimpleTransform _lastHmdLocal;

		protected SimpleTransform _lastContLfLocal;

		protected SimpleTransform _lastContRtLocal;

		private Vector3 _trackedHeadDelta;

		[Range(0f, 1f)]
		public float holdTrackedGround;

		[Range(0f, 1f)]
		public float holdLocoGround;

		[Range(0f, 1f)]
		public float holdPhysGround;

		[Range(0.1f, 5f)]
		public float debtApplierMult;

		public bool jumpEnabled;

		public bool doubleJump;

		public static Action onPlayerJump;

		private Quaternion _rotationOffset;

		private bool _rotationOffsetDirty;

		private bool _rotationOffsetWasDirty;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnFirstFixedUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		protected virtual void ApplyMovement(Vector2 axis, bool inputPressed, float deltaTime)
		{
		}

		private Vector2 LocoDebtPre(Vector2 artiDelta, float deltaTime)
		{
			return default(Vector2);
		}

		private void LocoDebtPost()
		{
		}

		private void ApplyRotation(float deltaTime, float smoothTwist)
		{
		}

		public void SetTwist(float degrees)
		{
		}

		public void SetRotate(Quaternion offset)
		{
		}

		private void JumpCharge(float deltaTime, bool chargeInput = true)
		{
		}

		public void Jump()
		{
		}

		private void Jumping(float deltaTime)
		{
		}

		private void JumpEnd()
		{
		}

		protected virtual void CrouchHold(float deltaTime, float crouchRate = -1f, bool crouchInput = true)
		{
		}

		protected void MoveSpineCrouchOffTowards(float target, float deltaTime, float rate = 6.5f)
		{
		}

		private bool MantleGesture(out float mantle)
		{
			mantle = default(float);
			return false;
		}

		public Vector2 GetVelocity()
		{
			return default(Vector2);
		}

		public float GetVelocityY()
		{
			return 0f;
		}
	}
}
