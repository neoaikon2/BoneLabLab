using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Scripting;

namespace SLZ.Marrow.Plugins
{
	[Preserve]
	public sealed class MarrowPlugins
	{
		private const bool DISABLE_LIFECYCLE_LOGGING = false;

		private const bool DISABLE_GRAPH_LOGGING = true;

		private const bool DISABLE_ASSEMBLY_LOGGING = true;

		private static MarrowPlugins _instance;

		public static MarrowPlugins Instance => null;

		public bool IsRunning { get; set; }

		private OrderedDictionary OrderedPluginWrappersByQN { get; }

		private Dictionary<Type, MarrowPluginWrapper> PluginWrappersByType { get; }

		private Dictionary<string, HashSet<string>> DependenciesByQN { get; }

		private List<List<string>> CachedGroups { get; set; }

		[RuntimeInitializeOnLoadMethod]
		private static void EnsurePluginSystem()
		{
		}

		private MarrowPlugins()
		{
		}

		~MarrowPlugins()
		{
		}

		private void Application_quitting()
		{
		}

		private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
		{
		}

		private void OnAfterAssembliesLoaded()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		internal UniTask TriggerOnMarrowPluginLoad()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginStart()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginStop()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorPaused()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorUnpaused()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorEnteredEditMode()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorExitingEditMode()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorEnteredPlayMode()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorExitingPlayMode()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorBeforeAssemblyReload()
		{
			return default(UniTask);
		}

		internal UniTask TriggerOnMarrowPluginEditorAfterAssemblyReload()
		{
			return default(UniTask);
		}
		internal UniTask TriggerOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
		internal UniTask TriggerOnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
		internal UniTask TriggerOnBeforeLevelUnload()
		{
			return default(UniTask);
		}
		internal UniTask TriggerOnAfterLevelUnload()
		{
			return default(UniTask);
		}
		private UniTask _TriggerAsync<TPlugin>(bool forward, object context, Func<MarrowPluginWrapper, TPlugin, object, UniTask> callback) where TPlugin : IMarrowPlugin
		{
			return default(UniTask);
		}

		private static void _ThrowIfCycles(List<List<string>> groups)
		{
		}

		public bool TryGetPlugin<TPlugin>(out TPlugin plugin) where TPlugin : IMarrowPlugin
		{
			plugin = default(TPlugin);
			return false;
		}

		private bool TryGetPluginWrapper<TPlugin>(out MarrowPluginWrapper marrowPluginWrapper) where TPlugin : IMarrowPlugin
		{
			marrowPluginWrapper = null;
			return false;
		}

		private bool TryGetPluginWrapper(string qualifiedName, out MarrowPluginWrapper marrowPluginWrapper)
		{
			marrowPluginWrapper = null;
			return false;
		}

		internal void ScanForPluginsInAssembly(Assembly loadedAssembly, bool includingTests = false)
		{
		}

		private void AddPlugin(Type type)
		{
		}

		internal void AddPlugins(List<(Type, MarrowPluginAttribute)> plugins)
		{
		}
	}
}
