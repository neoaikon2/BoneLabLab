using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct HTTPRequestDataReceived_t : ICallbackData
	{
		internal uint Request;

		internal ulong ContextValue;

		internal uint COffset;

		internal uint CBytesReceived;

		public static int _datasize;

		public int DataSize
		{
			get
			{
				return default(int);
			}
		}

		public CallbackType CallbackType
		{
			get
			{
				return default(CallbackType);
			}
		}
	}
}
