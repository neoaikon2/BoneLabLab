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

		public static ComponentCache<DecalCache> _cache;

		[SerializeField]
		public EasyDecal easyDecal;

		public Color tintingColor;

		public Material CustomMat;

		public AssetPoolee poolee;

		public static ComponentCache<DecalCache> Cache
		{
			get
			{
				return null;
			}
		}

		public void Reset()
		{
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnDisable()
		{
		}

		public void SetMaterial(Material material)
		{
		}

		public void SetObject(GameObject GO)
		{
		}

		public void decalMaterial(EasyDecal decal, Mesh mesh)
		{
		}

		public void SetGenerationType(ImpactPropertiesVariables.DecalType decalType)
		{
		}

		public void OnEnable()
		{
		}

		public void TintMaterial(Color color)
		{
		}

		public void DecalTint(EasyDecal decal, Mesh mesh)
		{
		}

		public DecalCache()
			: base()
		{
		}
	}
}
