using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Vehicle;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class mineCartGunControl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMoveGun_003Ed__35
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public mineCartGunControl _003C_003E4__this;

			public bool isRising;

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
			public _003CMoveGun_003Ed__35(int _003C_003E1__state)
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

		[InspectorDisplayName("Slider Joint Translation")]
		[Tooltip("Joint for raising arm")]
		public ConfigurableJoint cj_translate;

		[InspectorDisplayName("Arm Joint Rotation")]
		[Tooltip("Joint for rotating arm")]
		public ConfigurableJoint cj_rotate;

		[Tooltip("Joint for rotating gun")]
		[InspectorDisplayName("Gun Joint Rotation")]
		public ConfigurableJoint cj_gun;

		[InspectorDisplayName("Servo Script")]
		[Tooltip("Servo script goes here")]
		public Servo servo;

		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		public Rigidbody rigidbody_translate;

		public Rigidbody rigidbody_gun;

		public Rigidbody rigidbody_mineCart;

		public GameObject laser;

		public Animator animator;

		public float upAngleLock;

		public float downAngleLock;

		public float translateUpValue;

		public float translateDownValue;

		private bool _lockableState;

		private Vector3 _startPosition;

		private Quaternion _startRotation;

		private Quaternion _upRotation;

		private Quaternion _hiddenRotation;

		private float _lockUpValue;

		private float _lockDownValue;

		private ConfigurableJoint _lockJoint;

		private Vector3 _gunAnchor;

		private int _slideExtendHash;

		private int _slideRetractHash;

		public Grip[] grips;

		public void Reset()
		{
		}

		private void Start()
		{
		}

		private bool CheckRotationCompletion()
		{
			return false;
		}

		private bool CheckTranslationCompletion()
		{
			return false;
		}

		private void LockGunRotation()
		{
		}

		private void LockGunTranslation()
		{
		}

		private void LockGun()
		{
		}

		private void ReleaseGun()
		{
		}

		private void SetJoint(ConfigurableJoint joint)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveGun_003Ed__35))]
		private IEnumerator MoveGun(bool isRising)
		{
			return null;
		}

		private void TranslateGun(bool isRising)
		{
		}

		private void RotateGun(bool isRising)
		{
		}

		[ContextMenu("Raise Gun")]
		public void RAISEGUN()
		{
		}

		[ContextMenu("Hide Gun")]
		public void HIDEGUN()
		{
		}
	}
}
