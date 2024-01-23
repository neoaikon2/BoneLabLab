using System;

namespace Grpc.Core.Internal
{
	internal static class PlatformApis
	{
		private static readonly bool isLinux;

		private static readonly bool isMacOSX;

		private static readonly bool isWindows;

		private static readonly bool isMono;

		private static readonly bool isNetCore;

		public static bool IsLinux
		{
			get
			{
				return default(bool);
			}
		}

		public static bool IsMacOSX
		{
			get
			{
				return default(bool);
			}
		}

		public static bool IsWindows
		{
			get
			{
				return default(bool);
			}
		}

		public static bool IsMono
		{
			get
			{
				return default(bool);
			}
		}

		public static bool IsNetCore
		{
			get
			{
				return default(bool);
			}
		}

		public static bool Is64Bit
		{
			get
			{
				return default(bool);
			}
		}

		static PlatformApis()
		{
		}

		private static extern int uname(IntPtr buf);

		private static string GetUname()
		{
			return null;
		}
	}
}
