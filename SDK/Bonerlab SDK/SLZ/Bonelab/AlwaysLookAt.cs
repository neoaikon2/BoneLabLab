using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AlwaysLookAt : ZoneLinkItem
	{
		/*
		[CompilerGenerated]
		private sealed class _003CTickLook_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AlwaysLookAt _003C_003E4__this;

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
			public _003CTickLook_003Ed__9(int _003C_003E1__state)
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
		*/

		public Transform local;

		public Transform target;

		public bool isPhysics;

		public ConfigurableJoint jnt_Rotator;

		private Coroutine tickLook;

		private void Start()
		{
		}

		protected override void OnEnter(MarrowEntity playerEntity)
		{
		}

		protected override void OnExit(MarrowEntity playerEntity)
		{
		}

		private void SetPlayerTarget(MarrowEntity playerEntity)
		{
		}

		//[IteratorStateMachine(typeof(_003CTickLook_003Ed__9))]
		private IEnumerator TickLook()
		{
			return null;
		}

		private void UpdateLookat()
		{
		}

		private new void OnDisable()
		{
		}
	}
}
