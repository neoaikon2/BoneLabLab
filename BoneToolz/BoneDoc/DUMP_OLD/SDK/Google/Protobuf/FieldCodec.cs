using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public static class FieldCodec
	{
		public static FieldCodec<string> ForString(uint tag)
		{
			return null;
		}

		public static FieldCodec<bool> ForBool(uint tag)
		{
			return null;
		}

		public static FieldCodec<int> ForInt32(uint tag)
		{
			return null;
		}

		public static FieldCodec<float> ForFloat(uint tag)
		{
			return null;
		}

		public static FieldCodec<string> ForString(uint tag, string defaultValue)
		{
			return null;
		}

		public static FieldCodec<bool> ForBool(uint tag, bool defaultValue)
		{
			return null;
		}

		public static FieldCodec<int> ForInt32(uint tag, int defaultValue)
		{
			return null;
		}

		public static FieldCodec<float> ForFloat(uint tag, float defaultValue)
		{
			return null;
		}

		public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) where T : class, IMessage<T>
		{
			return null;
		}
	}
	public sealed class FieldCodec<T>
	{
		internal delegate void InputMerger(CodedInputStream input, T value);

		internal delegate bool ValuesMerger(T value, T other);

		private static readonly EqualityComparer<T> EqualityComparer;

		private static readonly T DefaultDefault;

		private static readonly bool TypeSupportsPacking;

		private readonly int tagSize;

		internal bool PackedRepeatedField { get; }

		internal Action<CodedOutputStream, T> ValueWriter { get; }

		internal Func<T, int> ValueSizeCalculator { get; }

		internal Func<CodedInputStream, T> ValueReader { get; }

		internal InputMerger ValueMerger { get; }

		internal ValuesMerger FieldMerger { get; }

		internal int FixedSize { get; }

		internal uint Tag { get; }

		internal uint EndTag { get; }

		internal T DefaultValue { get; }

		static FieldCodec()
		{
		}

		internal static bool IsPackedRepeatedField(uint tag)
		{
			return default(bool);
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, int fixedSize, uint tag)
			: base()
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, Func<T, int> sizeCalculator, uint tag, uint endTag = 0u)
			: base()
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0u)
			: base()
		{
		}

		internal FieldCodec(Func<CodedInputStream, T> reader, Action<CodedOutputStream, T> writer, InputMerger inputMerger, ValuesMerger valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue)
			: base()
		{
		}

		public void WriteTagAndValue(CodedOutputStream output, T value)
		{
		}

		public T Read(CodedInputStream input)
		{
			return (T)default(T);
		}

		public int CalculateSizeWithTag(T value)
		{
			return default(int);
		}

		private bool IsDefault(T value)
		{
			return default(bool);
		}
	}
}
