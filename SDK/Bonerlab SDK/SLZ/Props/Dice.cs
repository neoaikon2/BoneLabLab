using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	public class Dice : MonoBehaviour
	{
		[Serializable]
		public class UnityEventInt : UnityEvent<int>
		{
		}

		private enum DieState
		{
			Untouched = 0,
			Held = 1,
			Rolling = 2,
			Rolled = 3
		}

		[Serializable]
		public class dieSide
		{
			public Transform zDirection;

			public bool twoSided;

			public int fwdInt;

			public int backInt;
		}

		[CompilerGenerated]
		private sealed class _003CRolling_003Ed__27
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Dice _003C_003E4__this;

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
			public _003CRolling_003Ed__27(int _003C_003E1__state)
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

		private static ComponentCache<Dice> _cache;

		[SerializeField]
		public UnityEventInt activeRoll;

		public UnityEventInt resultRoll;

		[SerializeField]
		private Rigidbody _rb;

		[SerializeField]
		private InteractableHost _host;

		private Coroutine _rollingCo;

		private WaitForSeconds _wait;

		private int _lastRoll;

		private DieState _dieState;

		public dieSide[] sides;

		public static ComponentCache<Dice> Cache => null;

		public InteractableHost host => null;

		public Rigidbody rb => null;

		private void Awake()
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

		private void Reset()
		{
		}

		public int GetUpInt(Vector3 upDirection)
		{
			return 0;
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CRolling_003Ed__27))]
		private IEnumerator Rolling()
		{
			return null;
		}
	}
}
