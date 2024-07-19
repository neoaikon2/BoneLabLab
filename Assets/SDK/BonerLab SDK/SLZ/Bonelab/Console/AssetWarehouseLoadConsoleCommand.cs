using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("assetwarehouse", "load", "Load Pallet")]
	[ConsoleCommand("aw", "load", "Load Pallet")]
	public class AssetWarehouseLoadConsoleCommand : SimpleConsoleCommand
	{
		public override UniTask RunSimpleCommand(IAsyncWriter<object> writer, string parameter)
		{
			return default(UniTask);
		}
	}
}
