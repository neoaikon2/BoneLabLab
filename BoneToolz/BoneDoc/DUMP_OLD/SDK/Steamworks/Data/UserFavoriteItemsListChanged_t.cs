using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	internal struct UserFavoriteItemsListChanged_t : ICallbackData
	{
		internal PublishedFileId PublishedFileId;

		internal Result Result;

		internal bool WasAddRequest;

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
