using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BoardGenerator : MonoBehaviour
	{		[SerializeField]
		private bool isUsingAmmo;

		[SerializeField]
		private Grip _grip;

		[SerializeField]
		private Transform FirePoint;

		[SerializeField]
		private float RaycastDistance;

		[SerializeField]
		private float breakforce;

		[SerializeField]
		private Material LineMaterial;

		[SerializeField]
		private Spawnable[] boardSpawnable;

		[SerializeField]
		private Spawnable vfxBlasterSpawnable;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private GameObject laserPointer;

		public AudioClip[] startSFX;

		public AudioClip[] endSFX;

		public AudioClip[] misfireSFX;

		private ManagedAudioPlayer _mapActions;

		private bool ButtonDown;

		private bool Valid;

		private Vector3 firstPoint;

		private Vector3 EndPoint;

		private MarrowBody FirstRb;

		private MarrowBody EndRb;

		private float distance;

		public float ammoDistance;

		private Vector3 upDir;

		public LineRenderer line;

		private int playerLayer;

		private int enemyLayer;

		public HashSet<ObjectDestructible> destBoardHash;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}
		private UniTaskVoid BoardSpawnerAsync()
		{
			return default(UniTaskVoid);
		}

		private void OnBoardDestruction(ObjectDestructible destObj)
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void PrimaryButtonDown()
		{
		}

		private void PrimaryButtonUp()
		{
		}

		public void CeaseFire()
		{
		}

		private void Thingy()
		{
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}
		private IEnumerator lineloop()
		{
			return null;
		}

		private void SetJoint(Vector3 position, MarrowBody bodyB, MarrowBody bodyA)
		{
		}
	}
}
