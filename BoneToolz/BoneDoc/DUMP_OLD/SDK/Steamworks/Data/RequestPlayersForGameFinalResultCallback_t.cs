using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct RequestPlayersForGameFinalResultCallback_t : ICallbackData
	{
		internal Result Result;

		internal ulong LSearchID;

		internal ulong LUniqueGameID;

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
