using System;

namespace Steamworks
{
	internal static class Helpers
	{
		private static IntPtr[] MemoryPool;

		private static int MemoryPoolIndex;

		private static byte[][] BufferPool;

		private static int BufferPoolIndex;

		public static IntPtr TakeMemory()
		{
			return default(IntPtr);
		}

		public static byte[] TakeBuffer(int minSize)
		{
			return null;
		}

		internal static string MemoryToString(IntPtr ptr)
		{
			return null;
		}
	}
}
