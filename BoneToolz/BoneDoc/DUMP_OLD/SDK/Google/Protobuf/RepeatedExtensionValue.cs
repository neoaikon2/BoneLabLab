using System;
using Google.Protobuf.Collections;

namespace Google.Protobuf
{
	internal sealed class RepeatedExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		private RepeatedField<T> field;

		private readonly FieldCodec<T> codec;

		internal RepeatedExtensionValue(FieldCodec<T> codec)
			: base()
		{
		}

		public int CalculateSize()
		{
			return default(int);
		}

		public IExtensionValue Clone()
		{
			return null;
		}

		public bool Equals(IExtensionValue other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public void MergeFrom(CodedInputStream input)
		{
		}

		public void MergeFrom(IExtensionValue value)
		{
		}

		public void WriteTo(CodedOutputStream output)
		{
		}

		public RepeatedField<T> GetValue()
		{
			return null;
		}
	}
}
