using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

public class PrismaticSFX : MonoBehaviour
{
	[Serializable]
	public class AudioEvent
	{
		[HideInInspector]
		public bool eventEnabled;

		public Transform eventTran;

		public AudioClip[] eventClip;

		public float minSpeed;

		public float maxSpeed;

		public float triggerDistance;
	}

	[CompilerGenerated]
	private sealed class _003CUpdateSound_003Ed__32
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PrismaticSFX _003C_003E4__this;

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
		public _003CUpdateSound_003Ed__32(int _003C_003E1__state)
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

	[Header("PROPERTIES")]
	public Rigidbody rb_parent;

	public Transform velocityTran;

	public Transform sourceTran;

	public float minSpeed;

	public float maxSpeed;

	public float sourceMinDistance;

	public float pitchMod;

	private float calculate_t;

	[Header("AUDIO")]
	public AudioMixerGroup outputMixer;

	public bool enableModulatedAudio;

	public bool loopClips;

	public AudioClip[] modulatedClips;

	public bool enableEvents;

	public AudioEvent[] audioEvents;

	[Range(0f, 1f)]
	public float SpatialBlend;

	[SerializeField]
	private bool _blockJointBreakStop;

	private AudioPlayer _ap;

	private bool _hasAp;

	private InteractableHost _host;

	private Rigidbody _rigidbody;

	private bool _hostMode;

	private bool _canPlay;

	private const float sleepFreq_t = 0.06f;

	private const float playFreq_t = 0.025f;

	private bool _hasBeenDisabled;

	private WaitForSeconds _sleepWait;

	private WaitForSeconds _playWait;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateSound_003Ed__32))]
	private IEnumerator UpdateSound()
	{
		return null;
	}

	private void OnJointBreak(float breakForce)
	{
	}
}
