using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Props;
using SLZ.SFX;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class ProjectileBalloon : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[CompilerGenerated]
		private sealed class _003CCoDelayFire_003Ed__35
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProjectileBalloon _003C_003E4__this;

			public Vector3 position;

			public Vector3 forward;

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
			public _003CCoDelayFire_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass36_0
		{
			public ProjectileBalloon _003C_003E4__this;

			public float timeScale;

			public float pitchMult;

			internal void _003CCoWarmupAttach_003Eb__0(GameObject go)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWarmupAttach_003Ed__36
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProjectileBalloon _003C_003E4__this;

			private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

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
			public _003CCoWarmupAttach_003Ed__36(int _003C_003E1__state)
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

		private static ComponentCache<ProjectileBalloon> _cache;

		[Header("Options")]
		public LayerMask collisionLayers;

		[Tooltip("Effective Range of Raycast")]
		public float effectiveRange;

		[Tooltip("Max Velocity After Impact")]
		public float maxVelocity;

		[Tooltip("Balloon's Up Force")]
		public float constantBuoyantForce;

		[Tooltip("Impact Force Before Popping")]
		public float maxImpactForce;

		[Header("References")]
		public Spawnable balloonPopVfxSpawnable;

		public GameObject[] balloonArt;

		public Transform stringStartTransform;

		public Transform forceTargetTransform;

		public AudioMixerGroup outputMixer;

		public AudioClip[] inflateSFX;

		private AudioPlayer ap;

		private float sqrMaxVelocity;

		private float sqrMaxImpactForce;

		private ConfigurableJoint joint;

		private MeshRenderer[] artRenderer;

		private LineRenderer lineRenderer;

		private Rigidbody rb;

		private ImpactSFX impactSFX;

		private float _scaledBuoyantForce;

		private float defaultDrag;

		private bool hasConnectedBody;

		private bool isWarmingUp;

		private static float s_flLastDeathSound;

		public static ComponentCache<ProjectileBalloon> Cache => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void FreeJoint()
		{
		}

		private void AttachJoint(Rigidbody connectedBody, Vector3 impactPosition)
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayFire_003Ed__35))]
		private IEnumerator CoDelayFire(Vector3 position, Vector3 forward)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoWarmupAttach_003Ed__36))]
		private IEnumerator CoWarmupAttach()
		{
			return null;
		}

		private void TakeDamage()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void SetColor(Balloon.BalloonColor color)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
