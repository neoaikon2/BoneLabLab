using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace TMPro
{
	internal class TMP_ObjectPool<T> where T : new()
	{
		private readonly Stack<T> m_Stack;

		private readonly UnityAction<T> m_ActionOnGet;

		private readonly UnityAction<T> m_ActionOnRelease;

		public int countAll { get; private set; }

		public int countActive
		{
			get
			{
				return default(int);
			}
		}

		public int countInactive
		{
			get
			{
				return default(int);
			}
		}

		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
			: base()
		{
		}

		public T Get()
		{
			return (T)default(T);
		}

		public void Release(T element)
		{
		}
	}
}
