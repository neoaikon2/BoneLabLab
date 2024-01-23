using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Proxy;
using SLZ.Rig;

namespace SLZ.Mods
{
	public class PlayerSpawnerMap : BoneProxyMap<PlayerSpawner, RigManager>
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnPlayer_003Ed__5
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PlayerSpawnerMap _003C_003E4__this;

			private UniTask<UnityEngine.GameObject>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CFindRigManager_003Ed__6
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerSpawnerMap _003C_003E4__this;

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
			public _003CFindRigManager_003Ed__6(int _003C_003E1__state)
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

		public RigManager rigManager;

		public bool generating;

		public override void MapMethods()
		{
		}

		protected override void MapProperties()
		{
		}

		public override void GenerateReal()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnPlayer_003Ed__5))]
		public UniTaskVoid SpawnPlayer()
		{
			return default(UniTaskVoid);
		}

		[IteratorStateMachine(typeof(_003CFindRigManager_003Ed__6))]
		public IEnumerator FindRigManager()
		{
			return null;
		}
	}
}
