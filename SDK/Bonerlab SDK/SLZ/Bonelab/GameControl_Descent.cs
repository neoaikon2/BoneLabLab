using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.Audio;

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

		[CompilerGenerated]
		private sealed class _003CCoroutineSequence_003Ed__61
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Descent _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003ClerpInSpeed_003E5__3;

			private Vector3 _003CtargetScale_003E5__4;

			private float _003ClerpOutSpeed_003E5__5;

			private float _003CmirrorLerpSpeed_003E5__6;

			private Material _003ClightningMat_003E5__7;

			private float _003ClightningProgress_003E5__8;

			private float _003CTargetTime_003E5__9;

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
			public _003CCoroutineSequence_003Ed__61(int _003C_003E1__state)
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
		private sealed class _003CForceGrabCoroutine_003Ed__62
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Descent _003C_003E4__this;

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
			public _003CForceGrabCoroutine_003Ed__62(int _003C_003E1__state)
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
		private sealed class _003CMirrorInProgress_003Ed__64
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Descent _003C_003E4__this;

			private float _003CvoidProgress_003E5__2;

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
			public _003CMirrorInProgress_003Ed__64(int _003C_003E1__state)
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
		private sealed class _003CMirrorOutProgress_003Ed__65
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Descent _003C_003E4__this;

			private float _003CvoidProgress_003E5__2;

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
			public _003CMirrorOutProgress_003Ed__65(int _003C_003E1__state)
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

		public GameObject module_MirrorPedestal;

		public GameObject module_MirrorPedestalParticles;

		public GameObject module_MirrorButton;

		public GameObject module_MirrorVoidParticles;

		public GameObject module_MirrorSpawnParticles;

		public GameObject module_MirrorVoidFrame;

		public GameObject module_Dagger;

		public GameObject module_DaggerParticles;

		public GameObject module_DaggerLightningHit;

		public GameObject module_LightingBolt;

		public GameObject module_LightingHitParticles;

		public GameObject module_LightingPathParticles;

		public GameObject module_LightningAudio;

		public GameObject module_GallowPin;

		public GameObject module_GallowLockPin;

		public GameObject module_DropGate;

		public GameObject module_ForceGrab;

		public AudioClip clip_HeightParticleWoop;

		public AudioMixerGroup audioMixerGroup;

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

		public MusicAmbience2dSFX playerAmbience;

		public IntroMusicCues[] introMusicCues;

		public SimpleSFX sfx_radioIntro;

		private void OnEnable()
		{
		}

		public override void Start()
		{
		}

		public void DISABLEDEATHRELOAD()
		{
		}

		public void SEQUENCE(int gate_index = 0)
		{
		}

		[IteratorStateMachine(typeof(_003CCoroutineSequence_003Ed__61))]
		public IEnumerator CoroutineSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CForceGrabCoroutine_003Ed__62))]
		public IEnumerator ForceGrabCoroutine()
		{
			return null;
		}

		public void CONFIRMFORCEGRAB()
		{
		}

		[IteratorStateMachine(typeof(_003CMirrorInProgress_003Ed__64))]
		public IEnumerator MirrorInProgress()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMirrorOutProgress_003Ed__65))]
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
