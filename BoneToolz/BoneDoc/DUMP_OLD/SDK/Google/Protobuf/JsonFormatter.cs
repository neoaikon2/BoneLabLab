using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf
{
	public sealed class JsonFormatter
	{
		public sealed class Settings
		{
			public static Settings Default { get; }

			public bool FormatDefaultValues { get; }

			public TypeRegistry TypeRegistry { get; }

			public bool FormatEnumsAsIntegers { get; }

			static Settings()
			{
			}

			public Settings(bool formatDefaultValues)
				: base()
			{
			}

			public Settings(bool formatDefaultValues, TypeRegistry typeRegistry)
				: base()
			{
			}

			private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers)
				: base()
			{
			}
		}

		private static class OriginalEnumValueHelper
		{
			private static readonly Dictionary<Type, Dictionary<object, string>> dictionaries;

			internal static string GetOriginalName(object value)
			{
				return null;
			}

			private static Dictionary<object, string> GetNameMapping(Type enumType)
			{
				return null;
			}
		}

		private static readonly JsonFormatter diagnosticFormatter;

		private static readonly string[] CommonRepresentations;

		private readonly Settings settings;

		public static JsonFormatter Default { get; }

		private bool DiagnosticOnly
		{
			get
			{
				return default(bool);
			}
		}

		static JsonFormatter()
		{
		}

		public JsonFormatter(Settings settings)
			: base()
		{
		}

		public string Format(IMessage message)
		{
			return null;
		}

		public void Format(IMessage message, TextWriter writer)
		{
		}

		public static string ToDiagnosticString(IMessage message)
		{
			return null;
		}

		private void WriteMessage(TextWriter writer, IMessage message)
		{
		}

		private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten)
		{
			return default(bool);
		}

		internal static string ToJsonName(string name)
		{
			return null;
		}

		private static void WriteNull(TextWriter writer)
		{
		}

		private static bool IsDefaultValue(IFieldAccessor accessor, object value)
		{
			return default(bool);
		}

		public void WriteValue(TextWriter writer, object value)
		{
		}

		private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value)
		{
		}

		private void WriteTimestamp(TextWriter writer, IMessage value)
		{
		}

		private void WriteDuration(TextWriter writer, IMessage value)
		{
		}

		private void WriteFieldMask(TextWriter writer, IMessage value)
		{
		}

		private void WriteAny(TextWriter writer, IMessage value)
		{
		}

		private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value)
		{
		}

		private void WriteStruct(TextWriter writer, IMessage message)
		{
		}

		private void WriteStructFieldValue(TextWriter writer, IMessage message)
		{
		}

		internal void WriteList(TextWriter writer, IList list)
		{
		}

		internal void WriteDictionary(TextWriter writer, IDictionary dictionary)
		{
		}

		internal static void WriteString(TextWriter writer, string text)
		{
		}

		private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c)
		{
		}
	}
}
