using System.Collections.Generic;
using System.Runtime.InteropServices;
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

		public bool TryGet(GameObject go, [Out] T component)
		{
			return default(bool);
		}

		public void Remove(GameObject go, T component)
		{
		}

		public void Add(GameObject go, T component)
		{
		}

		public bool IsEmpty()
		{
			return default(bool);
		}

		public ComponentCache()
			: base()
		{
		}
	}
}
