using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Cart : MonoBehaviour
	{
		[Header("Options")]
		public float maxSpeed;

		public float acceleration;

		public float launchReturnSeconds;

		public AudioClip launchClip;

		public AudioClip startClip;

		public AudioClip stopClip;

		[Tooltip("this determines what happens when reEnabled after it was disabled during it's motion.  isLauncher, tells it to GoBackward, Not isLauncher tells it to continue in the direction it was going.")]
		public bool isLauncher;

		public float launchDelay;

		public Renderer[] renderers;

		public int materialIndex;

		public Material offMat;

		public Material onMat;

		[Tooltip("end transform must be sibling of cart for setup to work correctly.")]
		[Header("References")]
		public Transform endTransform;

		[Header("After moving end transform, click Setup in the context menu")]
		public ConfigurableJoint joint;

		public Rigidbody rb;

		public Rigidbody kinematicRB;

		private Coroutine _moveCoroutine;

		[ReadOnly(false)]
		[SerializeField]
		private float _lastDirection;

		[ReadOnly(false)]
		[SerializeField]
		private float _distance;

		[ReadOnly(false)]
		[SerializeField]
		private float _halfDistance;

		[SerializeField]
		[ReadOnly(false)]
		private float _linearTargetPosition;

		[ReadOnly(false)]
		[SerializeField]
		private SoftJointLimit limit;

		private float _velocity;

		public UnityEvent StopAction;

		private bool _isLaunchCancelable;

		public void Reset()
		{
		}

		[ContextMenu("Setup")]
		private void Setup()
		{
		}

		private void OnEnable()
		{
		}
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

		public void DelayedLaunch()
		{
		}

		public void CancelLaunch()
		{
		}
		public IEnumerator CoLaunchDelayed()
		{
			return null;
		}

		[ContextMenu("Launch")]
		public void Launch()
		{
		}
		public IEnumerator CoLaunch()
		{
			return null;
		}

		private bool AlreadyAtTarget(float direction)
		{
			return false;
		}
	}
}
