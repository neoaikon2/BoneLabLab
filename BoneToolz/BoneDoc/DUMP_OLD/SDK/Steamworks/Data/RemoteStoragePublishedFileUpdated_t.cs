using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct RemoteStoragePublishedFileUpdated_t : ICallbackData
	{
		internal PublishedFileId PublishedFileId;

		internal AppId AppID;

		internal ulong Unused;

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
