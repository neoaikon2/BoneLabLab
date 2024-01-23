using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Props;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
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
		private sealed class _003CStart_003Ed__17
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
			public _003CStart_003Ed__17(int _003C_003E1__state)
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
		private sealed class _003CCoRandomPop_003Ed__20
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
			public _003CCoRandomPop_003Ed__20(int _003C_003E1__state)
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

		public global::SLZ.Props.Balloon.BalloonColor startColor;

		public GameObject popPrefab;

		public float maxVelocity;

		public float lifetime;

		public bool burstOnLifetimeEnd;

		public GameObject lifetimeEndParticlePrefab;

		public SoundPlayOneshot lifetimeEndSound;

		private float destructTime;

		private float releaseTime;

		public SoundPlayOneshot collisionSound;

		private float lastSoundTime;

		private float soundDelay;

		[SerializeField]
		private Rigidbody balloonRigidbody;

		private bool bParticlesSpawned;

		private static float s_flLastDeathSound;

		private bool isWarmup;

		[IteratorStateMachine(typeof(_003CStart_003Ed__17))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CCoRandomPop_003Ed__20))]
		private IEnumerator CoRandomPop()
		{
			return null;
		}

		private void Update()
		{
		}

		private void SpawnParticles(GameObject particlePrefab, SoundPlayOneshot sound)
		{
		}

		private void ApplyDamage()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void SetColor(global::SLZ.Props.Balloon.BalloonColor color)
		{
		}

		public static BalloonColor GetRandomColor()
		{
			return default(BalloonColor);
		}

		public static Color BalloonColorToRGB(global::SLZ.Props.Balloon.BalloonColor balloonColorVar)
		{
			return default(Color);
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
