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
	public class GripParentMover : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoMoveJoints_003Ed__11
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GripParentMover _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

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
			public _003CCoMoveJoints_003Ed__11(int _003C_003E1__state)
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
		private ConfigurableJoint[] joints;

		[SerializeField]
		private InteractableHost[] hosts;

		[SerializeField]
		private float lerpDuration;

		private Coroutine moveRoutine;

		[SerializeField]
		private Collider[] localColliders;

		[SerializeField]
		private Collider[] collidersToIgnore;

		[SerializeField]
		private UnityEvent OnCompleteMove;

		[SerializeField]
		private Vector3 startPos;

		[SerializeField]
		private Vector3 endPos;

		private void Start()
		{
		}

		[ContextMenu("StartMove")]
		public void ExtrudeAndStartCountdown()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveJoints_003Ed__11))]
		private IEnumerator CoMoveJoints()
		{
			return null;
		}

		public void ForceDetachAll()
		{
		}

		public void IgnoreColliders(bool ignore = true)
		{
		}
	}
}
