using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Marrow.Data;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBoidBall : BehaviourBaseNav
	{
		public delegate void OnProxChangeDelegate(float newVal);

		public delegate void OnGoalChangeDelegate(float newVal);

		public delegate void OnShotChangeDelegate(bool newVal);

		public delegate void OnSquishChangeDelegate(bool newVal);

		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__124
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourBoidBall _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSelfDespawn_003Ed__124(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CBallRadiusStateController_003Ed__157
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourBoidBall _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CBallRadiusStateController_003Ed__157(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public BehaviourBoidBallConfig ballConfig;

		public bool useRadiusController;

		public GameObject tempWayPoint;

		public Transform target;

		public GameObject target_GameObject;

		public RigidBodyDamageDealer[] dmgDealers;

		public GameObject throwVfx;

		public Spawnable despawnVFX;

		public Spawnable takeDmgVFX;

		private int _armsLayer;

		private int _mSecAnim;

		private int _locoCycleAnim;

		private int _flinchAnim;

		private int _angryAnim;

		private int _awakeAnim;

		private int _unGroundedAnim;

		private int _emissColor;

		private int _attackAnim;

		private int _clipIntAnim;

		private int _gestureAnim;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		public Action behaviourDead;

		public bool debug_gizmos;

		private float prox_radius;

		public float prox_radius_min;

		public float prox_radius_max;

		private float goal_radius;

		public float goal_radius_min;

		public float goal_radius_max;

		public float state_lerp_rate_min;

		public float state_lerp_rate_max;

		public float rest_goal_min;

		public float rest_goal_max;

		public float rest_prox_min;

		public float rest_prox_max;

		public float rest_lerp_speed_min;

		public float rest_lerp_speed_max;

		public float rest_height;

		public float roam_goal_min;

		public float roam_goal_max;

		public float roam_prox_min;

		public float roam_prox_max;

		public float roam_lerp_speed_min;

		public float roam_lerp_speed_max;

		public float roam_height;

		public float investigate_goal_min;

		public float investigate_goal_max;

		public float investigate_prox_min;

		public float investigate_prox_max;

		public float investigate_lerp_speed_min;

		public float investigate_lerp_speed_max;

		public float investigate_height;

		public float agro_goal_min;

		public float agro_goal_max;

		public float agro_prox_min;

		public float agro_prox_max;

		public float agro_lerp_speed_min;

		public float agro_lerp_speed_max;

		public float agro_height;

		private bool squish_mode;

		private bool being_shot;

		public Vector3 shot_normal;

		public float being_shot_cooldown;

		public float being_shot_interval;

		public bool assign_listeners;

		public bool deactivateZoneOnDeath;

		public BoidBallMove ballMover;

		public BarracudaModelManagerMono bmm;

		public List<BehaviourBoid> boidList;

		public List<BehaviourBoid> dispatchedList;

		public ObjectPool wayPointPool;

		public MentalState[] start_state_list;

		public int start_state_ind;

		[Range(0f, 1f)]
		[Tooltip("The probability of a boid being selected during dispatch (each agro tick)")]
		public float dispatchRate;

		public float recallPercentage;

		public float agroTickRate;

		public float distFromPlayerMove;

		public Vector3 spawnPos;

		public float yDistTeleportThresh;

		public Spawnable teleportVFX;

		private Vector3 moveTargetPos;

		private bool prox_decreasing;

		private bool goal_decreasing;

		private bool decreasing;

		private float lerp_scale;

		public float Prox_radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Goal_radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Being_shot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Squish_mode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MentalState MState
		{
			get
			{
				return default(MentalState);
			}
			set
			{
			}
		}

		public event OnProxChangeDelegate OnProxChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnGoalChangeDelegate OnGoalChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnShotChangeDelegate OnShotChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnShotChangeDelegate OnSquishChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnNewTarget
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action Death
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private new void OnDrawGizmos()
		{
		}

		private void AliveFuncs()
		{
		}

		private void DeadFuncs()
		{
		}

		protected override void OnInitiate()
		{
		}

		private void OnEnable()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		[ContextMenu("Force Kill")]
		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnLateUpdate()
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

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__124))]
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

		private void OnDrawGizmosSelected()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SetTarget(Vector3 pos, Quaternion rot)
		{
		}

		private void DispatchHandler(TriggerRefProxy triggerRef)
		{
		}

		private void RecallBoids()
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

		private void OnApplicationQuit()
		{
		}

		[IteratorStateMachine(typeof(_003CBallRadiusStateController_003Ed__157))]
		public IEnumerator BallRadiusStateController()
		{
			return null;
		}
	}
}
