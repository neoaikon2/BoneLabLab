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
	public class GameControl_MagmaGate : BonelabInternalGameControl
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__10
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_MagmaGate _003C_003E4__this;

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

		public GameObject[] LoadButtons;

		public GameObject[] LoadButtonsForComplete;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		[FormerlySerializedAs("avatarGatcha")]
		private GameObject avatarGacha;

		public GameObject doorArt;

		public GameObject[] laserBeams;

		public GameObject[] fizzleEffects;

		private new void Start()
		{
		}

		public void SwitchAvatar()
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__10))]
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		public override void DoLevelComplete()
		{
		}

		private void ButtonsSetup()
		{
		}

		public void ObjectiveCompleteSetup()
		{
		}

		public void LoseSequence()
		{
		}

		private void DoorDissolve()
		{
		}
	}
}
