using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	public class SpawnPolicy
	{
		protected readonly List<Poolee> _poolees;

		protected int _requestedSpawns;
		public virtual UniTask<Poolee> Spawn(Pool pool, SpawnPolicyData policyData, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null)
		{
			return default(UniTask<Poolee>);
		}
		protected virtual UniTask<Poolee> SpawnFromPool(Pool pool, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null)
		{
			return default(UniTask<Poolee>);
		}

		public void Clear(Poolee poolee)
		{
		}

		public virtual bool Despawn(Pool pool, Poolee poolee, bool skipDisable = false)
		{
			return false;
		}
	}
}
