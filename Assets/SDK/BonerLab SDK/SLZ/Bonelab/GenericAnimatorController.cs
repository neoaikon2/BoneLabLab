using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RealisticEyeMovements;
using SLZ.Marrow.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GenericAnimatorController : MonoBehaviour
	{
		[Serializable]
		public class AnimationAudioPair
		{
			public AnimationClip animationClip;

			public AudioClip audioClip;

			public int animationIndex;
		}

		[Serializable]
		public class AnimatorStateMachineGroup
		{
			public List<AnimationAudioPair> animationAudioPairList;

			public string triggerName;

			public string triggerIndexName;
		}

		[Serializable]
		public class AnimatorSequence
		{
			public string description;

			public int stateMachineIndex;

			public int[] animationIndex;

			public float startBufferTime;

			public float endBufferTime;

			public bool autoProgress;

			public bool lookAtPlayer;

			public TriggerActionGroup[] TriggerActions;
		}

		[Serializable]
		public class TriggerActionGroup
		{
			public float triggerActionDelay;

			public UnityEvent onAnimationTriggerAction;
		}
		public Animator animator;

		public Transform audioTransform;

		public LookTargetController lookTargetController;

		public float audioSourceMinDist;

		public List<AnimatorStateMachineGroup> StateMachineGroups;

		public List<AnimatorSequence> animationSequence;

		public bool updateTimeScale;

		private static readonly int Cancel;

		private IEnumerator sequencePosition;

		private int currentSequenceIndex;

		private int nextSequenceIndex;

		private static readonly int TimeScale;

		private float _lastTimeScale;

		private ManagedAudioPlayer audioSource;

		private void Start()
		{
		}

		public void CANCELANIMATION()
		{
		}
		private IEnumerator CancelAnimationCoroutine()
		{
			return null;
		}

		public void ADVANCESEQUENCE()
		{
		}

		public void GOTOSEQUENCEINDEX(int sequence)
		{
		}
		private IEnumerator SetSequencePosition(int stateMachine, int animation, AnimatorSequence sequence)
		{
			return null;
		}
		private IEnumerator TriggerAction(UnityEvent action, float delay)
		{
			return null;
		}

		public void GOTOSPECIFICINDEX(int stateMachine, int animation, bool lookAtPlayer)
		{
		}
		private IEnumerator SetSpecificIndex(int stateMachine, int animation, bool lookAtPlayer)
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
