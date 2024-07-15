using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnVFX : SpawnDecorator
	{
		private MarrowEntity entity;

		private Blip blip;

		public override void OnSpawn(GameObject go)
		{
		}
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}
	}
}
