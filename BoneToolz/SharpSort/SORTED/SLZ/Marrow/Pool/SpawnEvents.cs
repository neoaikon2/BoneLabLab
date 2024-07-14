using UnityEngine;

namespace SLZ.Marrow.Pool
{
	public abstract class SpawnEvents : MonoBehaviour, IPoolable
	{
		[SerializeField]
		protected Poolee _poolee;

		public ulong ID => 0uL;

		public bool IsDespawned => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Reset()
		{
		}

		public void Despawn()
		{
		}

		public virtual void OnPoolInitialize()
		{
		}

		public virtual void OnPoolSpawn()
		{
		}

		public virtual void OnPoolDeInitialize()
		{
		}
	}
}
