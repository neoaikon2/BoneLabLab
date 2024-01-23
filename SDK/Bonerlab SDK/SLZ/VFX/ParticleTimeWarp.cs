using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleTimeWarp : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CupdateTrails_003Ed__8
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ParticleTimeWarp _003C_003E4__this;

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
			public _003CupdateTrails_003Ed__8(int _003C_003E1__state)
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

		[SerializeField]
		private float TrailMotionBlurFrames;

		[SerializeField]
		private float MaxParticleLifetime;

		[SerializeField]
		private ParticleSystem PS;

		[SerializeField]
		private ParticleSystem.TrailModule trails;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void updateTrail()
		{
		}

		[IteratorStateMachine(typeof(_003CupdateTrails_003Ed__8))]
		private IEnumerator updateTrails()
		{
			return null;
		}
	}
}
