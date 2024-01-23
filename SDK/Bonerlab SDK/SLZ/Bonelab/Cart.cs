using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Cart : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoMoveTargetTransform_003Ed__27
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cart _003C_003E4__this;

			public float direction;

			private WaitForFixedUpdate _003CfixedUpdate_003E5__2;

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
			public _003CCoMoveTargetTransform_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CCoLaunch_003Ed__33
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cart _003C_003E4__this;

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
			public _003CCoLaunch_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CCoMoveGate_003Ed__34
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CCoMoveGate_003Ed__34(int _003C_003E1__state)
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

		[Header("Options")]
		public float maxSpeed;

		public float acceleration;

		public float launchReturnSeconds;

		public Vector3 gateEndPoint;

		public AudioClip launchClip;

		public AudioClip startClip;

		public AudioClip stopClip;

		public AudioMixerGroup mixergroup;

		[Header("References")]
		public Transform gateTransform;

		public Transform endTransform;

		public ConfigurableJoint joint;

		public Rigidbody rb;

		private Coroutine _gateCoroutine;

		private Coroutine _moveCoroutine;

		private Quaternion _startRotation;

		private Vector3 _gateStartPoint;

		private float _lastDirection;

		private float _speed;

		private float _distance;

		private float _halfDistance;

		private float _linearTargetPosition;

		private float _velocity;

		private float _gatePerc;

		public UnityEvent StopAction;

		public void Reset()
		{
		}

		public void Awake()
		{
		}

		public void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveTargetTransform_003Ed__27))]
		public IEnumerator CoMoveTargetTransform(float direction)
		{
			return null;
		}

		public void Drop()
		{
		}

		public void GoForward()
		{
		}

		public void GoBackward()
		{
		}

		public void Go()
		{
		}

		public void Launch()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaunch_003Ed__33))]
		public IEnumerator CoLaunch()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoMoveGate_003Ed__34))]
		public IEnumerator CoMoveGate(float direction)
		{
			return null;
		}

		private bool AlreadyAtTarget(float direction)
		{
			return false;
		}
	}
}
