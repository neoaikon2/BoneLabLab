using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AlwaysLookAt : ZoneItem
	{
		[CompilerGenerated]
		private sealed class _003CTickLook_003Ed__7
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
			public _003CTickLook_003Ed__7(int _003C_003E1__state)
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

		public Transform local;

		public Transform target;

		public bool isPhysics;

		public ConfigurableJoint jnt_Rotator;

		private void Start()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		[IteratorStateMachine(typeof(_003CTickLook_003Ed__7))]
		private IEnumerator TickLook()
		{
			return null;
		}

		private void UpdateLookat()
		{
		}

		private void OnDisable()
		{
		}
	}
}
