using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	public class VFXSpawnPolicy : SpawnPolicy
	{
		private double _timeOfLastSpawn;

		private Poolee _lastSpawn;
		public override UniTask<Poolee> Spawn(Pool pool, SpawnPolicyData policyData, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null)
		{
			return default(UniTask<Poolee>);
		}
	}
}
