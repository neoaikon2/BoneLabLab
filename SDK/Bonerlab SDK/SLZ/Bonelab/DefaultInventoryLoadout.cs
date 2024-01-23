using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DefaultInventoryLoadout : MonoBehaviour
	{
		[Serializable]
		public struct SlotSpawnPair
		{
			public string slotName;

			public Spawnable spawnable;

			public SlotSpawnPair(string _slotName, Spawnable _spawnable)
			{
				slotName = _slotName;
				spawnable = _spawnable;
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnInSlotsAsync_003Ed__6
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public DefaultInventoryLoadout _003C_003E4__this;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public Inventory inventory;

		public SlotSpawnPair[] spawnInSlotData;

		private void Awake()
		{
		}

		public void Reset()
		{
		}

		private void OnGameReady()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnInSlotsAsync_003Ed__6))]
		private UniTaskVoid SpawnInSlotsAsync()
		{
			return default(UniTaskVoid);
		}
	}
}
