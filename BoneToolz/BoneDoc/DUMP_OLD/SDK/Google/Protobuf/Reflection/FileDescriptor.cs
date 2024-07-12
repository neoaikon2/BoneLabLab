using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class FileDescriptor : IDescriptor
	{
		private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations;

		internal FileDescriptorProto Proto { get; }

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Package
		{
			get
			{
				return null;
			}
		}

		public IList<MessageDescriptor> MessageTypes { get; }

		public IList<EnumDescriptor> EnumTypes { get; }

		public IList<ServiceDescriptor> Services { get; }

		public ExtensionCollection Extensions { get; }

		public IList<FileDescriptor> Dependencies { get; }

		public IList<FileDescriptor> PublicDependencies { get; }

		string IDescriptor.FullName
		{
			get
			{
				return null;
			}
		}

		FileDescriptor IDescriptor.File
		{
			get
			{
				return null;
			}
		}

		internal DescriptorPool DescriptorPool { get; }

		static FileDescriptor()
		{
		}

		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
			: base()
		{
		}

		private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap()
		{
			return null;
		}

		private IDescriptor FindDescriptorForPath(IList<int> path)
		{
			return null;
		}

		private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index)
		{
			return null;
		}

		private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		internal string ComputeFullName(MessageDescriptor parent, string name)
		{
			return null;
		}

		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies)
		{
			return null;
		}

		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		private void CrossLink()
		{
		}

		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		private static void AddAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo, ExtensionRegistry registry)
		{
		}

		private static IEnumerable<Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated)
		{
			return null;
		}

		private static IEnumerable<Extension> GetAllDependedExtensions(FileDescriptor descriptor)
		{
			return null;
		}

		private static IEnumerable<Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static void ForceReflectionInitialization<T>()
		{
		}
	}
}
