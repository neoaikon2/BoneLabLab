using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal sealed class NativeExtension
	{
		private static readonly ILogger Logger;

		private static readonly object staticLock;

		private static NativeExtension instance;

		private readonly NativeMethods nativeMethods;

		public NativeMethods NativeMethods
		{
			get
			{
				return null;
			}
		}

		private NativeExtension()
			: base()
		{
		}

		public static NativeExtension Get()
		{
			return null;
		}

		private static UnmanagedLibrary Load()
		{
			return null;
		}

		private static string GetAssemblyPath()
		{
			return null;
		}

		private static bool IsFileUri(string uri)
		{
			return default(bool);
		}

		private static string GetPlatformString()
		{
			return null;
		}

		private static string GetArchitectureString()
		{
			return null;
		}

		private static string GetNativeLibraryFilename()
		{
			return null;
		}
	}
}
