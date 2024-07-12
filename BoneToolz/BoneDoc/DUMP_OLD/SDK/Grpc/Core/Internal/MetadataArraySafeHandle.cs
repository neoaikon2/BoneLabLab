using System;

namespace Grpc.Core.Internal
{
	internal class MetadataArraySafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private MetadataArraySafeHandle()
			: base()
		{
		}

		public static MetadataArraySafeHandle Create(Metadata metadata)
		{
			return null;
		}

		public static Metadata ReadMetadataFromPtrUnsafe(IntPtr metadataArray)
		{
			return null;
		}

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}
	}
}
