using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class FileOptions : IExtendableMessage<FileOptions>, IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum OptimizeMode
			{
				[OriginalName("SPEED")]
				Speed = 1,
				[OriginalName("CODE_SIZE")]
				CodeSize = 2,
				[OriginalName("LITE_RUNTIME")]
				LiteRuntime = 3
			}
		}

		private static readonly MessageParser<FileOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<FileOptions> _extensions;

		private int _hasBits0;

		private static readonly string JavaPackageDefaultValue;

		private string javaPackage_;

		private static readonly string JavaOuterClassnameDefaultValue;

		private string javaOuterClassname_;

		private static readonly bool JavaMultipleFilesDefaultValue;

		private bool javaMultipleFiles_;

		private static readonly bool JavaGenerateEqualsAndHashDefaultValue;

		private bool javaGenerateEqualsAndHash_;

		private static readonly bool JavaStringCheckUtf8DefaultValue;

		private bool javaStringCheckUtf8_;

		private static readonly Types.OptimizeMode OptimizeForDefaultValue;

		private Types.OptimizeMode optimizeFor_;

		private static readonly string GoPackageDefaultValue;

		private string goPackage_;

		private static readonly bool CcGenericServicesDefaultValue;

		private bool ccGenericServices_;

		private static readonly bool JavaGenericServicesDefaultValue;

		private bool javaGenericServices_;

		private static readonly bool PyGenericServicesDefaultValue;

		private bool pyGenericServices_;

		private static readonly bool PhpGenericServicesDefaultValue;

		private bool phpGenericServices_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly bool CcEnableArenasDefaultValue;

		private bool ccEnableArenas_;

		private static readonly string ObjcClassPrefixDefaultValue;

		private string objcClassPrefix_;

		private static readonly string CsharpNamespaceDefaultValue;

		private string csharpNamespace_;

		private static readonly string SwiftPrefixDefaultValue;

		private string swiftPrefix_;

		private static readonly string PhpClassPrefixDefaultValue;

		private string phpClassPrefix_;

		private static readonly string PhpNamespaceDefaultValue;

		private string phpNamespace_;

		private static readonly string PhpMetadataNamespaceDefaultValue;

		private string phpMetadataNamespace_;

		private static readonly string RubyPackageDefaultValue;

		private string rubyPackage_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<FileOptions> Parser
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public string JavaPackage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJavaPackage
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string JavaOuterClassname
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJavaOuterClassname
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool JavaMultipleFiles
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJavaMultipleFiles
		{
			get
			{
				return default(bool);
			}
		}

		[Obsolete]
		[DebuggerNonUserCode]
		public bool JavaGenerateEqualsAndHash
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		[Obsolete]
		public bool HasJavaGenerateEqualsAndHash
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool JavaStringCheckUtf8
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJavaStringCheckUtf8
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public Types.OptimizeMode OptimizeFor
		{
			get
			{
				return default(Types.OptimizeMode);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasOptimizeFor
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string GoPackage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasGoPackage
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool CcGenericServices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasCcGenericServices
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool JavaGenericServices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJavaGenericServices
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool PyGenericServices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPyGenericServices
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool PhpGenericServices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPhpGenericServices
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool CcEnableArenas
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasCcEnableArenas
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string ObjcClassPrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasObjcClassPrefix
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string CsharpNamespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasCsharpNamespace
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string SwiftPrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasSwiftPrefix
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string PhpClassPrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPhpClassPrefix
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string PhpNamespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPhpNamespace
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string PhpMetadataNamespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPhpMetadataNamespace
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string RubyPackage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasRubyPackage
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public FileOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public FileOptions(FileOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public FileOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(FileOptions other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FileOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
