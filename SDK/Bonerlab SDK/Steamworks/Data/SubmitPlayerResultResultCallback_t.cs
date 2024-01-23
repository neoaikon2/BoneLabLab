using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	internal struct SubmitPlayerResultResultCallback_t : ICallbackData
	{
		internal Result Result;

		internal ulong UllUniqueGameID;

		internal ulong SteamIDPlayer;

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
