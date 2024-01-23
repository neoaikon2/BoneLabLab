using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ
{
	public class ChopperTurretController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTurretUpdateLoop_003Ed__39
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChopperTurretController _003C_003E4__this;

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
			public _003CTurretUpdateLoop_003Ed__39(int _003C_003E1__state)
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
		private sealed class _003CFireTurret_003Ed__40
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChopperTurretController _003C_003E4__this;

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
			public _003CFireTurret_003Ed__40(int _003C_003E1__state)
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

		[Header("References")]
		public Rigidbody turretRb;

		public SplineJoint splineJoint;

		public TurretHeadController turret;

		public ConfigurableJoint blades;

		public Transform targetTransform;

		public Transform firePointTransform;

		public SphereCollider playerTrigger;

		[Header("Chopper Behavior (Speed/Damper/MaxForce)")]
		public Vector3 fastDriveSettings;

		public Vector3 slowDriveSettings;

		public float speedTransitionTime;

		[Header("Turret Behavior")]
		public float agroRange;

		public float chargeTime;

		public float burstLength;

		public float fireRate;

		public float burstCoolDown;

		[Range(0f, 10f)]
		public float maxBulletSpread;

		[Range(0f, 10f)]
		public float minBulletSpread;

		[Header("Audio")]
		public AudioMixerGroup outputMixer;

		public AudioClip[] turretCharge;

		public AudioSource chopperAudioSource;

		public AudioClip chopperFast;

		public AudioClip chopperSlow;

		private bool isSlowmoClip;

		private float lastFireTime;

		private float burstLengthTime;

		private float coolDownLengthTime;

		private IEnumerator turretLoop;

		private IEnumerator fireSequence;

		private bool killMode;

		private Vector3 jointDriveCurrent;

		private Vector3 jointDriveTarget;

		private Vector3 jointDriveVel;

		private bool chopperDestroyed;

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void FoundPlayer()
		{
		}

		public void LostPlayer()
		{
		}

		public void PlayerDeath()
		{
		}

		[IteratorStateMachine(typeof(_003CTurretUpdateLoop_003Ed__39))]
		private IEnumerator TurretUpdateLoop()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFireTurret_003Ed__40))]
		private IEnumerator FireTurret()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		public void KILLMODE(bool killOn)
		{
		}

		public void DestructChopper()
		{
		}
	}
}
