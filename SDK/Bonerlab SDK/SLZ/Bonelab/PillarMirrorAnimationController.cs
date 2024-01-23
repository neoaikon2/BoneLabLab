using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Utilities;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class PillarMirrorAnimationController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTurnOffMirror_003Ed__20
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PillarMirrorAnimationController _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTurnOffMirror_003Ed__20(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CMirroPulse_003Ed__24
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PillarMirrorAnimationController _003C_003E4__this;

			public float percent;

			public bool permanent;

			private int _003Ci_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CMirroPulse_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public GameObject centerFragment;

		public GameObject mirrorColider;

		public List<GameObject> mirrorFragments;

		public GameObject audioSource;

		public float maxMirrorTicTime;

		public float randomRotationOffset;

		public Mirror mirror;

		public Spawnable avatarBlaster;

		public Spawnable hitBlaster;

		public ParticleSystemForceField forceField;

		public GameObject reflectionRoot;

		public AudioMixerGroup outputMixer;

		public AudioClip[] cryptidScream;

		public AudioClip[] mirrorBreak;

		private AudioPlayer ap;

		public BarracudaModelManagerMono bmm;

		public ZoneSpawner[] burstBoids;

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

		[IteratorStateMachine(typeof(_003CTurnOffMirror_003Ed__20))]
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

		[IteratorStateMachine(typeof(_003CMirroPulse_003Ed__24))]
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

		private void PlaySFX(AudioClip[] audioClips, float volume, float minDistance, Vector3 position)
		{
		}
	}
}
