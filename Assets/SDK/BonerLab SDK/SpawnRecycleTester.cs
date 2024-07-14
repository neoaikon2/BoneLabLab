using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

public class SpawnRecycleTester : MonoBehaviour
{
	public SpawnableCrateReference[] _testSpawnable;

	public float duration;

	private float _lastSpawnTime;

	private Poolee _poolee;

	private int _lastIdx;

	private int _spawnCount;

	private bool _isSpawning;

	private void OnEnable()
	{
	}
	private UniTaskVoid Spawn(Spawnable s)
	{
		return default(UniTaskVoid);
	}

	private void Update()
	{
	}
}
