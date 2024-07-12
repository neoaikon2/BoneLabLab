using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class ImpactProperties : ImpactPropertiesVariables, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<ImpactProperties> _cache;

		[Header("References")]
		public Collider[] colliders;

		[SerializeField]
		[HideInInspector]
		public bool hasManager;

		[HideInInspector]
		[SerializeField]
		public bool ShowControls;

		[HideInInspector]
		[SerializeField]
		public ImpactPropertiesManager Manager;

		private bool setup;

		private bool _isDestroyed;

		public static ComponentCache<ImpactProperties> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void StaticFix()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateMaterial()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public UniTaskVoid RecieveAttackAsync(Attack attack)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid SpawnImpactAsync(Attack attack)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid SpawnDecalAsync(Attack attack, Quaternion rot)
		{
			return default(UniTaskVoid);
		}

		public void SpawnImpactVFX(Attack attack)
		{
		}

		private SurfaceData.MaterialLevel GetMaterialFromAttack(AttackType attackType)
		{
			return default(SurfaceData.MaterialLevel);
		}

		private SurfaceData.MaterialLevel randomizeLevel(SurfaceData.MaterialLevel[] levels)
		{
			return default(SurfaceData.MaterialLevel);
		}

		public void FindColliders(bool childColliders = false)
		{
		}

		public void FindRenderer()
		{
		}

		private void SetRenderer(Renderer renderer)
		{
		}

		public float GetMegaPascals()
		{
			return default(float);
		}

		public ImpactProperties()
			: base()
		{
		}
	}
}
