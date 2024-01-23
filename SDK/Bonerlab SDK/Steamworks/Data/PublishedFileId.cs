using System;

namespace Steamworks.Data
{
	public struct PublishedFileId : IEquatable<PublishedFileId>, IComparable<PublishedFileId>
	{
		public ulong Value;

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object p)
		{
			return default(bool);
		}

		public bool Equals(PublishedFileId p)
		{
			return default(bool);
		}

		public int CompareTo(PublishedFileId other)
		{
			return default(int);
		}
	}
}
