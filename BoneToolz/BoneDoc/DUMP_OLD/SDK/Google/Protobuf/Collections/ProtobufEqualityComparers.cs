using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Collections
{
	public static class ProtobufEqualityComparers
	{
		private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double>
		{
			public override bool Equals(double x, double y)
			{
				return default(bool);
			}

			public override int GetHashCode(double obj)
			{
				return default(int);
			}

			public BitwiseDoubleEqualityComparerImpl()
				: base()
			{
			}
		}

		private class BitwiseSingleEqualityComparerImpl : EqualityComparer<float>
		{
			public override bool Equals(float x, float y)
			{
				return default(bool);
			}

			public override int GetHashCode(float obj)
			{
				return default(int);
			}

			public BitwiseSingleEqualityComparerImpl()
				: base()
			{
			}
		}

		private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<double?>
		{
			public override bool Equals(double? x, double? y)
			{
				return default(bool);
			}

			public override int GetHashCode(double? obj)
			{
				return default(int);
			}

			public BitwiseNullableDoubleEqualityComparerImpl()
				: base()
			{
			}
		}

		private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<float?>
		{
			public override bool Equals(float? x, float? y)
			{
				return default(bool);
			}

			public override int GetHashCode(float? obj)
			{
				return default(int);
			}

			public BitwiseNullableSingleEqualityComparerImpl()
				: base()
			{
			}
		}

		public static EqualityComparer<double> BitwiseDoubleEqualityComparer { get; }

		public static EqualityComparer<float> BitwiseSingleEqualityComparer { get; }

		public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer { get; }

		public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer { get; }

		public static EqualityComparer<T> GetEqualityComparer<T>()
		{
			return null;
		}
	}
}
