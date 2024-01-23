using System;

namespace Steamworks.Data
{
	internal struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		public uint Value;

		public static implicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

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

		public bool Equals(ScreenshotHandle p)
		{
			return default(bool);
		}

		public int CompareTo(ScreenshotHandle other)
		{
			return default(int);
		}
	}
}
