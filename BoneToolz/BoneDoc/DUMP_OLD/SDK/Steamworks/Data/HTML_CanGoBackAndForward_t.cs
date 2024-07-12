using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 8)]
	internal struct HTML_CanGoBackAndForward_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal bool BCanGoBack;

		internal bool BCanGoForward;

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
