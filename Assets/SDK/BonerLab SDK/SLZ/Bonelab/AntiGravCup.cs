using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AntiGravCup : MonoBehaviour
	{
		[Header("Options")]
		public bool antiGravity;

		public float radius;

		public Vector3 halfExtents;

		public LayerMask effectedLayers;

		[Header("References")]
		public Grip triggerGrip;

		public Grip secondaryTriggerGrip;

		public Transform cupSurfaceTransform;

		private Collider[] colliders;

		private Rigidbody rb;

		private MarrowJoint joint;

		private GravGunSFX _sfx;

		private Coroutine _kinematic;

		private bool _triggerHeld;

		private bool _toggleGrab;

		private bool _blockRegrab;

		private bool _rbMounted;

		private Poolee _poolee;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnRelease(GameObject despawnedObject)
		{
		}

		private void Update()
		{
		}

		private void OneHandedUpdate()
		{
		}

		private void TwoHandedUpdate()
		{
		}

		private void CheckForAttachment()
		{
		}

		private void AttachJoint(Rigidbody connectedBody, Vector3 impactPosition)
		{
		}
		private IEnumerator KinematicSet()
		{
			return null;
		}
	}
}
