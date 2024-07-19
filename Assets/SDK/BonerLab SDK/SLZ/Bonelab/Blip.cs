using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Blip : SpawnEvents
	{
		private static ComponentCache<Blip> _cache;

		[SerializeField]
		private Renderer[] Renderers;

		[SerializeField]
		private Spawnable fizzlerSpawnable;

		[SerializeField]
		private Spawnable spawnSpawnable;

		[HideInInspector]
		[Header("DO NOT SET IN INSPECTOR")]
		public Vector3 velocity;

		private bool isDestructible;

		[Header("DO NOT SET IN INSPECTOR")]
		[HideInInspector]
		public bool forceBlip;

		private bool sfxPlayed;

		public static ComponentCache<Blip> Cache => null;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		public void CallSpawnEffect()
		{
		}

		public void CallDespawnEffect()
		{
		}
		public UniTaskVoid FireEffectAsync(Spawnable effect, Color? color = null)
		{
			return default(UniTaskVoid);
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
	}
}
