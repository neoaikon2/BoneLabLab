using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

public class NPC_Tracker : MonoBehaviour, ISpawnListenable
{
	[SerializeField]
	private CrateSpawner[] crateSpawners;

	public float registrationDelay;

	private List<GameObject> spawnedGoList;

	public List<NPC_Tracker_Data> npcDataList;

	private void OnEnable()
	{
	}

	private void SetupSpawnerRegistration()
	{
	}
	private IEnumerator CoWaitForSpawns()
	{
		return null;
	}

	public void OnSpawn(GameObject go)
	{
	}

	private void RegisterSpawnedGOs()
	{
	}

	public void OnDespawn(GameObject go)
	{
	}

	[ContextMenu("GetAllCrateSpawners")]
	public void GetAllCrateSpawners()
	{
	}
}
