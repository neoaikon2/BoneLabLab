using System;

namespace Steamworks
{
	public static class Utility
	{
		private static readonly byte[] readBuffer;

		internal static T ToType<T>(this IntPtr ptr)
		{
			return (T)default(T);
		}

		internal static object ToType(this IntPtr ptr, Type t)
		{
			return null;
		}
	}
}
