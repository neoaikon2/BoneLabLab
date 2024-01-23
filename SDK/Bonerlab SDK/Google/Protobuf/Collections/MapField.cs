using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.Collections
{
	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEquatable<MapField<TKey, TValue>>, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;

			public object Current
			{
				get
				{
					return null;
				}
			}

			public DictionaryEntry Entry
			{
				get
				{
					return default(DictionaryEntry);
				}
			}

			public object Key
			{
				get
				{
					return null;
				}
			}

			public object Value
			{
				get
				{
					return null;
				}
			}

			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator)
				: base()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Reset()
			{
			}
		}

		public sealed class Codec
		{
			internal class MessageAdapter : IMessage
			{
				private static readonly byte[] ZeroLengthMessageStreamData;

				private readonly Codec codec;

				internal TKey Key { get; set; }

				internal TValue Value { get; set; }

				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				internal MessageAdapter(Codec codec)
					: base()
				{
				}

				internal void Reset()
				{
				}

				public void MergeFrom(CodedInputStream input)
				{
				}

				public void WriteTo(CodedOutputStream output)
				{
				}

				public int CalculateSize()
				{
					return default(int);
				}
			}

			private readonly FieldCodec<TKey> keyCodec;

			private readonly FieldCodec<TValue> valueCodec;

			private readonly uint mapTag;

			internal uint MapTag
			{
				get
				{
					return default(uint);
				}
			}

			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag)
				: base()
			{
			}
		}

		private class MapView<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
		{
			private readonly MapField<TKey, TValue> parent;

			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;

			private readonly Func<T, bool> containsCheck;

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			public bool IsReadOnly
			{
				get
				{
					return default(bool);
				}
			}

			public bool IsSynchronized
			{
				get
				{
					return default(bool);
				}
			}

			public object SyncRoot
			{
				get
				{
					return null;
				}
			}

			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck)
				: base()
			{
			}

			public void Add(T item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(T item)
			{
				return default(bool);
			}

			public void CopyTo(T[] array, int arrayIndex)
			{
			}

			public IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			public bool Remove(T item)
			{
				return default(bool);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			public void CopyTo(Array array, int index)
			{
			}
		}

		private static readonly EqualityComparer<TValue> ValueEqualityComparer;

		private static readonly EqualityComparer<TKey> KeyEqualityComparer;

		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;

		private readonly LinkedList<KeyValuePair<TKey, TValue>> list;

		public TValue this[TKey key]
		{
			get
			{
				return (TValue)default(TValue);
			}
			set
			{
			}
		}

		public ICollection<TKey> Keys
		{
			get
			{
				return null;
			}
		}

		public ICollection<TValue> Values
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		bool IDictionary.IsFixedSize
		{
			get
			{
				return default(bool);
			}
		}

		ICollection IDictionary.Keys
		{
			get
			{
				return null;
			}
		}

		ICollection IDictionary.Values
		{
			get
			{
				return null;
			}
		}

		bool ICollection.IsSynchronized
		{
			get
			{
				return default(bool);
			}
		}

		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
		{
			get
			{
				return null;
			}
		}

		IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
		{
			get
			{
				return null;
			}
		}

		public MapField<TKey, TValue> Clone()
		{
			return null;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		private bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		public bool Remove(TKey key)
		{
			return default(bool);
		}

		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			return default(bool);
		}

		public void Add(IDictionary<TKey, TValue> entries)
		{
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		public void Clear()
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(MapField<TKey, TValue> other)
		{
			return default(bool);
		}

		public void AddEntriesFrom(CodedInputStream input, Codec codec)
		{
		}

		public void WriteTo(CodedOutputStream output, Codec codec)
		{
		}

		public int CalculateSize(Codec codec)
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return default(bool);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			throw new NotImplementedException();
		}

		public MapField()
			: base()
		{
		}
	}
}
