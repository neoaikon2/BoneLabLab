using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal static class OVRObjectPool
{
	private static class Storage<T> where T : class, new()
	{
		public static readonly HashSet<T> HashSet;
	}

	public struct ListScope<T> : IDisposable
	{
		private List<T> _list;

		public ListScope(out List<T> list)
		{
			_list = null;
			list = null;
		}

		public void Dispose()
		{
		}
	}

	public readonly struct DictionaryScope<TKey, TValue> : IDisposable
	{
		private readonly Dictionary<TKey, TValue> _dictionary;

		public DictionaryScope(out Dictionary<TKey, TValue> dictionary)
		{
			_dictionary = null;
			dictionary = null;
		}

		public void Dispose()
		{
		}
	}

	public readonly struct HashSetScope<T> : IDisposable
	{
		private readonly HashSet<T> _set;

		public HashSetScope(out HashSet<T> set)
		{
			_set = null;
			set = null;
		}

		public void Dispose()
		{
		}
	}

	public readonly struct StackScope<T> : IDisposable
	{
		private readonly Stack<T> _stack;

		public StackScope(out Stack<T> stack)
		{
			_stack = null;
			stack = null;
		}

		public void Dispose()
		{
		}
	}

	public readonly struct QueueScope<T> : IDisposable
	{
		private readonly Queue<T> _queue;

		public QueueScope(out Queue<T> queue)
		{
			_queue = null;
			queue = null;
		}

		public void Dispose()
		{
		}
	}

	public readonly struct ItemScope<T> : IDisposable where T : class, new()
	{
		private readonly T _item;

		public ItemScope(out T item)
		{
			_item = null;
			item = null;
		}

		public void Dispose()
		{
		}
	}

	public static T Get<T>() where T : class, new()
	{
		return null;
	}

	public static List<T> List<T>()
	{
		return null;
	}

	public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>()
	{
		return null;
	}

	public static HashSet<T> HashSet<T>()
	{
		return null;
	}

	public static Stack<T> Stack<T>()
	{
		return null;
	}

	public static Queue<T> Queue<T>()
	{
		return null;
	}

	public static void Return<T>(T obj) where T : class, new()
	{
	}

	public static void Return<T>(HashSet<T> set)
	{
	}

	public static void Return<T>(Stack<T> stack)
	{
	}

	public static void Return<T>(Queue<T> queue)
	{
	}
}
