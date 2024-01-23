using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 288)]
	internal struct RemoteStorageAppSyncProgress_t : ICallbackData
	{
		internal byte[] CurrentFile;

		internal AppId AppID;

		internal uint BytesTransferredThisChunk;

		internal double DAppPercentComplete;

		internal bool Uploading;

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
