using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Interaction
{
	public class PowerPuncher : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPopAnim_003Ed__25
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PowerPuncher _003C_003E4__this;

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
			public _003CPopAnim_003Ed__25(int _003C_003E1__state)
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

		private static ComponentCache<PowerPuncher> _cache;

		public GravGunSFX sfx;

		public Grip triggerGrip;

		public Vector3 forward;

		public GameObject[] body;

		public GameObject icon;

		public ParticleSystem blastParticles;

		public ParticleSystem[] chargeParticles;

		private Material[] bodyMat;

		private Material iconMat;

		private Color bodyEmissionColor;

		private bool popAnimPlaying;

		private bool chargeParticlesPlaying;

		private float lastEmissionValue;

		private float _triggerStartTime;

		private float _cooldownStartTime;

		public static ComponentCache<PowerPuncher> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnAttachedUpdate(Hand hand)
		{
		}

		private void UpdateBodyEmission(float lerp)
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void UpdateUI(int i)
		{
		}

		[IteratorStateMachine(typeof(_003CPopAnim_003Ed__25))]
		private IEnumerator PopAnim()
		{
			return null;
		}

		public void OnCollisionEnter(Collision collision)
		{
		}
	}
}
