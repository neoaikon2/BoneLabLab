using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	public static class SLZQuestNative
	{
		private static int CheckIfInitialized()
		{
			return default(int);
		}

		private static void GetDeviceName(IntPtr str, int len)
		{
		}

		public static int IsVkPSOCacheValid()
		{
			return default(int);
		}

		public static string AndroidDeviceName()
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Test()
		{
		}
	}
}
