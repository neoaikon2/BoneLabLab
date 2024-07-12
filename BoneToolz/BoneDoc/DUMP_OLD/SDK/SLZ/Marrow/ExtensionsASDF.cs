using System.Runtime.InteropServices;
using SLZ.Marrow.SaveData;

namespace SLZ.Marrow
{
	public static class ExtensionsASDF
	{
		public const string PROGRESS = "SLZ.Marrow.progress";

		public const string COMPLETED = "SLZ.Marrow.completed";

		public static bool TrySetLevelCompleted(this IProgression progression, string levelKey, bool completed)
		{
			return default(bool);
		}

		public static bool TryGetLevelCompleted(this IProgression progression, string levelKey, [Out] bool completed)
		{
			return default(bool);
		}

		public static bool TrySetLevelProgress(this IProgression progression, string levelKey, int progress)
		{
			return default(bool);
		}

		public static bool TryGetLevelProgress(this IProgression progression, string levelKey, [Out] int progress)
		{
			return default(bool);
		}
	}
}
