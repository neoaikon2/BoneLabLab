using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf
{
	public static class ExtensionSet
	{
		private static bool TryGetValue<TTarget>(ExtensionSet<TTarget> set, Extension extension, [Out] IExtensionValue value) where TTarget : IExtendableMessage<TTarget>
		{
			return default(bool);
		}

		public static TValue Get<TValue, TTarget>(ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return (TValue)default(TValue);
		}

		public static RepeatedField<TValue> Get<TValue, TTarget>(ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}

		public static bool Has<TTarget, TValue>(ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return default(bool);
		}

		public static bool TryMergeFieldFrom<TTarget>(ExtensionSet<TTarget> set, CodedInputStream stream) where TTarget : IExtendableMessage<TTarget>
		{
			return default(bool);
		}

		public static void MergeFrom<TTarget>(ExtensionSet<TTarget> first, ExtensionSet<TTarget> second) where TTarget : IExtendableMessage<TTarget>
		{
		}

		public static ExtensionSet<TTarget> Clone<TTarget>(ExtensionSet<TTarget> set) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}
	}
	public sealed class ExtensionSet<TTarget> where TTarget : IExtendableMessage<TTarget>
	{
		internal Dictionary<int, IExtensionValue> ValuesByNumber { get; }

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public int CalculateSize()
		{
			return default(int);
		}

		public void WriteTo(CodedOutputStream stream)
		{
		}

		public ExtensionSet()
			: base()
		{
		}
	}
}
