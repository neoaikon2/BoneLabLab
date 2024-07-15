using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_Descent : BonelabInternalGameControl
	{
		[Serializable]
		public struct IntroMusicCues
		{
			[Tooltip("Skips if empty")]
			public AudioClip introClip;

			public AudioClip clipMain;

			[Range(0f, 1f)]
			public float volume;

			[Range(0f, 10f)]
			public float fadeInTime;

			[Range(0f, 10f)]
			public float fadeOutTime;

			public bool loop;
		}
		public NooseBonelabIntro nooseScript;

		public GameObject dynamicGallows;

		public GameObject module_startVoid;

		public GameObject module_SphereVolume;

		public GameObject module_ConstellationParticles;

		public GameObject module_Height;

		public GameObject module_HeightSpawnEffect;

		public GameObject module_HeightInTarget;

		public GameObject module_HeightOutTarget;

		public GameObject module_Mirror;

		public GameObject module_MirrorReflectVol;

		public GameObject module_MirrorPedestal;

		public GameObject module_MirrorPedestalParticles;

		public MarrowEntity module_MirrorButton;

		public MarrowEntity module_AvatarDie;

		public GameObject module_MirrorVoidParticles;

		public GameObject module_MirrorSpawnParticles;

		public GameObject module_MirrorVoidFrame;

		public MarrowEntity daggerEntity;

		public GameObject module_DaggerParticles;

		public GameObject module_DaggerLightningHit;

		public GameObject module_LightingBolt;

		public GameObject module_LightingHitParticles;

		public Transform module_DaggerHitPoint;

		public AudioClip module_DaggerHitClip;

		public GameObject module_LightingPathParticles;

		public Transform module_LightningAudioTransform;

		public AudioClip module_LightningAudioClip;

		public GameObject module_GallowPin;

		public GameObject module_GallowLockPin;

		public GameObject module_DropGate;

		public GameObject module_ForceGrab;

		public AudioClip clip_HeightParticleWoop;

		public SimpleSFX sfx_MirrorVoidParticles;

		public AnimationCurve curve_HeightOpenX;

		public AnimationCurve curve_HeightOpenY;

		public AnimationCurve curve_HeightOpenZ;

		public AnimationCurve curve_HeightCloseX;

		public AnimationCurve curve_HeightCloseY;

		public AnimationCurve curve_HeightCloseZ;

		public AnimationCurve curve_Mirror;

		private Renderer voidFrame;

		public bool gate_height;

		public bool gate_mirror;

		public bool gate_d6;

		public bool gate_noose;

		public bool gate_drop;

		public bool gate_cut;

		private bool canForceGrab;

		private bool gate_forceGrab;

		private IEnumerator forceGrabRoutine;

		public Transform forwardFacing;

		[Header("Field Ambience and Reverb")]
		public AudioClip fieldAmbClipMain;

		[Range(0f, 1f)]
		public float amb_volume;

		[Range(0f, 10f)]
		public float amb_fadeInTime;

		[Range(0f, 10f)]
		public float amb_fadeOutTime;

		public AudioReverbData fieldReverbObj;

		public IntroMusicCues[] introMusicCues;

		public SimpleSFX sfx_radioIntro;

		public PlayerAvatarDecorator playerAvatarDecorator;

		private Player_Health playerHealth;

		public CrateSpawner torchPit;

		private bool levelLoaded;

		private void OnEnable()
		{
		}

		public override void Start()
		{
		}

		private void StartCallback(bool resuming)
		{
		}

		public void DISABLEDEATHRELOAD()
		{
		}

		public void SEQUENCE(int gate_index = 0)
		{
		}
		public IEnumerator CoroutineSequence()
		{
			return null;
		}
		public IEnumerator ForceGrabCoroutine()
		{
			return null;
		}

		public void CONFIRMFORCEGRAB()
		{
		}
		public IEnumerator MirrorInProgress()
		{
			return null;
		}
		public IEnumerator MirrorOutProgress()
		{
			return null;
		}

		public void SetupFieldReverbAndAmbience()
		{
		}

		public void PlayIntroMusic(int cue)
		{
		}

		private void PlayAudioQuick(AudioClip clipToPlay, Transform place)
		{
		}

		public override void DoLevelComplete()
		{
		}
	}
}
