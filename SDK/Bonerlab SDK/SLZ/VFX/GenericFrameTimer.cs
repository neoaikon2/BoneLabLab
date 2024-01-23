using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.VFX
{
	public class GenericFrameTimer : MonoBehaviour
	{
		private enum FrameType
		{
			FixedUpdate = 0,
			EndOfFrame = 1
		}

		[CompilerGenerated]
		private sealed class _003CFrameCounter_003Ed__5
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GenericFrameTimer _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CFrameCounter_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003CFixedFrameCounter_003Ed__6
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GenericFrameTimer _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CFixedFrameCounter_003Ed__6(int _003C_003E1__state)
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
		private FrameType CountingType;

		[SerializeField]
		private int FramesToCount;

		[SerializeField]
		private UnityEvent TimerUp;

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CFrameCounter_003Ed__5))]
		private IEnumerator FrameCounter()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFixedFrameCounter_003Ed__6))]
		private IEnumerator FixedFrameCounter()
		{
			return null;
		}
	}
}
