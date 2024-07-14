using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	public class Pool
	{
		private readonly SpawnableCrate _crate;

		private GameObject _templateObject;

		private readonly Transform _parentTransform;

		private string _prefabName;

		private readonly List<Poolee> _objects;

		private readonly List<Poolee> _despawned;

		private readonly List<Poolee> _spawned;

		public Pool(SpawnableCrate sc, Transform rootTransform = null)
		{
		}
		internal UniTask<Poolee> Spawn(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null, bool forceInstantiation = false)
		{
			return default(UniTask<Poolee>);
		}

		public void Clear(Poolee poolee)
		{
		}

		public void Despawn(Poolee poolee, bool skipDisable = false)
		{
		}
	}
}
