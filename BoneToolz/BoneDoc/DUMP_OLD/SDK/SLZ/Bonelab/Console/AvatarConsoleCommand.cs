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
using SLZ.Rig;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "avatar", "Switch into avatar")]
	public class AvatarConsoleCommand : BaseConsoleCommand
	{
		protected override ValueTuple<CommandStatus, string, object> ParseTokenAtIndex([TupleElementNames(new string[] { "token", "parsed" })] List<ValueTuple<string, object>> previousTokens, int index, string token)
		{
			return default(ValueTuple<CommandStatus, string, object>);
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}

		public AvatarConsoleCommand()
			: base()
		{
		}
	}
}
