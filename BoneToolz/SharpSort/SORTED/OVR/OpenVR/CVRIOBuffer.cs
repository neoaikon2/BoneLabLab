using System;

namespace OVR.OpenVR
{
	public class CVRIOBuffer
	{
		private IVRIOBuffer FnTable;

		internal CVRIOBuffer(IntPtr pInterface)
		{
		}

		public EIOBufferError Open(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer)
		{
			return default(EIOBufferError);
		}

		public EIOBufferError Close(ulong ulBuffer)
		{
			return default(EIOBufferError);
		}

		public EIOBufferError Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead)
		{
			return default(EIOBufferError);
		}

		public EIOBufferError Write(ulong ulBuffer, IntPtr pSrc, uint unBytes)
		{
			return default(EIOBufferError);
		}

		public ulong PropertyContainer(ulong ulBuffer)
		{
			return 0uL;
		}
	}
}
