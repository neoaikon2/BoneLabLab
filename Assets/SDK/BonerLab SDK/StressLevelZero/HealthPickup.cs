using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab;
using SLZ.Marrow;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace StressLevelZero
{
	public class HealthPickup : MonoBehaviour
	{
		public float healthPerc;

		[SerializeField]
		private AudioClip spawnAudioClip;

		[SerializeField]
		private AudioClip collectAudioClip;

		[SerializeField]
		private InteractableHost host;

		[SerializeField]
		private SphereCollider _col;

		[SerializeField]
		private WeaponSlot wSlot;

		[SerializeField]
		private MeshRenderer _rend;

		[SerializeField]
		private GameObject parentObj;

		[SerializeField]
		private GameObject artObj;

		public Poolee poolee;

		public Arena_GameController agc;

		private float despawnDelay;

		private Coroutine timerRoutine;

		private bool _isCollected;

		public SphereGrip sphereGrip;

		public bool isCollectable;

		public bool GetCollectionState()
		{
			return false;
		}

		public void SetCollectable(bool collect)
		{
		}

		public void SetCollectableDelayed(bool collect)
		{
		}
		private IEnumerator CoSetCollectable(bool collect)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void SpawnAudio()
		{
		}

		public void SetSmallState()
		{
		}

		public void SetLargeState()
		{
		}
		private IEnumerator CoCollectAnimation()
		{
			return null;
		}

		public void InitTimer()
		{
		}
		private IEnumerator CoTimedDespawn(float t)
		{
			return null;
		}

		private void OnAddInventory()
		{
		}

		private void OnRemoveInventory()
		{
		}

		public void DespawnFX()
		{
		}

		public void OnDespawn(GameObject go)
		{
		}
	}
}
