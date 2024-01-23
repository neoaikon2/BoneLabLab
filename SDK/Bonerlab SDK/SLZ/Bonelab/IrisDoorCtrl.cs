using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class IrisDoorCtrl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CcheckDoor_003Ed__16
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IrisDoorCtrl _003C_003E4__this;

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
			public _003CcheckDoor_003Ed__16(int _003C_003E1__state)
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

		public OcclusionPortal occlusionPortal;

		public Transform closeTarget;

		public Transform[] irisTransform;

		public GameObject doorTrigger;

		public bool closedOnStart;

		private bool[] _bladeClosed;

		private float _closeTolerance;

		private Coroutine _irisDoorCheck;

		private bool _irisIsOpen;

		private float _waitTime;

		private void Start()
		{
		}

		public void EnableTrigger()
		{
		}

		public void DisableTrigger()
		{
		}

		public void ToggleTrigger()
		{
		}

		public void IrisOpening()
		{
		}

		public void IrisClosing()
		{
		}

		[IteratorStateMachine(typeof(_003CcheckDoor_003Ed__16))]
		private IEnumerator checkDoor()
		{
			return null;
		}
	}
}
