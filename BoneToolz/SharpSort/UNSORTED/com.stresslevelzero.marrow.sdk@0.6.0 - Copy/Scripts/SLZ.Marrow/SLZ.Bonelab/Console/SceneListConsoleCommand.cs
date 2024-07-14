using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;
using UnityEngine.SceneManagement;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("scene", "list", "List open scenes")]
	public class SceneListConsoleCommand : BaseConsoleCommand
	{
		public override IUniTaskAsyncEnumerable<object> RunCommand(string command)
		{
			return null;
		}
		private static UniTask Create(IAsyncWriter<object> writer, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
