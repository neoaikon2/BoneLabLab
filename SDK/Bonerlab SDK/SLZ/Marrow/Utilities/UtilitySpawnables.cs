using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class UtilitySpawnables : MonoBehaviour
	{
		private static UtilitySpawnables _instance;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void SpawnAudioPlayer(Vector3 position = default(Vector3), Action<GameObject> callback = default(Action<GameObject>))
		{
		}

		public static UniTask<GameObject> SpawnAudioPlayerAsync(Vector3 position = default(Vector3))
		{
			return default(UniTask<GameObject>);
		}

		public UtilitySpawnables()
			: base()
		{
		}
	}
}
