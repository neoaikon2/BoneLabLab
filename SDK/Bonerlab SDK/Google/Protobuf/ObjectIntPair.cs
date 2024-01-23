using System;

namespace Google.Protobuf
{
	internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> where T : class
	{
		private readonly int number;

		private readonly T obj;

		internal ObjectIntPair(T obj, int number)
		{
			this.obj = default(T);
			this.number = default(int);
		}

		public bool Equals(ObjectIntPair<T> other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
