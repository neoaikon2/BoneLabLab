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
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "spawn", "Spawn a spawnable")]
	public class SpawnConsoleCommand : BaseConsoleCommand
	{
		protected override ValueTuple<CommandStatus, string, object> ParseTokenAtIndex(List<ValueTuple<string, object>> previousTokens, int index, string token)
		{
			return default(ValueTuple<CommandStatus, string, object>);
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		public SpawnConsoleCommand()
			: base()
		{
		}
	}
}
