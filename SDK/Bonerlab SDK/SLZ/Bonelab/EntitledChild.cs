using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class EntitledChild : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckAsync_003Ed__1
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public EntitledChild _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private void OnEnable()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckAsync_003Ed__1))]
		private UniTaskVoid CheckAsync()
		{
			return default(UniTaskVoid);
		}
	}
}
