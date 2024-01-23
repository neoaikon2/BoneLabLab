using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInitiate_003Ed__7
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OffsetModifierVRIK _003C_003E4__this;

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
			public _003CInitiate_003Ed__7(int _003C_003E1__state)
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

		[Tooltip("The master weight")]
		public float weight;

		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		private float lastTime;

		protected float deltaTime => 0f;

		protected abstract void OnModifyOffset();

		protected virtual void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CInitiate_003Ed__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		private void ModifyOffset()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
