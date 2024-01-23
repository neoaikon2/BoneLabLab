using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneSpawnSequencer : ZoneItem
	{
		[CompilerGenerated]
		private sealed class _003CCoPlaySequencer_003Ed__12
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ZoneSpawnSequencer _003C_003E4__this;

			private WaitForSeconds _003Cwait_003E5__2;

			private WaitForSeconds _003CwaitShort_003E5__3;

			private int _003Ci_003E5__4;

			private int _003Cidx_003E5__5;

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
			public _003CCoPlaySequencer_003Ed__12(int _003C_003E1__state)
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

		[Tooltip("Frequency between nodes of sequencer in seconds")]
		public float frequency;

		public bool randomSequence;

		[Tooltip("Max amount that can be spawned")]
		public float maxConcurrentSpawns;

		public ZoneSpawner[] spawners;

		private List<int> _sequenceIndexBuffer;

		private int[] _randomSequenceIndices;

		private Coroutine _sequenceCoroutine;

		private int _currentSequenceItem;

		private bool _hasStarted;

		private void Awake()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		[IteratorStateMachine(typeof(_003CCoPlaySequencer_003Ed__12))]
		private IEnumerator CoPlaySequencer(GameObject playerObject)
		{
			return null;
		}
	}
}
