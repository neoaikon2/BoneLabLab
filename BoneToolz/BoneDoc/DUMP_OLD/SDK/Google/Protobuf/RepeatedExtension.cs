using System;

namespace Google.Protobuf
{
	public sealed class RepeatedExtension<TTarget, TValue> : Extension where TTarget : IExtendableMessage<TTarget>
	{
		private readonly FieldCodec<TValue> codec;

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
