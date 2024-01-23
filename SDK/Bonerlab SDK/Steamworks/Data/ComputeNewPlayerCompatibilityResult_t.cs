using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 24)]
	internal struct ComputeNewPlayerCompatibilityResult_t : ICallbackData
	{
		internal Result Result;

		internal int CPlayersThatDontLikeCandidate;

		internal int CPlayersThatCandidateDoesntLike;

		internal int CClanPlayersThatDontLikeCandidate;

		internal ulong SteamIDCandidate;

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
