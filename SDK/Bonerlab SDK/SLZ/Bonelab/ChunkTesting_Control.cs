using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.SceneStreaming;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ChunkTesting_Control : MonoBehaviour
	{
		public enum Chunks
		{
			CHUNK1 = 0,
			CHUNK2 = 1,
			CHUNK3 = 2,
			CHUNK4 = 3,
			CHUNK5 = 4
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public bool isDoneLoading;

			internal void _003CCoAirlock_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoAirlock_003Ed__28
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChunkTesting_Control _003C_003E4__this;

			private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

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
			public _003CCoAirlock_003Ed__28(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoOpenDoor_003Ed__29
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform transform;

			private float _003Cperc_003E5__2;

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
			public _003CCoOpenDoor_003Ed__29(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoCloseDoor_003Ed__30
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform transform;

			private float _003Cperc_003E5__2;

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
			public _003CCoCloseDoor_003Ed__30(int _003C_003E1__state)
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

		public RigManager rm;

		public Transform chunk1Location;

		public Transform chunk2Location;

		public Transform chunk3Location;

		public Transform chunk4Location;

		public Transform chunk5Location;

		public Chunks startChunk;

		public Chunk airLockForwardChunk;

		public Chunk airLockBackwardChunk;

		public Transform forwardDoor;

		public Transform backwardDoor;

		private Coroutine forwardDoorCoroutine;

		private Coroutine backwardDoorCoroutine;

		private Coroutine airlockCoroutine;

		private bool _isForwardChunkLoaded;

		private bool _isBackwardChunkLoaded;

		private bool _isAirlockChunkLoaded;

		private void Awake()
		{
		}

		private void Teleport()
		{
		}

		public void OnForwardChunkLoaded()
		{
		}

		public void OnBackwardChunkLoaded()
		{
		}

		public void OnAirlockChunkLoaded()
		{
		}

		public void OnForwardChunkUnloaded()
		{
		}

		public void OnBackwardChunkUnloaded()
		{
		}

		public void OnAirlockChunkUnloaded()
		{
		}

		private void OpenAirlockDoors()
		{
		}

		public void AirlockButton()
		{
		}

		[IteratorStateMachine(typeof(_003CCoAirlock_003Ed__28))]
		private IEnumerator CoAirlock()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoOpenDoor_003Ed__29))]
		private IEnumerator CoOpenDoor(Transform transform)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCloseDoor_003Ed__30))]
		private IEnumerator CoCloseDoor(Transform transform)
		{
			return null;
		}
	}
}
