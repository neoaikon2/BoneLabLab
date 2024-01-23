using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourAnimatedStagger")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		public struct FallParams
		{
			public float startPinWeightMlp;

			public float startMuscleWeightMlp;

			public float losePinSpeed;
		}

		[Serializable]
		public struct FallParamsGroup
		{
			public Muscle.Group[] groups;

			public FallParams fallParams;
		}

		[CompilerGenerated]
		private sealed class _003CLoseBalance_003Ed__23
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourAnimatedStagger _003C_003E4__this;

			private bool _003Cdone_003E5__2;

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
			public _003CLoseBalance_003Ed__23(int _003C_003E1__state)
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

		[Header("Master Properties")]
		public LayerMask groundLayers;

		public float animationBlendSpeed;

		public float animationMag;

		public float momentumMag;

		public float unbalancedMuscleWeightMlp;

		public float unbalancedMuscleDamperAdd;

		public bool dropProps;

		public float maxGetUpVelocity;

		public float minHipHeight;

		public SubBehaviourCOM centerOfMass;

		[Header("Muscle Group Properties")]
		public FallParams defaults;

		public FallParamsGroup[] groupOverrides;

		[Header("Events")]
		public PuppetEvent onUngrounded;

		public PuppetEvent onFallOver;

		public PuppetEvent onRest;

		[HideInInspector]
		public Vector3 moveVector;

		[HideInInspector]
		public bool isGrounded;

		[HideInInspector]
		public Vector3 forward;

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		[IteratorStateMachine(typeof(_003CLoseBalance_003Ed__23))]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}
	}
}
