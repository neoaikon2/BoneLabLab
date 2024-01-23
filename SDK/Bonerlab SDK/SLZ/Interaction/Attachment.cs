using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ.Interaction
{
	public class Attachment : Connector
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAnimateAttach_003Ed__4
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private IGrippable host;

		private bool _isAttached;

		private new void Awake()
		{
		}

		protected override void OnConnectorHover()
		{
		}

		[AsyncStateMachine(typeof(_003CAnimateAttach_003Ed__4))]
		private UniTaskVoid AnimateAttach()
		{
			return default(UniTaskVoid);
		}
	}
}
