using System.Collections.Generic;
using JetBrains.Annotations;

namespace SLZ.Marrow.Forklift.Model
{
	public static class ModTargetResolver
	{
		private static List<string> _targetPreferenceOrder;

		[PublicAPI]
		public static void SetModTargetPreferenceOrder(params string[] targetNames)
		{
		}

		[PublicAPI]
		public static bool TrySelectModTarget<TModTarget>(ModListing mod, out string targetName, out TModTarget modTarget) where TModTarget : ModTarget
		{
			targetName = null;
			modTarget = null;
			return false;
		}
	}
}
