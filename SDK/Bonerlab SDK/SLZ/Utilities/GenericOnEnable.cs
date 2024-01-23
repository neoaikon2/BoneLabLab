using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericOnEnable : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoDelaySpawn_003Ed__3
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GenericOnEnable _003C_003E4__this;

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
			public _003CCoDelaySpawn_003Ed__3(int _003C_003E1__state)
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
		private UnityEvent StartEvent;

		private bool wasJustAwake;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelaySpawn_003Ed__3))]
		private IEnumerator CoDelaySpawn()
		{
			return null;
		}

		private void OnEnable()
		{
		}
	}
}
