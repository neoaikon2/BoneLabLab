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
		private struct WriteToLog : IAsyncWriter<object>
		{
			public UniTask YieldAsync(object value)
			{
				return default(UniTask);
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
		private static UniTask WhereAmI(IAsyncWriter<object> writer)
		{
			return default(UniTask);
		}

		private static void WhereAmI()
		{
		}
	}
}
