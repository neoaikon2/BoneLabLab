using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBaseTurret : BehaviourGrabbableBaseNav
	{
		public Transform target;

		public Action behaviourDead;

		public bool actionReady;

		public float[] incomingActions;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		public SubBehaviourIk ik;

		public GameObject throwVfx;

		public float artSlerpDrive;

		private JointDrive old;

		private bool damagedJoint;

		public MentalState[] start_state_list;

		public int start_state_ind;

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

		protected override void ResetAnimator()
		{
		}

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		protected override void OnUpdate()
		{
		}
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		private void TakeDelayedAction()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		private new void Awake()
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
	}
}
