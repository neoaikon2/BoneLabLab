using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 264)]
	internal struct GetVideoURLResult_t : ICallbackData
	{
		internal Result Result;

		internal AppId VideoAppID;

		internal byte[] URL;

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
