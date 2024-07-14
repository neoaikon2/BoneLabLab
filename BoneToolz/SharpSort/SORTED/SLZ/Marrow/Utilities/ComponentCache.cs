using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class ComponentCache<T> where T : MonoBehaviour
	{
		private readonly Dictionary<GameObject, List<T>> _cache;

		public T Get(GameObject go)
		{
			return null;
		}

		public bool TryGet(GameObject go, out T component)
		{
			component = null;
			return false;
		}

		public void Remove(GameObject go, T component)
		{
		}

		public void Add(GameObject go, T component)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}
	}
}
