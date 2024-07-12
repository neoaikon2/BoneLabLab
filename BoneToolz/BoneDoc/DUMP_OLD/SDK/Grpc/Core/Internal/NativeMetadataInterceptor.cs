using System;

namespace Grpc.Core.Internal
{
	internal delegate void NativeMetadataInterceptor(IntPtr statePtr, IntPtr serviceUrlPtr, IntPtr methodNamePtr, IntPtr callbackPtr, IntPtr userDataPtr, bool isDestroy);
}
