using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Collections
{
	public sealed class RepeatedField<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		private static readonly EqualityComparer<T> EqualityComparer;

		private static readonly T[] EmptyArray;

		private T[] array;

		private int count;

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

		public T this[int index]
		{
			get
			{
				return (T)default(T);
			}
			set
			{
			}
		}

		bool IList.IsFixedSize
		{
			get
			{
				return default(bool);
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

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RepeatedField<T> Clone()
		{
			return null;
		}

		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec)
		{
		}

		public int CalculateSize(FieldCodec<T> codec)
		{
			return default(int);
		}

		private int CalculatePackedDataSize(FieldCodec<T> codec)
		{
			return default(int);
		}

		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec)
		{
		}

		private void EnsureSize(int size)
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

		public bool Remove(T item)
		{
			return default(bool);
		}

		public void AddRange(IEnumerable<T> values)
		{
		}

		public void Add(IEnumerable<T> values)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(RepeatedField<T> other)
		{
			return default(bool);
		}

		public int IndexOf(T item)
		{
			return default(int);
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public override string ToString()
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		int IList.Add(object value)
		{
			return default(int);
		}

		bool IList.Contains(object value)
		{
			return default(bool);
		}

		int IList.IndexOf(object value)
		{
			return default(int);
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		public RepeatedField()
			: base()
		{
		}
	}
}
