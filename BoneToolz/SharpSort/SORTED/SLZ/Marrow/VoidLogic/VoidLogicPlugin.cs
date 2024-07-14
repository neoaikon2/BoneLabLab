using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[MarrowPlugin("SLZ.Marrow.VoidLogic", "VoidLogicPlugin", "0.0.1")]
	public class VoidLogicPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		[PublicAPI]
		public const string PluginNamespace = "SLZ.Marrow.VoidLogic";

		[PublicAPI]
		public const string PluginName = "VoidLogicPlugin";

		[PublicAPI]
		public const string PluginVersion = "0.0.1";

		private GameObject _holder;

		public static VoidLogicManager CurrentManager
		{
			[MethodImpl(256)]
			get;
			private set; }

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginLevelCallbacks_002EOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		public UniTask OnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
	}
}
