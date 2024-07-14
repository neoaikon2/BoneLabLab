using System;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_BatchPrefabBaker : MonoBehaviour
{
	[Serializable]
	public class MB3_PrefabBakerRow
	{
		public GameObject sourcePrefab;

		public GameObject resultPrefab;
	}

	public MB2_LogLevel LOG_LEVEL;

	public MB3_PrefabBakerRow[] prefabRows;

	public string outputPrefabFolder;

	[ContextMenu("Create Instances For Prefab Rows")]
	public void CreateSourceAndResultPrefabInstances()
	{
	}
}
