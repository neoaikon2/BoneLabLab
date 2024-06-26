using System.Collections.Generic;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VFX
{
	public class Blip : SpawnEvents
	{
		private static ComponentCache<Blip> _cache;

		[SerializeField]		
#if !UNITY_EDITOR // Castify required modification
		private Renderer[] Renderers;
#else
		public Renderer[] Renderers;
#endif

		[SerializeField]
#if !UNITY_EDITOR // Castify required modification
		private Spawnable fizzlerSpawnable;
#else
		public Spawnable fizzlerSpawnable;
#endif

		[SerializeField]
#if !UNITY_EDITOR // Castify required modification
		private Spawnable spawnSpawnable;
#else
		public Spawnable spawnSpawnable;
#endif

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public Vector3 velocity;

		private bool isDestructible;

		[HideInInspector]
		[Header("DO NOT SET IN INSPECTOR")]
		public bool forceBlip;

		private bool sfxPlayed;

		private List<Mesh> cashedMeshes;

		private Vector3 vecone;

		public static ComponentCache<Blip> Cache => null;

		private void Awake()
		{
		}

		protected new virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		public void CallSpawnEffect()
		{
		}

		public void CallDespawnEffect()
		{
		}

		public void FireEffect(Spawnable effect, Color? color = null)
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
	}
}
