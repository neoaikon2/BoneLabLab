using System;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct IVRIOBuffer
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Open(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Close(ulong ulBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EIOBufferError _Write(ulong ulBuffer, IntPtr pSrc, uint unBytes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _PropertyContainer(ulong ulBuffer);

		internal _Open Open;

		internal _Close Close;

		internal _Read Read;

		internal _Write Write;

		internal _PropertyContainer PropertyContainer;
	}
}
