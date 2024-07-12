using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct HTML_FinishedRequest_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchURL;

		internal string PchPageTitle;

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
