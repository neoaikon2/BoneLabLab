using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ara
{
	public class ElasticArray<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private T[] data;

		private int count;

		public int Count => 0;

		public bool IsReadOnly => false;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T[] Data => null;
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void SetCount(int count)
		{
		}

		public void EnsureCapacity(int capacity)
		{
		}

		public void Reverse()
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
