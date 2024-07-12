using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	internal struct SteamAPICallCompleted_t : ICallbackData
	{
		internal ulong AsyncCall;

		internal int Callback;

		internal uint ParamCount;

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
