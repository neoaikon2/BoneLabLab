using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "whereami", "Display current coordinates")]
	public class WhereAmIConsoleCommand : BaseConsoleCommand
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		private struct WriteToLog : IAsyncWriter<object>
		{
			public UniTask YieldAsync(object value)
			{
				return default(UniTask);
			}
		}

		protected override ValueTuple<CommandStatus, string, object> ParseTokenAtIndex([TupleElementNames(new string[] { "token", "parsed" })] List<ValueTuple<string, object>> previousTokens, int index, string token)
		{
			return default(ValueTuple<CommandStatus, string, object>);
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		private static UniTask WhereAmI(IAsyncWriter<object> writer)
		{
			return default(UniTask);
		}

		private static void WhereAmI()
		{
		}

		public WhereAmIConsoleCommand()
			: base()
		{
		}
	}
}
