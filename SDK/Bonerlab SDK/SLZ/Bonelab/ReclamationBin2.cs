using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ReclamationBin2 : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoDelayDespawn_003Ed__2
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Rigidbody rb;

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
			public _003CCoDelayDespawn_003Ed__2(int _003C_003E1__state)
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

		public Control_Player controlPlayer;

		public void OnTriggerEnter(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayDespawn_003Ed__2))]
		private IEnumerator CoDelayDespawn(Rigidbody rb)
		{
			return null;
		}

		public void DataWrite(string barcode)
		{
		}

		private void ACHIEVEMENTUNLOCKS()
		{
		}
	}
}
