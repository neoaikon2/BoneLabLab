using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 12)]
	internal struct RemoteStorageAppSyncedClient_t : ICallbackData
	{
		internal AppId AppID;

		internal Result Result;

		internal int NumDownloads;

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
