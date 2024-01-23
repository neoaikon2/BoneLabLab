using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Proxy;

namespace SLZ.Mods
{
	public class SphereGripProxyMap : BoneProxyMap<SphereGripProxy, SphereGrip>
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetupHandPose_003Ed__2
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SphereGripProxyMap _003C_003E4__this;

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

		public override void AfterGenerateReal()
		{
		}

		[AsyncStateMachine(typeof(_003CSetupHandPose_003Ed__2))]
		public UniTaskVoid SetupHandPose()
		{
			return default(UniTaskVoid);
		}

		public override void MapMethods()
		{
		}
	}
}
