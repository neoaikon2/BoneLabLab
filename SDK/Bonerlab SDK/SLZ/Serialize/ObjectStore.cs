using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

namespace SLZ.Serialize
{
	public class ObjectStore
	{		
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		public struct ObjectStoreBuilder
		{
			private IEnumerable<KeyValuePair<Type, string>> _builtinTypes;

			private IEnumerable<KeyValuePair<Type, string>> _types;

			private IEnumerable<KeyValuePair<string, string>> _typeRenames;

			private IEnumerable<KeyValuePair<string, IPackable>> _objects;

			private ISet<IPackable> _objectSet;

			private JObject _jsonDocument;

			public ObjectStoreBuilder WithBuiltInTypes(IEnumerable<KeyValuePair<Type, string>> builtinTypes)
			{
				return default(ObjectStoreBuilder);
			}

			public ObjectStoreBuilder WithTypeRenames(IEnumerable<KeyValuePair<string, string>> typeRenames)
			{
				return default(ObjectStoreBuilder);
			}

			public ObjectStoreBuilder WithJsonDocument(JObject jsonDocument)
			{
				return default(ObjectStoreBuilder);
			}

			public ObjectStore Build()
			{
				return null;
			}
		}

		private readonly Dictionary<string, string> _typeRenames;

		private readonly Dictionary<Type, string> _builtinTypes;

		private readonly Dictionary<Type, string> _types;

		private readonly Dictionary<string, Type> _builtinTypesReverse;

		private readonly Dictionary<string, Type> _typesReverse;

		private readonly Dictionary<string, IPackable> _objects;

		private readonly HashSet<IPackable> _objectSet;

		private readonly JObject _jsonDocument;

		private int currentObjectId;

		private int currentTypeId;

		/*public static ObjectStoreBuilder Builder
		{
			get
			{
				return default(ObjectStoreBuilder);
			}
		}*/

		private ObjectStore(IEnumerable<KeyValuePair<Type, string>> builtinTypes, IEnumerable<KeyValuePair<Type, string>> types, IEnumerable<KeyValuePair<string, string>> typeRenames, IEnumerable<KeyValuePair<string, IPackable>> objects, ISet<IPackable> objectSet, JObject jsonDocument)
			: base()
		{
		}

		public bool TryGetJSON(string key, string objectId, [Out] JToken result)
		{
			return default(bool);
		}

		public bool TryUnpackReference<TPackable>(JToken token, TPackable packable) where TPackable : IPackable
		{
			return default(bool);
		}

		public bool TryCreateFromReference<TPackable>(JToken token, [Out] TPackable packable, Func<Type, TPackable> factory) where TPackable : IPackable
		{
			return default(bool);
		}

		public JObject PackReference<TPackable>(TPackable value) where TPackable : IPackable
		{
			return null;
		}

		public bool TryPack<TStorable>(TStorable root, [Out] JObject json) where TStorable : IPackable
		{
			return default(bool);
		}

		private string AddObject(IPackable packable)
		{
			return null;
		}

		private string AddOrUpdateObject(string objectId, IPackable packable)
		{
			return null;
		}

		private string RegisterTypeId(Type type)
		{
			return null;
		}

		public void LoadTypes(JObject types)
		{
		}

		private JToken MakeTypeInfo(Type type, bool extendedInfo = false)
		{
			return null;
		}

		private bool TryResolveTypeId(string typeId, [Out] Type type, [Out] bool isBuiltIn, [Out] bool isRenamed)
		{
			return default(bool);
		}
	}
}
