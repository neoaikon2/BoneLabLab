using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using SLZ.Marrow.Data;
using SLZ.Props;
using SLZ.Props.Weapons;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourOmniwheel : BehaviourBaseNav
	{
		[Flags]
		public enum CombatType
		{
			Charge = 1,
			JumpAttack = 2,
			ThrowLob = 4,
			GunFight = 8
		}

		public enum ChargeState
		{
			Windup = 0,
			Lockon = 1,
			Charge = 2
		}

		public enum GunfightState
		{
			Aim = 0,
			Fire = 1,
			Reload = 2,
			Reposition = 3
		}

		protected enum JumpType
		{
			Dash = 0,
			Attack = 1,
			FaceMount = 2,
			OffmeshLink = 3
		}

		public enum EngagedMode
		{
			Follow = 0,
			Stay = 1,
			Hide = 2
		}

		[Header("Omni Settings")]
		public float scaleFactor = 1.0f;

		[Header("Projection")]
		public bool hasCombatProjection = false;

		public Animator projectionAnimator;

		public Transform hipsProjTransform;

		public Transform chestProjTransform;

		public Transform headProjTransform;

		public Transform gunPropTransform;

        public AnimationCurve deathFlicker = AnimationCurve.Linear(0.0f, 1.0f, 1.0f, 0.0f);

		public bool crumbleDeath;

		public float DeathExplosionForce = 3000;

		public float CrumbleDespawnTime = 3;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		private bool _debugDrawHierarchy;

		private int _yLocoAnim;

		private int _xLocoAnim;

		private int _additiveAimNormalAnim;

		private int _xAimAddAnim;

		private int _yAimAddAnim;

		private int _crouchAnim;

		private int _atEaseAnim;

		private int _walkingAnim;

		private int _accuracyAnim;

		private Quaternion _gunDefaultQuat;

		private bool _joystickRecieved;

		private Vector3 _joystickVel;

		private Vector3 _joystickForwardWorld;

		[Header("Dependencies")]
		public Spawnable rigidbodyProjectileSpawnable;

		[Header("Agro State")]
		[EnumFlags]
		public CombatType combatProficiency;

		public CombatType agroState = CombatType.Charge;

		public float chargePrepSpeed = 2.0f;

		public float chargeAttackSpeed = 6.0f;

		public float chargeWindupDistance = 12.0f;

		public float chargeCooldown = 8.0f;

		private ChargeState _chargeState;

		public Gun gun;

		private GunfightState _gunfightState;

		public float meleeRange = 1.0f;

		public float desiredMeleeDistance = 0.8f;

		public float meleeCooldown = 3.0f;

		public bool enableJumpAttack;

		private float _cooldownMelee;

		private float _cooldownGun;

		private float _meleeActiveUntilTime;

		private float _aimZeroOverTime;

		private bool _attackActive;

		private Vector3 _targetFromGunWorldDir;

		private Vector3 _desiredProjectileVel;

		private Quaternion _localAim1;

		private Quaternion _localAim2;

		private int _burstCount;

		protected JumpType jumpType;

		public float wheelRadius = 0.1f;

		[Range(0f, 16f)]
		public float restingActivateRange = 3.0f;

		public float jumpCooldown = 3.0f;

		public float jumpCharge = 0.0f;

		private Vector3 _lookDirectionWorld;

		private bool _chargeJump;

		private bool _blockAiTick;

		private bool _isCalculated;

		private float _dyingTime;

		private float _unbalancedTimer;

		private float _wheelCircumference;

		private Quaternion _worldFootBall;

		private Quaternion _lastWorldFootBall;

		[Header("Engaged State")]
		public EngagedMode engagedMode = EngagedMode.Hide;

		public float followDistance = 2.0f;

		public float followSpeed = 1.0f;

		public float breakFollowTargetDistance = 10.0f;

		public float breakFollowHomeDistance = 30.0f;

		public float hideDistance = 15.0f;

		public float hideSpeed = 4.0f;

		public float breakHideTargetDistance = 10.0f;

		public float breakHideHomeDistance = 50.0f;

		private Vector3 _mirrorLeftDir;

		private Vector3 _mirrorRightDir;

		private Vector3 _lastMirrorLeftDir;

		private Vector3 _lastMirrorRightDir;

		private float _t;

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public void StartDeathFlicker()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		protected override void ResetAnimator()
		{
		}

		private IEnumerator CoFlickerDeath(float duration)
		{
			return null;
		}

		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		public void JOYSTICK(PropJoystick.JoystickData joyData)
		{
		}

		private void Awake()
		{
		}

		private void SwitchAgroState()
		{
		}

		private void UpdateAttack()
		{
		}

		private void TickAttack()
		{
		}

		protected override void AiUpdate()
		{
		}

		protected override void AiTick()
		{
		}

		protected override void SwitchMentalState(MentalState mState)
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		public void UpdateEngagedFrame()
		{
		}

		public void UpdateEngagedTick()
		{
		}

		public void SwitchEngagedState()
		{
		}

		public BehaviourOmniwheel()
			: base()
		{
		}
	}
}
