using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using SLZ.Utilities;
using UnityEngine;

namespace SLZ.Combat
{
	public class FirearmCartridge : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CColliderEnableDelay_003Ed__17
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public FirearmCartridge _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDisableDelay_003Ed__18
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public FirearmCartridge _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<FirearmCartridge> _cache;

		private RigidbodyData _rbData;

		private bool _isStatic;

		public Rigidbody rb;

		public Collider col;

		public ShellSFX shellSfx;

		public float despawnDelaySeconds;

		public float startSpeed;

		public float startAxisSpeed;

		public static ComponentCache<FirearmCartridge> Cache => null;

		private void Reset()
		{
		}

		protected void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		public void ForceInDirection(Vector3 startDirection, Vector3 startRotationAxis, Rigidbody hostRigidbody)
		{
		}

		[AsyncStateMachine(typeof(_003CColliderEnableDelay_003Ed__17))]
		private UniTaskVoid ColliderEnableDelay()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CDisableDelay_003Ed__18))]
		private UniTaskVoid DisableDelay()
		{
			return default(UniTaskVoid);
		}

		public void MakeStatic()
		{
		}

		public void MakeDynamic()
		{
		}
	}
}
