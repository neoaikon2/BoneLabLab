using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 9776)]
	internal struct SteamUGCDetails_t
	{
		internal PublishedFileId PublishedFileId;

		internal Result Result;

		internal WorkshopFileType FileType;

		internal AppId CreatorAppID;

		internal AppId ConsumerAppID;

		internal byte[] Title;

		internal byte[] Description;

		internal ulong SteamIDOwner;

		internal uint TimeCreated;

		internal uint TimeUpdated;

		internal uint TimeAddedToUserList;

		internal RemoteStoragePublishedFileVisibility Visibility;

		internal bool Banned;

		internal bool AcceptedForUse;

		internal bool TagsTruncated;

		internal byte[] Tags;

		internal ulong File;

		internal ulong PreviewFile;

		internal byte[] PchFileName;

		internal int FileSize;

		internal int PreviewFileSize;

		internal byte[] URL;

		internal uint VotesUp;

		internal uint VotesDown;

		internal float Score;

		internal uint NumChildren;
	}
}
