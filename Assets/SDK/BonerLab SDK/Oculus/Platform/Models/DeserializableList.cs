using System;
using System.Collections;
using System.Collections.Generic;

namespace Oculus.Platform.Models
{
	public class DeserializableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		protected List<T> _Data;

		protected string _NextUrl;

		protected string _PreviousUrl;

		public int Count => 0;

		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly => false;

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

		[Obsolete("Use IList interface on the DeserializableList object instead.", false)]
		public List<T> Data => null;

		public bool HasNextPage => false;

		public bool HasPreviousPage => false;

		public string NextUrl => null;

		public string PreviousUrl => null;

		public bool IsReadOnly => throw new NotImplementedException();

		public int IndexOf(T obj)
		{
			return 0;
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

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		private IEnumerator GetEnumerator1()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
