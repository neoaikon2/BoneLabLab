using System;

namespace SLZ.Serialize
{
	public struct ObjectId : IEquatable<ObjectId>
	{
		public readonly string objectId;

		public ObjectId(string objectId, bool stripPrefix = false)
		{
			this.objectId = default(string);
		}

		bool IEquatable<ObjectId>.Equals(ObjectId other)
		{
			return default(bool);
		}

		public override bool Equals(object other)
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
