using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Props
{
	[RequireComponent(typeof(Rigidbody))]
	public class CaseEject : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoColiderEnable_003Ed__15
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CaseEject _003C_003E4__this;

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
			public _003CCoColiderEnable_003Ed__15(int _003C_003E1__state)
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

		private static ComponentCache<CaseEject> _cache;

		public Rigidbody rb;

		public ShellSFX shellSfx;

		public float startSpeed;

		public float startAxisSpeed;

		private WaitForSeconds _wfs;

		private Vector3 localScale;

		public static ComponentCache<CaseEject> Cache => null;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void ForceInDirection(Vector3 startDirection, Vector3 startRotationAxis, Rigidbody hostRigidbody)
		{
		}

		public void OnDisable()
		{
		}

		public void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CCoColiderEnable_003Ed__15))]
		private IEnumerator CoColiderEnable()
		{
			return null;
		}
	}
}
