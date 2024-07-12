using System;
using Google.Protobuf.Collections;

namespace Google.Protobuf
{
	public interface IExtendableMessage<T> : IMessage<T>, IMessage, IEquatable<T>, IDeepCloneable<T> where T : IExtendableMessage<T>
	{
		TValue GetExtension<TValue>(Extension<T, TValue> extension);

		RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<T, TValue> extension);

		bool HasExtension<TValue>(Extension<T, TValue> extension);
	}
}
