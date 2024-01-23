using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private List<T> m_List;

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

	private void InvokeAdded(T element)
	{
	}

	private void InvokeRemoved(T element)
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

	public int IndexOf(T item)
	{
		return default(int);
	}

	public void Insert(int index, T item)
	{
	}

	public bool Remove(T item)
	{
		return default(bool);
	}

	public void RemoveAt(int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public ListWithEvents()
		: base()
	{
	}

	public event Action<T> OnElementAdded;

	public event Action<T> OnElementRemoved;
}
