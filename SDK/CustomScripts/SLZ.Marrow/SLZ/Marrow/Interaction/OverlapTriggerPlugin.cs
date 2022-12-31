using System.Runtime.CompilerServices;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Interaction
{
	[MarrowPlugin("SLZ.Marrow.Plugins", "Overlap Trigger", "0.0.1")]
	public class OverlapTriggerPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		public OverlapTriggerManager Manager { get; private set; }

		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		public void OnMarrowPluginLoad()
		{
		}

		void IMarrowPluginLevelCallbacks.OnBeforeLevelLoad(LevelCrateReference level)
		{
		}

		void IMarrowPluginLevelCallbacks.OnBeforeLevelUnload()
		{
		}

		void IMarrowPluginLevelCallbacks.OnAfterLevelLoad(LevelCrateReference level)
		{
		}

		void IMarrowPluginLevelCallbacks.OnAfterLevelUnload()
		{
		}

		public OverlapTriggerPlugin()
			: base()
		{
		}
	}
}
