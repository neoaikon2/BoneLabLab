using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 296)]
	internal struct RemoteStorageDownloadUGCResult_t : ICallbackData
	{
		internal Result Result;

		internal ulong File;

		internal AppId AppID;

		internal int SizeInBytes;

		internal byte[] PchFileName;

		internal ulong SteamIDOwner;

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
