using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.Forklift.Model
{
	public static class ModTargetResolver
	{
		private static List<string> _targetPreferenceOrder;

		[PublicAPI]
		public static void SetModTargetPreferenceOrder(params string[] targetNames)
		{
			targetNames = default(string[]);
		}

		[PublicAPI]
		public static bool TrySelectModTarget<TModTarget>(ModListing mod, [Out] string targetName, [Out] TModTarget modTarget) where TModTarget : ModTarget
		{
			return default(bool);
		}
	}
}
