using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Google.Protobuf.Reflection
{
	internal sealed class DescriptorPool
	{
		private readonly IDictionary<string, IDescriptor> descriptorsByName;

		private readonly IDictionary<ObjectIntPair<IDescriptor>, FieldDescriptor> fieldsByNumber;

		private readonly IDictionary<ObjectIntPair<IDescriptor>, EnumValueDescriptor> enumValuesByNumber;

		private readonly HashSet<FileDescriptor> dependencies;

		private static readonly Regex ValidationRegex;

		internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles)
			: base()
		{
		}

		private void ImportPublicDependencies(FileDescriptor file)
		{
		}

		internal T FindSymbol<T>(string fullName) where T : class
		{
			return null;
		}

		internal void AddPackage(string fullName, FileDescriptor file)
		{
		}

		internal void AddSymbol(IDescriptor descriptor)
		{
		}

		private static void ValidateSymbolName(IDescriptor descriptor)
		{
		}

		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number)
		{
			return null;
		}

		internal void AddFieldByNumber(FieldDescriptor field)
		{
		}

		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue)
		{
		}

		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo)
		{
			return null;
		}
	}
}
