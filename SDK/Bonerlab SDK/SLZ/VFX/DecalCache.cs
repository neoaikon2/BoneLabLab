using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(DecalProjector))]
	public class DecalCache : MonoBehaviour
	{
		private static ComponentCache<DecalCache> _cache;

		[SerializeField]
		private DecalProjector _decalProjector;

		private Poolee poolee;

		public static ComponentCache<DecalCache> Cache
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private UniTaskVoid DelayedDespawn()
		{
			return default(UniTaskVoid);
		}

		public void SetColliderColorAndCreate(Collider hitCollider, Color color)
		{
		}

		public void SetVariablesAndCreate(SurfaceData.MaterialLevel decalMaterialLevel, Collider hitCollider, Color colorTint)
		{
		}

		public DecalCache()
			: base()
		{
		}
	}
}
