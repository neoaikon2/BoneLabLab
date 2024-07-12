using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct HTML_VerticalScroll_t : ICallbackData
	{
		internal uint UnBrowserHandle;

		internal uint UnScrollMax;

		internal uint UnScrollCurrent;

		internal float FlPageScale;

		internal bool BVisible;

		internal uint UnPageSize;

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
