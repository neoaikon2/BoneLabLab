using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AscentElevator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMovePlatform_003Ed__8
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AscentElevator _003C_003E4__this;

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
			public _003CMovePlatform_003Ed__8(int _003C_003E1__state)
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

		public Transform startObj;

		public Transform endObj;

		public Transform platform;

		[SerializeField]
		private float moveDuration;

		private Coroutine platformRoutine;

		private Vector3 startPos;

		private Vector3 endPos;

		public void StartMotion()
		{
		}

		[IteratorStateMachine(typeof(_003CMovePlatform_003Ed__8))]
		private IEnumerator MovePlatform()
		{
			return null;
		}
	}
}
