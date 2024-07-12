using System;

namespace Google.Protobuf
{
	internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue>
	{
		void MergeFrom(CodedInputStream input);

		void MergeFrom(IExtensionValue value);

		void WriteTo(CodedOutputStream output);

		int CalculateSize();
	}
}
