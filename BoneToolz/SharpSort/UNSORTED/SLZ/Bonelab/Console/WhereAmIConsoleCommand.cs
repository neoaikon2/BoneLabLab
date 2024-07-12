using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "whereami", "Display current coordinates")]
	public class WhereAmIConsoleCommand : BaseConsoleCommand
	{
		[StructLayout(0, Size = 1)]
		private struct WriteToLog : IAsyncWriter<object>
		{
			public UniTask YieldAsync(object value)
			{
				return default(UniTask);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWhereAmI_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public IAsyncWriter<object> writer;

			private SwitchToMainThreadAwaitable.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<(string token, object parsed)> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWhereAmI_003Ed__2))]
		private static UniTask WhereAmI(IAsyncWriter<object> writer)
		{
			return default(UniTask);
		}

		private static void WhereAmI()
		{
		}
	}
}
