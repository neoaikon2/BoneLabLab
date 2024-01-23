using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Proxy;

namespace SLZ.Mods
{
	public class BoxGripProxyMap : BoneProxyMap<BoxGripProxy, BoxGrip>
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetupHandPoses_003Ed__3
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BoxGripProxyMap _003C_003E4__this;

			private BoxGrip _003C_003E7__wrap1;

			private UniTask<SLZ.Marrow.Data.HandPose>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		protected override void MapProperties()
		{
		}

		public override void BeforeGenerateReal()
		{
		}

		public override void AfterGenerateReal()
		{
		}

		[AsyncStateMachine(typeof(_003CSetupHandPoses_003Ed__3))]
		public UniTaskVoid SetupHandPoses()
		{
			return default(UniTaskVoid);
		}

		public override void MapMethods()
		{
		}
	}
}
