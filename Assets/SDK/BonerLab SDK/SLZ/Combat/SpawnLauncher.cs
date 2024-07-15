using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Combat
{
	public class SpawnLauncher : MonoBehaviour
	{
		public Spawnable spawnable;

		public Transform firePoint;

		private void Start()
		{
		}
		public UniTaskVoid Spawn()
		{
			return default(UniTaskVoid);
		}
	}
}
