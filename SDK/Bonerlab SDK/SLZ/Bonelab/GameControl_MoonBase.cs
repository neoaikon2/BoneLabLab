using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_MoonBase : BonelabInternalGameControl
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__8
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_MoonBase _003C_003E4__this;

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

		public AvatarCrateReference avatarOverride;

		private Vector3 _cachedGrav;

		private readonly Vector3 _moonGrav;

		public GameObject[] LoadButtons;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		[FormerlySerializedAs("avatarGatcha")]
		private GameObject avatarGacha;

		public override void Start()
		{
		}

		public void SwitchAvatar()
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__8))]
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		private void OnDestroy()
		{
		}

		public override void DoLevelComplete()
		{
		}

		private void ButtonsSetup()
		{
		}
	}
}
