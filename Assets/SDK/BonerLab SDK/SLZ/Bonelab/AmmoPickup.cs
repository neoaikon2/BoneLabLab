using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class AmmoPickup : SpawnEvents
	{
		public AmmoGroup ammoGroup;

		public int ammoCount;

		public AudioClip collectAudioClip;

		public UnityEvent OnAmmoCollect;

		public Spawnable animeCollectVFXSpawnable;

		public Spawnable bulletBlastVFXSpawnable;

		public Spawnable smokerVFXSpawnable;

		private bool _isCollected;

		private Vector3 scale;

		protected override void Awake()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
		private UniTaskVoid DelayDespawnAsync()
		{
			return default(UniTaskVoid);
		}

		public void ForcePickup()
		{
		}
	}
}
