using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("aw", "unload", "Unload Pallet")]
	[ConsoleCommand("assetwarehouse", "unload", "Unload Pallet")]
	public class AssetWarehouseUnloadConsoleCommand : SimpleConsoleCommand
	{
		public override UniTask RunSimpleCommand(IAsyncWriter<object> writer, string parameter)
		{
			return default(UniTask);
		}
	}
}
