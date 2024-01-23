using System;
using System.Collections.Generic;

internal class DelegateList<T>
{
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc;

	private Action<LinkedListNode<Action<T>>> m_releaseFunc;

	private LinkedList<Action<T>> m_callbacks;

	private bool m_invoking;

	public int Count
	{
		get
		{
			return default(int);
		}
	}

	public DelegateList(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc)
		: base()
	{
	}

	public void Add(Action<T> action)
	{
	}

	public void Remove(Action<T> action)
	{
	}

	public void Invoke(T res)
	{
	}

	public void Clear()
	{
	}

	public static DelegateList<T> CreateWithGlobalCache()
	{
		return null;
	}
}
