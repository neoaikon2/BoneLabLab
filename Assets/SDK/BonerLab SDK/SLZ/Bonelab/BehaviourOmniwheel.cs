using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using PuppetMasta;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BehaviourOmniwheel : BehaviourGrabbableBaseNav
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
		}		[Header("Omni Settings")]
		public float scaleFactor;

		[Header("Projection")]
		public bool hasCombatProjection;

		public Animator projectionAnimator;

		public Transform hipsProjTransform;

		public Transform chestProjTransform;

		public Transform headProjTransform;

		public Transform gunPropTransform;

		public AnimationCurve deathFlicker;

		public AnimationCurve distanceFromHeadFlicker;

		public float holoFadeAngleMax;

		public float fadeActivationPerc;

		public float fadeBlendValue;

		public bool useConstantFlicker;

		public float minFlickerFadeFreq;

		public float maxFlickerFadeFreq;

		public float flickerVelThresh;

		public bool crumbleDeath;

		public float DeathExplosionForce;

		public float CrumbleDespawnTime;

		private float _animationBlendWeightV;

		private bool _debugDrawHierarchy;

		private int _additiveAimNormalAnim;

		private int _crouchAnim;

		private int _yLocoAnim;

		private int _xLocoAnim;

		private int _xAimAddAnim;

		private int _yAimAddAnim;

		private int _atEaseAnim;

		private int _walkingAnim;

		private int _accuracyAnim;

		private Quaternion _gunDefaultQuat;

		private bool hasFaded;

		private float maxNormAngle;

		private bool _joystickRecieved;

		private Vector3 _joystickVel;

		private Vector3 _joystickForwardWorld;

		[Header("Dependencies")]
		public Spawnable rigidbodyProjectileSpawnable;

		[Header("Agro State")]
		[EnumFlags]
		public CombatType combatProficiency;

		public CombatType agroState;

		public float chargePrepSpeed;

		public float chargeAttackSpeed;

		public float chargeWindupDistance;

		public float chargeCooldown;

		private ChargeState _chargeState;

		public Gun gun;

		private GunfightState _gunfightState;

		public float meleeRange;

		public float desiredMeleeDistance;

		public float meleeCooldown;

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

		public float wheelRadius;

		[Range(0f, 16f)]
		public float restingActivateRange;

		public float jumpCooldown;

		public float jumpCharge;

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
		public EngagedMode engagedMode;

		public float followDistance;

		public float followSpeed;

		public float breakFollowTargetDistance;

		public float breakFollowHomeDistance;

		public float hideDistance;

		public float hideSpeed;

		public float breakHideTargetDistance;

		public float breakHideHomeDistance;

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

		private void ResetFootBall()
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

		private void RestoreCombatProjection()
		{
		}

		private void DoProjectorDeath()
		{
		}

		protected override void RestoreFromCrumbleDeath()
		{
		}

		protected override void DoCrumbleDeath()
		{
		}
		private UniTaskVoid FlickerDeathAsync(float duration)
		{
			return default(UniTaskVoid);
		}
		private UniTaskVoid SelfDespawnAsync(float duration)
		{
			return default(UniTaskVoid);
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		protected virtual void HologramFade()
		{
		}
		private IEnumerator CoFlicker(float duration)
		{
			return null;
		}
		private IEnumerator CoFlickerSin(float duration)
		{
			return null;
		}

		protected override void SetAnimatorVars()
		{
		}

		protected override void ResetAnimator()
		{
		}

		protected override void Awake()
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
	}
}
