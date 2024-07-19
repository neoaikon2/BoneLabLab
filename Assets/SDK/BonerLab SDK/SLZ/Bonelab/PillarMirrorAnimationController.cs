using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PillarMirrorAnimationController : MonoBehaviour
	{
		public GameObject centerFragment;

		public GameObject mirrorColider;

		public List<GameObject> mirrorFragments;

		public Transform audioTransform;

		public float maxMirrorTicTime;

		public float randomRotationOffset;

		public Mirror mirror;

		public Spawnable avatarBlaster;

		public Spawnable hitBlaster;

		public ParticleSystemForceField forceField;

		public GameObject reflectionRoot;

		public AudioClip[] cryptidScream;

		public AudioClip[] mirrorBreak;

		public Encounter mirrorEncounter;

		public float startDelay;

		public Animator animator;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[ContextMenu("MirrorBlip")]
		public void MirrorBlip()
		{
		}
		private IEnumerator TurnOffMirror()
		{
			return null;
		}

		private void PlayParticleSystem(SkinnedMeshRenderer meshRen, bool useForceField = true)
		{
		}

		[ContextMenu("Pulse100PrcOn")]
		public void Pulse100PrcOn()
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
		public IEnumerator MirroPulse(float percent, bool permanent = false)
		{
			return null;
		}

		public void PlayHitEffect()
		{
		}

		public void BurstBoids()
		{
		}

		public void startSequence()
		{
		}
		private UniTaskVoid startSequence_async()
		{
			return default(UniTaskVoid);
		}
	}
}
