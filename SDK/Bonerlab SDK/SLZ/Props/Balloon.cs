using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Props
{
	public class Balloon : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public enum BalloonColor
		{
			Red = 0,
			OrangeRed = 1,
			Orange = 2,
			YellowOrange = 3,
			Yellow = 4,
			GreenYellow = 5,
			Green = 6,
			BlueGreen = 7,
			Blue = 8,
			VioletBlue = 9,
			Violet = 10,
			RedViolet = 11,
			LightGray = 12,
			DarkGray = 13,
			Random = 14
		}

		[CompilerGenerated]
		private sealed class _003CCoWarmupAttach_003Ed__37
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Balloon _003C_003E4__this;

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
			public _003CCoWarmupAttach_003Ed__37(int _003C_003E1__state)
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

		private static ComponentCache<Balloon> _cache;

		[Header("Options")]
		public bool scaleForceWithAttachedMass;

		[Tooltip("Max Velocity After Impact")]
		public float maxVelocity;

		[Tooltip("Balloon's Up Force")]
		public float constantBuoyantForce;

		[Tooltip("Impact Force Before Popping")]
		public float maxImpactForce;

		[Header("References")]
		public ImpactSFX impactSFX;

		public Rigidbody myRigidbody;

		public ConfigurableJoint joint;

		public MeshRenderer artRenderer;

		public LineRenderer lineRenderer;

		public GameObject balloonArt;

		public Transform stringStartTransform;

		public Transform forceTargetTransform;

		private float sqrMaxVelocity;

		private float sqrMaxImpactForce;

		private float currentForce;

		private float scaledBuoyantForce;

		private float defaultDrag;

		private bool hasConnectedBody;

		private float _timeWhenSettled;

		private bool _isSettled;

		private bool isWarmingUp;

		private SimpleTransform sleepTransform;

		public static ComponentCache<Balloon> Cache => null;

		private void Reset()
		{
		}

		private void FreeJoint()
		{
		}

		public void AttachJoint(Rigidbody connectedBody, Vector3 impactPosition)
		{
		}

		private void TakeDamage()
		{
		}

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

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWarmupAttach_003Ed__37))]
		private IEnumerator CoWarmupAttach()
		{
			return null;
		}

		public static BalloonColor GetRandomColor()
		{
			return default(BalloonColor);
		}

		public static Color BalloonColorToRGB(BalloonColor balloonColorVar)
		{
			return default(Color);
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
