using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 32)]
	internal struct HTML_LinkAtPosition_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal uint X;

		internal uint Y;

		internal string PchURL;

		internal bool BInput;

		internal bool BLiveLink;

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
