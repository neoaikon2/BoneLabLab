using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

namespace SLZ.AI
{
	public class AIHeadbanger : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDanceCo_003Ed__6
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AIHeadbanger _003C_003E4__this;

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
			public _003CDanceCo_003Ed__6(int _003C_003E1__state)
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

		public ZoneSpawner[] danceSpawners;

		public float danceTick;

		private Coroutine _danCo;

		private bool _danceBeat;

		private bool _danceLeft;

		public void ToggleDance(bool on)
		{
		}

		[IteratorStateMachine(typeof(_003CDanceCo_003Ed__6))]
		public IEnumerator DanceCo()
		{
			return null;
		}
	}
}
