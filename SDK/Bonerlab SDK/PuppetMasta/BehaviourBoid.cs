using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBoid : BehaviourBaseNav
	{
		[CompilerGenerated]
		private sealed class _003CBluntAttackStun_003Ed__50
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float damage;

			public BehaviourBoid _003C_003E4__this;

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
			public _003CBluntAttackStun_003Ed__50(int _003C_003E1__state)
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
		private sealed class _003CSelfDespawn_003Ed__57
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourBoid _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__57(int _003C_003E1__state)
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
		private sealed class _003CSpoolCounter_003Ed__83
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourBoid _003C_003E4__this;

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
			public _003CSpoolCounter_003Ed__83(int _003C_003E1__state)
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

		public Transform target;

		public Action behaviourDead;

		public bool actionReady;

		public float[] incomingActions;

		public BehaviourBoidAgent_SlicedInference boidAgent;

		private int _armsLayer;

		private int _mSecAnim;

		private int _locoCycleAnim;

		private int _flinchAnim;

		private int _spinAttackAnim;

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

		public RigidBodyDamageDealer[] dmgDealers;

		public SubBehaviourIk ik;

		public GameObject throwVfx;

		public Spawnable despawnVFX;

		public bool findBehaviourBall;

		public float impulseDmgThresh;

		public float wayPointTime;

		public float wayPointCounter;

		public float bluntAttackTime;

		public float bluntAttackCounter;

		public GameObject[] wayPoints;

		private BehaviourBoidBall behaviourBall;

		public InteractableHost intHost;

		public Grip grip;

		public InferenceAgent agent;

		public MentalState[] start_state_list;

		public int start_state_ind;

		private int trigger_layer;

		[Range(0f, 1f)]
		[Tooltip("Number bettween 0 and 1 for whether boid will attack each attack (behaviour) tick")]
		public float attackProbability;

		[Tooltip("Maximum amount of time the boid spools up during attack")]
		public float maxSpoolTime;

		[Tooltip("Min amount of time the boid spools up during attack")]
		public float minSpoolTime;

		private float attackDecision;

		private float desiredSpoolTime;

		private float currentSpoolTime;

		public float agroTickRate;

		public float agroAttackDistanceThresh;

		public float maxNoLocoTime;

		public float curNoLocoTime;

		public float minSpeedPercent;

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

		public static BehaviourBoidBall FindBall(GameObject childObject)
		{
			return null;
		}

		public void MlZoneCallbackResponse()
		{
		}

		protected override void OnInitiate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		protected override void OnUpdate()
		{
		}

		private void TakeDelayedAction()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		[IteratorStateMachine(typeof(_003CBluntAttackStun_003Ed__50))]
		private IEnumerator BluntAttackStun(float damage)
		{
			return null;
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		public void DetatchGrip()
		{
		}

		[ContextMenu("Force Kill")]
		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void ResetAnimator()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__57))]
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

		private void SetAgentActive()
		{
		}

		private void SetAgentInactive()
		{
		}

		private void Awake()
		{
		}

		protected override void AiUpdate()
		{
		}

		protected override void AiTick()
		{
		}

		[IteratorStateMachine(typeof(_003CSpoolCounter_003Ed__83))]
		private IEnumerator SpoolCounter()
		{
			return null;
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
	}
}
