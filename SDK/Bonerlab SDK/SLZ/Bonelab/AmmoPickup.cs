using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class AmmoPickup : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelayDespawnAsync_003Ed__12
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AmmoPickup _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public AmmoGroup ammoGroup;

		public int ammoCount;

		public AudioClip collectAudioClip;

		public UnityEvent OnAmmoCollect;

		public Spawnable animeCollectVFXSpawnable;

		public Spawnable bulletBlastVFXSpawnable;

		public Spawnable smokerVFXSpawnable;

		private bool _isCollected;

		private Vector3 scale;

		protected void Awake()
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		[AsyncStateMachine(typeof(_003CDelayDespawnAsync_003Ed__12))]
		private UniTaskVoid DelayDespawnAsync()
		{
			return default(UniTaskVoid);
		}

		public void ForcePickup()
		{
		}
	}
}
