using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 128)]
	internal struct GameServerChangeRequested_t : ICallbackData
	{
		internal byte[] Server;

		internal byte[] Password;

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

		internal string ServerUTF8()
		{
			return null;
		}

		internal string PasswordUTF8()
		{
			return null;
		}
	}
}
