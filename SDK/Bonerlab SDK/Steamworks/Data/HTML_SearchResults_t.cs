using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 12)]
	internal struct HTML_SearchResults_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal uint UnResults;

		internal uint UnCurrentMatch;

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
