using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "volume", "Set/Get Volume settings: volume master|music|sfx #")]
	internal class VolumeConsoleCommand : BaseConsoleCommand
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetVolume_003Ed__2
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetVolume_003Ed__3
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public List<(CommandStatus status, string token, object parsed)> args;

			public IAsyncWriter<object> writer;

			private float _003Cvolume_003E5__2;

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

		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<ValueTuple<(string token, object parsed)>> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetVolume_003Ed__2))]
		private UniTask GetVolume(IAsyncWriter<object> writer, CancellationToken _)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CSetVolume_003Ed__3))]
		private Task SetVolume(List<(CommandStatus status, string token, object parsed)> args, IAsyncWriter<object> writer, CancellationToken _)
		{
			return null;
		}
	}
}
