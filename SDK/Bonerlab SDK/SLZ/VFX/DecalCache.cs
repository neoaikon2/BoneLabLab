using SLZ.Combat;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using ch.sycoforge.Decal;

namespace SLZ.VFX
{
	[RequireComponent(typeof(EasyDecal))]
	public class DecalCache : MonoBehaviour
	{
		public enum DecalType
		{
			mesh = 0,
			plane = 1
		}

		private static ComponentCache<DecalCache> _cache;

		[SerializeField]
		private EasyDecal easyDecal;

		private Color tintingColor;

		private Material CustomMat;

		private AssetPoolee poolee;

		public static ComponentCache<DecalCache> Cache => null;

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

		public void SetMaterial(Material material)
		{
		}

		public void SetObject(GameObject GO)
		{
		}

		private void decalMaterial(EasyDecal decal, Mesh mesh)
		{
		}

		public void SetGenerationType(ImpactPropertiesVariables.DecalType decalType)
		{
		}

		private void OnEnable()
		{
		}

		public void TintMaterial(Color color)
		{
		}

		private void DecalTint(EasyDecal decal, Mesh mesh)
		{
		}
	}
}
