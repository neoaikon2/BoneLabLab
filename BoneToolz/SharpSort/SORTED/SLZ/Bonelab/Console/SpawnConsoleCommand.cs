using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("__builtin", "spawn", "Spawn a spawnable")]
	public class SpawnConsoleCommand : BaseConsoleCommand
	{
		protected override (CommandStatus, string, object) ParseTokenAtIndex(List<(string token, object parsed)> previousTokens, int index, string token)
		{
			return default((CommandStatus, string, object));
		}

		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}
	}
}
