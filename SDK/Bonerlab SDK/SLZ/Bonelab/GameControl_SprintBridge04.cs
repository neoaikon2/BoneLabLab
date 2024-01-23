using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_SprintBridge04 : BonelabInternalGameControl
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__13
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_SprintBridge04 _003C_003E4__this;

			public AvatarCrate avatarCrate;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CKillPlayerAndReset_003Ed__15
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_SprintBridge04 _003C_003E4__this;

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
			public _003CKillPlayerAndReset_003Ed__15(int _003C_003E1__state)
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

		public RigManager rM;

		public Player_Health playerHealth;

		public AvatarCrateReference avatarOverride;

		public UnityEvent OnDeathEvent;

		public GameObject[] LoadButtons;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		[FormerlySerializedAs("avatarGatcha")]
		private GameObject avatarGacha;

		private IEnumerator KillPlayerCoroutine;

		private new void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void PlayerDeath()
		{
		}

		public void SwitchAvatar()
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__13))]
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		public void KillPlayerFast()
		{
		}

		[IteratorStateMachine(typeof(_003CKillPlayerAndReset_003Ed__15))]
		private IEnumerator KillPlayerAndReset()
		{
			return null;
		}

		public override void DoLevelComplete()
		{
		}

		private void ButtonsSetup()
		{
		}
	}
}
