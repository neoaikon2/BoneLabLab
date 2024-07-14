using System;
using System.Collections.Generic;
using System.Reflection;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;

namespace SLZ.Marrow.Console
{
	[MarrowPlugin("SLZ.Marrow.Plugins", "CommandConsole", "0.0.1")]
	public class ConsoleCommandPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
	{
		internal Dictionary<Type, ConsoleCommandWrapper> Commands;

		private HashSet<IObjectDescriber> Describers;

		private HashSet<Type> KnownDescribers;

		private Dictionary<Type, IObjectDescriber> DescriberCache;

		public TokenParseContext TokenParseContext { get; internal set; }

		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		public UniTask OnMarrowPluginLoad()
		{
			return default(UniTask);
		}

		public UniTask OnMarrowPluginStart()
		{
			return default(UniTask);
		}

		public UniTask OnMarrowPluginStop()
		{
			return default(UniTask);
		}

		private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
		}

		private void ScanForCommandsInAssembly(Assembly loadedAssembly)
		{
		}

		public void Describe(object obj, TokenParseContext tpc, Action<ObjectDescription> action)
		{
		}
	}
}
