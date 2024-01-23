using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct RemoteStorageFileReadAsyncComplete_t : ICallbackData
	{
		internal ulong FileReadAsync;

		internal Result Result;

		internal uint Offset;

		internal uint Read;

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
