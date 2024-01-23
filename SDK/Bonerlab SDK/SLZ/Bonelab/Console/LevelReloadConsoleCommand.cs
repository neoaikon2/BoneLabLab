using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("level", "reload", "Reload Current Level")]
	public class LevelReloadConsoleCommand : BaseConsoleCommand
	{
		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<ValueTuple<(string, object)>> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}
	}
}
