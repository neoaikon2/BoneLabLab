using System;

namespace Google.Protobuf
{
	internal sealed class ExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		private bool hasValue;

		private T field;

		private FieldCodec<T> codec;

		internal ExtensionValue(FieldCodec<T> codec)
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

		public T GetValue()
		{
			return (T)default(T);
		}
	}
}
