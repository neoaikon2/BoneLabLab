using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	internal struct GSClientGroupStatus_t : ICallbackData
	{
		internal ulong SteamIDUser;

		internal ulong SteamIDGroup;

		internal bool Member;

		internal bool Officer;

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
