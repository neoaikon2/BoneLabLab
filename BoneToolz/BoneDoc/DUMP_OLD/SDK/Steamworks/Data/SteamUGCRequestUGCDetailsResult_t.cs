using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 9784)]
	internal struct SteamUGCRequestUGCDetailsResult_t : ICallbackData
	{
		internal SteamUGCDetails_t Details;

		internal bool CachedData;

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
