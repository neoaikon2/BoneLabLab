using System;

namespace SLZ.Serialize
{
	public struct TypeId : IEquatable<TypeId>
	{
		public readonly string typeId;

		public TypeId(string typeId, bool stripPrefix = false)
		{
			this.typeId = default(string);
		}

		bool IEquatable<TypeId>.Equals(TypeId other)
		{
			return default(bool);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public static bool operator ==(TypeId lhs, TypeId rhs)
		{
			return default(bool);
		}

		public static bool operator !=(TypeId lhs, TypeId rhs)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
