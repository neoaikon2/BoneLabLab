using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 280)]
	internal struct SteamUGCQueryCompleted_t : ICallbackData
	{
		internal ulong Handle;

		internal Result Result;

		internal uint NumResultsReturned;

		internal uint TotalMatchingResults;

		internal bool CachedData;

		internal byte[] NextCursor;

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
