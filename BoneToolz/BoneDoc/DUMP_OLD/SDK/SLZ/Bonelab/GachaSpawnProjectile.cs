using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GachaSpawnProjectile : SpawnEvents
	{
		public Rigidbody rb;

		public Spawnable spawnable;

		public MeshFilter previewMeshFilter;

		public Transform previewMeshTransform;

		public float startScale;

		public CurveData growAnim;

		private void OnDisable()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private UniTaskVoid AsyncSpawnProcedure()
		{
			return default(UniTaskVoid);
		}

		public GachaSpawnProjectile()
			: base()
		{
		}
	}
}
