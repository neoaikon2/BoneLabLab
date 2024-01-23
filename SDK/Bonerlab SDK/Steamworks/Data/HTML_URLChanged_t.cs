using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 48)]
	internal struct HTML_URLChanged_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchURL;

		internal string PchPostData;

		internal bool BIsRedirect;

		internal string PchPageTitle;

		internal bool BNewNavigation;

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
