using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RandomAvatar : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__3
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public RandomAvatar _003C_003E4__this;

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

		public RigManager rm;

		[Header("Avatars")]
		public AvatarCrate[] avatarCrates;

		public void RANDOMAVATAR()
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__3))]
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}
	}
}
