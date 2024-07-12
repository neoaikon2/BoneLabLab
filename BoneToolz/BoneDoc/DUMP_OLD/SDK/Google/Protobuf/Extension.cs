using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public abstract class Extension
	{
		internal abstract Type TargetType { get; }

		public int FieldNumber { get; }

		internal abstract IExtensionValue CreateValue();

		public Extension()
			: base()
		{
		}
	}
	public sealed class Extension<TTarget, TValue> : Extension where TTarget : IExtendableMessage<TTarget>
	{
		private readonly FieldCodec<TValue> codec;

		internal TValue DefaultValue
		{
			get
			{
				return (TValue)default(TValue);
			}
		}

		internal override Type TargetType
		{
			get
			{
				return null;
			}
		}

		internal override IExtensionValue CreateValue()
		{
			return null;
		}
	}
}
