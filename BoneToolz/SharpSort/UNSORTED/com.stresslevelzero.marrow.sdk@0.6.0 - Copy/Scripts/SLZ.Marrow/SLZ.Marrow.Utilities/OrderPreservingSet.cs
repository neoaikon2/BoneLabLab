using System.Collections;
using System.Collections.Generic;

namespace SLZ.Marrow.Utilities
{
	public class OrderPreservingSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		private readonly IDictionary<T, LinkedListNode<T>> _dictionary;

		private readonly LinkedList<T> _linkedList;

		public int Count => 0;

		public bool IsReadOnly => false;

		public T this[int index] => default(T);

		public OrderPreservingSet(IEqualityComparer<T> comparer)
		{
		}

		public OrderPreservingSet()
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
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
	}
}
