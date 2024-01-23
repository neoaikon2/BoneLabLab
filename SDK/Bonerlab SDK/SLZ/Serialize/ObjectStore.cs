using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

namespace SLZ.Serialize
{
	public class ObjectStore
	{
		private Dictionary<Type, TypeId> types;

		private Dictionary<TypeId, Type> typesReverse;

		private Dictionary<ObjectId, IJSONPackable> objects;

		private HashSet<IJSONPackable> objectSet;

		private JObject jsonDocument;

		private int currentObjectId;

		private int currentTypeId;

		private ObjectStore(Dictionary<ObjectId, IJSONPackable> objects, HashSet<IJSONPackable> objectSet, JObject jsonDocument)
			: this()
		{
		}

		public ObjectStore()
			: base()
		{
		}

		public ObjectStore(JObject jsonDocument)
			: this()
		{
		}

		public bool TryGetJSON(string key, ObjectId forObject, [Out] JToken result)
		{
			return default(bool);
		}

		public bool TryUnpackReference<TPackable>(JToken token, TPackable packable) where TPackable : IJSONPackable
		{
			return default(bool);
		}

		public bool TryCreateFromReference<TPackable>(JToken token, [Out] TPackable packable, Func<Type, TPackable> factory) where TPackable : IJSONPackable
		{
			return default(bool);
		}

		public JObject PackReference<TPackable>(TPackable value) where TPackable : IJSONPackable
		{
			return null;
		}

		public bool TryPack<TStorable>(TStorable root, [Out] JObject json) where TStorable : IJSONPackable
		{
			return default(bool);
		}

		private ObjectId NextObjectId()
		{
			return default(ObjectId);
		}

		private ObjectId AddObject(IJSONPackable packable)
		{
			return default(ObjectId);
		}

		private ObjectId AddOrUpdateObject(ObjectId objectId, IJSONPackable packable)
		{
			return default(ObjectId);
		}

		private TypeId NextTypeId()
		{
			return default(TypeId);
		}

		private TypeId RegisterTypeId(Type type)
		{
			return default(TypeId);
		}

		private bool FillTypeId(Type type, TypeId typeId)
		{
			return default(bool);
		}

		public void LoadTypes(JObject types)
		{
		}

		private JObject MakeTypeInfo(Type type, bool extendedInfo = false)
		{
			return null;
		}
	}
}
