using System;

namespace Grpc.Core.Internal
{
	internal interface INativeCall : IDisposable
	{
		void Cancel();

		void CancelWithStatus(Status status);

		void StartUnary(BatchContextSafeHandle ctx, byte[] payload, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, CallFlags callFlags);
	}
}
