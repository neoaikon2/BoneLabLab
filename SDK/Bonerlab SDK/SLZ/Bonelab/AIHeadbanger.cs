using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AIHeadbanger : MonoBehaviour, ISpawnListenable
	{
		/*
		[CompilerGenerated]
		private sealed class _003CDanceCo_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CDanceCo_003Ed__14(int _003C_003E1__state)
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

		public CrateSpawner[] crateSpawners;

		public HashSet<AIBrain> brainsHash;

		public List<AIBrain> livingBrainList;

		public float danceTick;

		private Coroutine _danCo;

		private bool _danceBeat;

		private bool _danceLeft;

		private void Start()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		private void OnDeath(AIBrain brain)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		[ContextMenu("ToggleDanceOn")]
		public void ToggleOn()
		{
		}

		[ContextMenu("ToggleDanceOff")]
		public void ToggleOff()
		{
		}

		public void ToggleDance(bool on)
		{
		}

		//[IteratorStateMachine(typeof(_003CDanceCo_003Ed__14))]
		public IEnumerator DanceCo()
		{
			return null;
		}
	}
}
