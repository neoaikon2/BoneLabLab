using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GripTimerEvents : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoGripTimerRoutine_003Ed__11
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GripTimerEvents _003C_003E4__this;

			private float _003CstartTime_003E5__2;

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
			public _003CCoGripTimerRoutine_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CCoCheckGrips_003Ed__12
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CCoCheckGrips_003Ed__12(int _003C_003E1__state)
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

		[SerializeField]
		private Grip[] grips;

		[SerializeField]
		private float elapsedTime;

		[SerializeField]
		private float firstThreshold;

		[SerializeField]
		private float secondThreshold;

		public UnityEvent OnFirstThreshold;

		public UnityEvent OnSecondThreshold;

		private Coroutine gripTimerRoutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnGrab(Hand hand)
		{
		}

		public void OnDrop(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoGripTimerRoutine_003Ed__11))]
		private IEnumerator CoGripTimerRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCheckGrips_003Ed__12))]
		private IEnumerator CoCheckGrips()
		{
			return null;
		}
	}
}
