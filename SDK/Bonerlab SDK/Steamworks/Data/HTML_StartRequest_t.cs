using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 40)]
	internal struct HTML_StartRequest_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal string PchURL;

		internal string PchTarget;

		internal string PchPostData;

		internal bool BIsRedirect;

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
