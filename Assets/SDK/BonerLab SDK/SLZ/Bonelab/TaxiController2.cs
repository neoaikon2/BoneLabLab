using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class TaxiController2 : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCreditsCoroutine_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CCreditsCoroutine_003Ed__92(int _003C_003E1__state)
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

			public void Dispose()
			{
				throw new NotImplementedException();
			}

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWaitForPush_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CCoWaitForPush_003Ed__95(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CEngineSoundCoroutine_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CEngineSoundCoroutine_003Ed__98(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CPushPromptCoroutine_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CPushPromptCoroutine_003Ed__102(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CDuckMusicCoroutine_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CDuckMusicCoroutine_003Ed__105(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWaitForStop_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CCoWaitForStop_003Ed__111(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoPlayerDist_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaxiController2 _003C_003E4__this;

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

			public object Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CCoPlayerDist_003Ed__113(int _003C_003E1__state)
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

			bool IEnumerator.MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
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
		private Rigidbody carBody;

		private ConfigurableJoint _steeringHinge;

		[InspectorDisplayName("Target Velocity")]
		[Header("Off  -  0")]
		public float velocity_off;

		[InspectorDisplayName("Position Damper")]
		public float damper_off;

		[InspectorDisplayName("Maximum Force")]
		public float force_off;

		[InspectorDisplayName("Target Velocity")]
		[Header("Idle  -  1")]
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

		public Transform engineTransform;

		public Transform cabMusicTransform;

		public Transform doorTransform;

		private ManagedAudioPlayer engineSource1;

		private ManagedAudioPlayer engineSource2;

		private ManagedAudioPlayer cabMusicSource;

		private IEnumerator engineCoroutine;

		private bool engineSource1UsedLast;

		[SerializeField]
		private AudioClip honkClip;

		[SerializeField]
		private AudioClip fenceMusic;

		public AnimationCurve duckCurve;

		[Range(0f, 4f)]
		public float duckTime;

		[Range(0f, 1f)]
		public float duckVolumeLevel;

		private IEnumerator duckCoroutine;

		private IEnumerator pushCoroutine;

		private float cashedBaseVolume;

		public AudioReverbData voidReverbData;

		public AudioReverbData cabReverbData;

		public MeshRenderer[] toggleObjects;

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

		private bool _exitedCab;

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

		[IteratorStateMachine(typeof(_003CCreditsCoroutine_003Ed__92))]
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

		[IteratorStateMachine(typeof(_003CCoWaitForPush_003Ed__95))]
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

		[IteratorStateMachine(typeof(_003CEngineSoundCoroutine_003Ed__98))]
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

		[IteratorStateMachine(typeof(_003CPushPromptCoroutine_003Ed__102))]
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

		[IteratorStateMachine(typeof(_003CDuckMusicCoroutine_003Ed__105))]
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

		[IteratorStateMachine(typeof(_003CCoWaitForStop_003Ed__111))]
		private IEnumerator CoWaitForStop()
		{
			return null;
		}

		public void PlayerExitedCab()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPlayerDist_003Ed__113))]
		private IEnumerator CoPlayerDist()
		{
			return null;
		}
	}
}
