using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DoneTurretController : MonoBehaviour
	{
		[Header("References")]
		public Rigidbody turretRb;

		public TurretHeadController turret;

		public Transform targetTransform;

		public Transform firePointTransform;

		public SphereCollider playerTrigger;

		[Header("Turret Behavior")]
		public float agroRange;

		public float chargeTime;

		public float burstLength;

		public float fireRate;

		public float burstCoolDown;

		public bool clampAimRotation;

		public float minAimRotation;

		public float maxAimRotation;

		[Range(0f, 10f)]
		public float maxBulletSpread;

		[Range(0f, 10f)]
		public float minBulletSpread;

		[Header("Audio")]
		public AudioClip[] turretCharge;

		private float lastFireTime;

		private float burstLengthTime;

		private float coolDownLengthTime;

		private IEnumerator turretLoop;

		private IEnumerator fireSequence;

		private bool killMode;

		private Quaternion aimingQuat;

		private Vector3 aimingAxis;

		private float wrappedRotation;

		private Quaternion parentTiltRot;

		private float parentTiltAngle;

		private Vector3 parentTiltAxis;

		private float parentTiltDir;

		private float adjustedRotation;

		public void Start()
		{
		}

		[ContextMenu("Found Player")]
		public void FoundPlayer()
		{
		}

		public void LostPlayer()
		{
		}

		private IEnumerator TurretUpdateLoop()
		{
			return null;
		}

		private IEnumerator FireTurret()
		{
			return null;
		}

		public void KILLMODE(bool killOn)
		{
		}

		public DoneTurretController()
			: base()
		{
		}
	}
}
