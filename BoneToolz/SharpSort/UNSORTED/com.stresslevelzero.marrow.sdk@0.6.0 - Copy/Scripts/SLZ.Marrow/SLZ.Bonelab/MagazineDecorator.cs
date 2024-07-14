using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MagazineDecorator : SpawnDecorator
	{
		[SerializeField]
		private CartridgeData _cartridgeData;

		[SerializeField]
		private int _ammoCount;

		public override void OnSpawn(GameObject go)
		{
		}
		private UniTaskVoid InitializeAsync(Magazine magazine)
		{
			return default(UniTaskVoid);
		}
	}
}
