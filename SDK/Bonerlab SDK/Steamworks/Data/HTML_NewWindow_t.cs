using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 40)]
	internal struct HTML_NewWindow_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchURL;

		internal uint UnX;

		internal uint UnY;

		internal uint UnWide;

		internal uint UnTall;

		internal uint UnNewWindow_BrowserHandle_IGNORE;

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
