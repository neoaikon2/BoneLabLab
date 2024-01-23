using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.SFX;
using SLZ.VRMK;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class TaxiController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCreditsCoroutine_003Ed__91
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

			private float _003Ctime_003E5__2;

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
			public _003CCreditsCoroutine_003Ed__91(int _003C_003E1__state)
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
		private sealed class _003CCoWaitForPush_003Ed__94
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

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
			public _003CCoWaitForPush_003Ed__94(int _003C_003E1__state)
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
		private sealed class _003CEngineSoundCoroutine_003Ed__97
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

			public int i;

			public float blendTime;

			private float _003CtargetVol_003E5__2;

			private float _003Cstart1Volume_003E5__3;

			private float _003Cstate2Volume_003E5__4;

			private float _003Ctime_003E5__5;

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
			public _003CEngineSoundCoroutine_003Ed__97(int _003C_003E1__state)
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
		private sealed class _003CPushPromptCoroutine_003Ed__101
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

			private int _003CpromptCount_003E5__2;

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
			public _003CPushPromptCoroutine_003Ed__101(int _003C_003E1__state)
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
		private sealed class _003CDuckMusicCoroutine_003Ed__104
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

			public float length;

			private float _003Ctime_003E5__2;

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
			public _003CDuckMusicCoroutine_003Ed__104(int _003C_003E1__state)
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
		private sealed class _003CCoWaitForStop_003Ed__110
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

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
			public _003CCoWaitForStop_003Ed__110(int _003C_003E1__state)
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
		private sealed class _003CCoPlayerDist_003Ed__111
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController _003C_003E4__this;

			private float _003CtoPlayerThresh_003E5__2;

			private float _003CtoPlayerMag_003E5__3;

			private float _003Ctime_003E5__4;

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
			public _003CCoPlayerDist_003Ed__111(int _003C_003E1__state)
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

		public ConfigurableJoint frontLf;

		public ConfigurableJoint frontRt;

		public ConfigurableJoint backLf;

		public ConfigurableJoint backRt;

		public CollisionStaySensor frontLfStaySensor;

		public CollisionStaySensor frontRtStaySensor;

		public CollisionStaySensor backLfStaySensor;

		public CollisionStaySensor backRtStaySensor;

		public Rigidbody steeringWheel;

		public Rigidbody frontAxle;

		[SerializeField]
		private global::SLZ.Marrow.Interaction.SplineJoint splineJoint;

		[SerializeField]
		private PolyLine jimmyExitPolyLine;

		[SerializeField]
		private Rigidbody carBody;

		private ConfigurableJoint _steeringHinge;

		[SerializeField]
		private RigManager rigManager;

		[Header("Off  -  0")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_off;

		[InspectorDisplayName("Position Damper")]
		public float damper_off;

		[InspectorDisplayName("Maximum Force")]
		public float force_off;

		[Header("Idle  -  1")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_idle;

		[InspectorDisplayName("Position Damper")]
		public float damper_idle;

		[InspectorDisplayName("Maximum Force")]
		public float force_idle;

		[InspectorDisplayName("Target Velocity")]
		[Header("Fast  -  2")]
		public float velocity_fast;

		[InspectorDisplayName("Position Damper")]
		public float damper_fast;

		[InspectorDisplayName("Maximum Force")]
		public float force_fast;

		[Header("Slow  -  3")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_slow;

		[InspectorDisplayName("Position Damper")]
		public float damper_slow;

		[InspectorDisplayName("Maximum Force")]
		public float force_slow;

		[Header("Brake  -  4")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_brake;

		[InspectorDisplayName("Position Damper")]
		public float damper_brake;

		[InspectorDisplayName("Maximum Force")]
		public float force_brake;

		private Vector3 jointDriveCurrent;

		private Vector3 jointDriveTarget;

		private Vector3 jointDriveVel;

		public float throttleTime;

		[SerializeField]
		private float currVelMag;

		[SerializeField]
		private float velThresh;

		private float stopThresh;

		public float creditsLength;

		public MeshRenderer creditsRenderer;

		public Texture creditsTexture;

		private Material creditsMaterial;

		public GenericAnimatorController jimmyController;

		public AudioMixerGroup outputMixer;

		[SerializeField]
		private AudioClip[] engineStart;

		[SerializeField]
		private AudioClip[] brakeSqueal;

		[SerializeField]
		private AudioClip[] doorOpen;

		[SerializeField]
		private AudioClip[] doorClose;

		[Range(0f, 1f)]
		public float engineVolume;

		[Range(0f, 1f)]
		public float engineVolumeInterior;

		[SerializeField]
		private AudioClip engineIdleExteriorLoop;

		[SerializeField]
		private AudioClip engineIdleInteriorLoop;

		[SerializeField]
		private AudioClip engineSpeedExteriorLoop;

		[SerializeField]
		private AudioClip engineSpeedInteriorLoop;

		public AudioSource engineSource1;

		public AudioSource engineSource2;

		public Transform doorTransform;

		private IEnumerator engineCoroutine;

		private bool engineSource1UsedLast;

		[SerializeField]
		private AudioClip honkClip;

		[SerializeField]
		private AudioClip fenceMusic;

		public AudioSource cabMusicSource;

		public AnimationCurve duckCurve;

		[Range(0f, 4f)]
		public float duckTime;

		[Range(0f, 1f)]
		public float duckVolumeLevel;

		private IEnumerator duckCoroutine;

		private IEnumerator pushCoroutine;

		private float cashedBaseVolume;

		[SerializeField]
		public MusicAmbience2dSFX headSFX;

		[SerializeField]
		private Seat rearSeat;

		[SerializeField]
		private UnityEvent OnEngineStart;

		[SerializeField]
		private UnityEvent OnPlayerSeated;

		[SerializeField]
		private UnityEvent OnWhiteFlag;

		[SerializeField]
		private UnityEvent OnStopingStart;

		[SerializeField]
		private UnityEvent OnRideComplete;

		[SerializeField]
		private UnityEvent OnLoopComplete;

		[SerializeField]
		private UnityEvent OnDriveOff;

		public Grip[] gripsToDisable;

		private Rigidbody _frontLfRb;

		private Rigidbody _frontRtRb;

		private Rigidbody _backLfRb;

		private Rigidbody _backRtRb;

		private float _lastFrontLfPressure;

		private float _lastFrontRtPressure;

		private float _lastBackLfPressure;

		private float _lastBackRtPressure;

		private int loopCount;

		private int loopGoal;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public void UpdateSpeed(int setting)
		{
		}

		[ContextMenu("StartCreditsCoroutine")]
		public void StartCreditsCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CCreditsCoroutine_003Ed__91))]
		private IEnumerator CreditsCoroutine()
		{
			return null;
		}

		public void DisableTaxiGrips()
		{
		}

		public void StartPushTaxiRoutine()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitForPush_003Ed__94))]
		private IEnumerator CoWaitForPush()
		{
			return null;
		}

		public void SwapEngineSoundSimple(int i)
		{
		}

		public void SwapEngineSound(int i, float blendTime)
		{
		}

		[IteratorStateMachine(typeof(_003CEngineSoundCoroutine_003Ed__97))]
		private IEnumerator EngineSoundCoroutine(int i, float blendTime)
		{
			return null;
		}

		[ContextMenu("SeatRegistered")]
		private void SeatRegistered()
		{
		}

		[ContextMenu("Start Taxi Song")]
		public void StartTaxiSong()
		{
		}

		public void StartPushPromptsCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CPushPromptCoroutine_003Ed__101))]
		private IEnumerator PushPromptCoroutine()
		{
			return null;
		}

		public void KillPushPromptCoroutine()
		{
		}

		public void StartDuckMusicCoroutine(float length)
		{
		}

		[IteratorStateMachine(typeof(_003CDuckMusicCoroutine_003Ed__104))]
		private IEnumerator DuckMusicCoroutine(float length)
		{
			return null;
		}

		[ContextMenu("SeatDeRegistered")]
		private void SeatDeRegistered()
		{
		}

		public void SplineLoopCounter()
		{
		}

		public void DriveComplete()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitForStop_003Ed__110))]
		private IEnumerator CoWaitForStop()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoPlayerDist_003Ed__111))]
		private IEnumerator CoPlayerDist()
		{
			return null;
		}
	}
}
