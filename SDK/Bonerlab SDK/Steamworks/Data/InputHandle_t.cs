using System;

namespace Steamworks.Data
{
	internal struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
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

		public bool Equals(InputHandle_t p)
		{
			return default(bool);
		}

		public int CompareTo(InputHandle_t other)
		{
			return default(int);
		}
	}
}
