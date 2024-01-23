using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 152)]
	internal struct GetAppDependenciesResult_t : ICallbackData
	{
		internal Result Result;

		internal PublishedFileId PublishedFileId;

		internal AppId[] GAppIDs;

		internal uint NumAppDependencies;

		internal uint TotalNumAppDependencies;

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
