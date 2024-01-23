using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TMPro
{
	internal static class TMP_ListPool<T>
	{
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> toRelease)
		{
		}
	}
}
