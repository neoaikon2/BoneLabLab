using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericSpawnDelayEvent : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAsyncDespawn_003Ed__3
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public int timeMs;

			public GenericSpawnDelayEvent _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public float secondsUntilEvent;

		public UnityEvent delayedEvent;

		protected override void OnSpawn(GameObject go)
		{
		}

		[AsyncStateMachine(typeof(_003CAsyncDespawn_003Ed__3))]
		private UniTaskVoid AsyncDespawn(int timeMs)
		{
			return default(UniTaskVoid);
		}
	}
}
