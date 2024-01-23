using System.Diagnostics;

namespace TMPro
{
	[DebuggerDisplay("Item count = {m_Count}")]
	public struct TMP_TextProcessingStack<T>
	{
		public T[] itemStack;

		public int index;

		private T m_DefaultItem;

		private int m_Capacity;

		private int m_RolloverSize;

		private int m_Count;

		private const int k_DefaultCapacity = 4;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public T current
		{
			get
			{
				return (T)default(T);
			}
		}

		public int rolloverSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public TMP_TextProcessingStack(T[] stack)
		{
			this.m_Count = default(int);
			this.m_RolloverSize = default(int);
			this.m_Capacity = default(int);
			this.m_DefaultItem = default(T);
			this.index = default(int);
			this.itemStack = default(T[]);
		}

		public TMP_TextProcessingStack(int capacity)
		{
			this.m_Count = default(int);
			this.m_RolloverSize = default(int);
			this.m_Capacity = default(int);
			this.m_DefaultItem = default(T);
			this.index = default(int);
			this.itemStack = default(T[]);
		}

		public TMP_TextProcessingStack(int capacity, int rolloverSize)
		{
			this.m_Count = default(int);
			this.m_RolloverSize = default(int);
			this.m_Capacity = default(int);
			this.m_DefaultItem = default(T);
			this.index = default(int);
			this.itemStack = default(T[]);
		}

		internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item)
		{
		}

		public void Clear()
		{
		}

		public void SetDefault(T item)
		{
		}

		public void Add(T item)
		{
		}

		public T Remove()
		{
			return (T)default(T);
		}

		public void Push(T item)
		{
		}

		public T Pop()
		{
			return (T)default(T);
		}

		public T Peek()
		{
			return (T)default(T);
		}

		public T CurrentItem()
		{
			return (T)default(T);
		}

		public T PreviousItem()
		{
			return (T)default(T);
		}
	}
}
