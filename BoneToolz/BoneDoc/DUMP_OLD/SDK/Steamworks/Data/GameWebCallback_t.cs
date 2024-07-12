using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 256)]
	internal struct GameWebCallback_t : ICallbackData
	{
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

		internal string URLUTF8()
		{
			return null;
		}
	}
}
