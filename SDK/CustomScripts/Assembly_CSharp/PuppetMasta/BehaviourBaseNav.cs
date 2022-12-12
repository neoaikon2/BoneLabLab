using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.MIA;
using SLZ.Marrow.Utilities;
using SLZ.Zones;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace PuppetMasta
{
	public abstract class BehaviourBaseNav : BehaviourBase
	{
		public enum MentalState
		{
			Rest = 0,
			Roam = 1,
			Investigate = 2,
			Agroed = 3,
			Engaged = 4,
			MindControlled = 5
		}

		public enum LocoState
		{
			Standing = 0,
			Walking = 1,
			Fallen = 2,
			GetUp = 3,
			Jumping = 4,
			InAir = 5,
			Grappling = 6
		}

		private static ComponentCache<BehaviourBaseNav> _cache;

		public BaseEnemyConfig baseConfig;

		[SerializeField]
		protected BaseEnemyConfig defaultConfig;

		[Range(0f, 16f)]
		[Header("Resting State")]
		public float restingRange = 3.0f;

		public bool freezeWhileResting;

		public bool homeIsPost;

		[Range(1f, 16f)]
		[Header("Roam State")]
		public float activeRange = 5.0f;

		public float roamSpeed = 2.5f;

		public Vector2 roamRange = new Vector2(2, 2);

		public float roamAngSpeed = 180.0f;

		[Range(0f, 1f)]
		public float roamFrequency = .65f;

		public bool roamWanders = true;

		[Range(4f, 16f)]
		[Header("Investigate State")]
		public float investigateRange = 9.0f;

		[Header("Agro State General")]
		[EnumFlags]
		public TriggerRefProxy.NpcType agroOnNpcType = TriggerRefProxy.NpcType.FordHair | TriggerRefProxy.NpcType.FordShortHair | TriggerRefProxy.NpcType.EarlyExit | TriggerRefProxy.NpcType.NullBody;

		public float breakAgroTargetDistance = 10.0f;

		public float breakAgroHomeDistance = 30.0f;

		public float agroedSpeed = 1.0f;

		public float agroedAngSpeed = 180.0f;

		public LayerMask meleeAttackMask;

		public bool enableThrowAttack;

		public bool throwAttackUsesGravity;

		public bool forceAgentPath;

		public float fwdDotThresh = 0.5f;

		public float throwMaxRange = 20.0f;

		public float throwMinRange = 3.0f;

		public float throwCooldown = 3.0f;

		public float throwVelocity = 4.0f;

		public float gunRange = 60.0f;

		public float gunCooldown = 1.2f;

		[Range(0f, 10f)]
		public float accuracy = 3.0f;

		public float reloadTime = 2.2f;

		[Range(1f, 60f)]
		public int clipSize = 1;

		[Range(1f, 20f)]
		public int burstSize = 3;

		public float desiredGunDistance = 4.0f;

		[ColorUsage(true, true)]
		public Color baseColor = Color.black;

		[ColorUsage(true, true)]
		public Color agroColor = Color.black;

		public Renderer[] emissionRenderers;

		public bool isSoundAggroWhenInSecondaryZone;

		public MentalState mentalState = MentalState.Roam;

		public LocoState locoState = LocoState.Standing;

		public float aiTickFreq = 1.0f;

		[SerializeField]
		protected Transform eyeTran;

        [Tooltip("These must be linked to Muscle Collision Sensors on each bone")]
		public SubBehaviourSensors sensors;
        
		public SubBehaviourSfx sfx;

		public SubBehaviourHealth health;

		public ZoneTracker zoneTracker;

		protected NavMeshAgent _navAgent;

		private bool _homeBound;

		public Vector3 homePosition;

		public InteractableHostManager hostManager;

		protected MentalState _initialState;

		protected MentalState _preAggroState;

		protected bool investIsPosition;

		protected Vector3 _investigateTarget;

		protected Vector3 _targetDirWorld;

		protected Vector3 _targetDirNormalWorld;

		protected float _investigationCooldown;

		protected float _blockCollisionsUntil;

		protected float _lastAiTickTime;

		protected float _lastJumpTime;

		protected float _cooldownLocoSwitch;

		protected float _currentRotVel;

		protected float _currentRotDelta;

		protected float _animatedRotVel;

		protected Vector3 _animatedRoot;

		protected Quaternion _localAnimatedRoot;

		protected bool meleeAttackActive;

		protected bool _forceAiTick;

		protected int emissColor;

		protected int triggerCount;

		protected MaterialPropertyBlock materialPropertyBlock;

		protected VisualDamageController visualDamage;

		protected HashSet<Rigidbody> selfRbs;

		private Vector3 navTarget;

		private Vector3 flatNavTarget;

		public UnityEvent OnDeath;

		public UnityEvent OnDeathStart;

		private float _time;

		private float _fixedTime;

		private bool displayNavpath;

		private MIASimulationEventBroker _simulationEventBroker;

		public static ComponentCache<BehaviourBaseNav> Cache
		{
			get
			{
				return null;
			}
		}

		public float targetDistance { get; protected set; }

		protected MIASimulationEventBroker SimulationEventBroker
		{
			get
			{
				return null;
			}
		}

		protected override void OnInitiate()
		{
		}

		public void BlockCollisions(float time)
		{
		}

		private void OnDestroy()
		{
		}

		public void ChangeEmissiveColor(Color color)
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void Resurrect()
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

		public void SetRoam(Vector2 roamXz, float speed = 0.8f, bool wanders = false, float frequency = 0.2f)
		{
		}

		public void Investigate(Vector3 target, bool isPosition = false, float investForSeconds = 6f)
		{
		}

		public void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		public void SetTeam(int t)
		{
		}

		public void SetEngaged(TriggerRefProxy engagedTarget)
		{
		}

		public void AddThreat(TriggerRefProxy trp, float threat)
		{
		}

		public void SetPath(Vector3 target)
		{
		}

		protected void ProcessTargetRelativePathing(float idealDistance, float nearBuffer, float farBuffer, float orbitMeters = 0f)
		{
		}

		public void SetBaseConfig(BaseEnemyConfig baseEnemyConfig)
		{
		}

		public void SetHomePosition(Vector3 worldPosition, bool goToHome = true, bool homePost = false)
		{
		}

		public void SetHomeIsPost(bool isPost)
		{
		}

		public void ClearPath()
		{
		}

		protected void SetNavAgentToPhysics(float deltaTime = 0f)
		{
		}

		protected void SetNavAgent(float speed, float angSpeed, float accel = 2f, float stopDistance = 1f)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		protected bool CheckTarget()
		{
			return default(bool);
		}

		public virtual void DealMeleeDamage(MuscleCollision m, float impulse)
		{
		}

		protected float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return default(float);
		}

		private static float PredictiveAimWildGuessAtImpactTime()
		{
			return default(float);
		}

		public static bool PredictiveAim(Vector3 muzzlePosition, float projectileSpeed, Vector3 targetPosition, Vector3 targetVelocity, float gravity, [Out] Vector3 projectileVelocity)
		{
			return default(bool);
		}

		protected abstract void SwitchMentalState(MentalState mState);

		protected abstract void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false);

		protected virtual void AiUpdate()
		{
		}

		protected virtual void AiTick()
		{
		}

		protected virtual void ResetAnimator()
		{
		}

		protected virtual void ReturnToPreAgro()
		{
		}

		protected virtual void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		protected virtual void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		public new void OnDrawGizmos()
		{
		}

		public BehaviourBaseNav()
			: base()
		{
		}
	}
}
