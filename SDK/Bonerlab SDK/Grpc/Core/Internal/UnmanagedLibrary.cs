using System;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class UnmanagedLibrary
	{
		private static class Windows
		{
			internal static extern IntPtr LoadLibrary(string filename);

			internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
		}

		private static class Linux
		{
			internal static extern IntPtr dlopen(string filename, int flags);

			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static class MacOSX
		{
			internal static extern IntPtr dlopen(string filename, int flags);

			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static class Mono
		{
			internal static extern IntPtr dlopen(string filename, int flags);

			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static class CoreCLR
		{
			internal static extern IntPtr dlopen(string filename, int flags);

			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static readonly ILogger Logger;

		private readonly string libraryPath;

		private readonly IntPtr handle;

		public UnmanagedLibrary(string[] libraryPathAlternatives)
			: base()
		{
		}

		public IntPtr LoadSymbol(string symbolName)
		{
			return default(IntPtr);
		}

		public T GetNativeMethodDelegate<T>(string methodName) where T : class
		{
			return null;
		}

		private static IntPtr PlatformSpecificLoadLibrary(string libraryPath)
		{
			return default(IntPtr);
		}

		private static string FirstValidLibraryPath(string[] libraryPathAlternatives)
		{
			return null;
		}
	}
}
