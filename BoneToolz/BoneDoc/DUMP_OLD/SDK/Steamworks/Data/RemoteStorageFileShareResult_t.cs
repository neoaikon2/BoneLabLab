using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 280)]
	internal struct RemoteStorageFileShareResult_t : ICallbackData
	{
		internal Result Result;

		internal ulong File;

		internal byte[] Filename;

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
