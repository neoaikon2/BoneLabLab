using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal readonly struct OVREnumerable<T> : IEnumerable<T>, IEnumerable
{
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private enum CollectionType
		{
			None = 0,
			ReadOnlyList = 1,
			List = 2,
			Set = 3,
			Queue = 4,
			Enumerable = 5
		}

		private int _listIndex;

		private readonly CollectionType _type;

		private readonly int _listCount;

		private readonly IEnumerator<T> _enumerator;

		private readonly IReadOnlyList<T> _readOnlyList;

		private HashSet<T>.Enumerator _setEnumerator;

		private Queue<T>.Enumerator _queueEnumerator;

		private List<T>.Enumerator _listEnumerator;

		public T Current
		{
			[MethodImpl(256)]
			get
			{
				return default(T);
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent => null;

		object IEnumerator.Current => throw new NotImplementedException();

		public Enumerator(IEnumerable<T> enumerable)
		{
			_listIndex = 0;
			_type = default(CollectionType);
			_listCount = 0;
			_enumerator = null;
			_readOnlyList = null;
			_setEnumerator = default(HashSet<T>.Enumerator);
			_queueEnumerator = default(Queue<T>.Enumerator);
			_listEnumerator = default(List<T>.Enumerator);
		}

		[MethodImpl(256)]
		public bool MoveNext()
		{
			return false;
		}

		private bool MoveNextReadOnlyList()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}

		[MethodImpl(256)]
		private void ValidateAndThrow()
		{
		}
	}

	private readonly IEnumerable<T> _enumerable;

	public OVREnumerable(IEnumerable<T> enumerable)
	{
		_enumerable = null;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	public int GetCount()
	{
		return 0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new NotImplementedException();
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		throw new NotImplementedException();
	}
}
