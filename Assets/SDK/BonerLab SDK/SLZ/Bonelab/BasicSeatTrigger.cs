using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BasicSeatTrigger : MonoBehaviour
	{
		private RigManager rM;

		public Seat seat;

		public Rigidbody rb;

		public ConfigurableJoint jnt;

		public Transform statTransform;

		public Transform endTransform;

		public float seatingLength;

		public float yoinkLength;

		public AnimationCurve lerpSpeedCurve;

		public AudioClip[] startSFX;

		public AudioClip[] endSFX;

		public LayerMask castLayers;

		public float initialGravityPulse;

		public float initialRandomTorque;

		public float velocityMultiplier;

		private bool isSeated;

		private bool endSound;

		private IEnumerator yoinkCoroutine;

		private List<Rigidbody> rigidbodies;

		private void Start()
		{
		}

		private void Intialize()
		{
		}

		public void EnterSeat()
		{
		}

		public void Yoink()
		{
		}
		private IEnumerator YoinkCoroutine()
		{
			return null;
		}

		private void GatherRBs()
		{
		}

		private void NullRBGravity()
		{
		}

		private void UpdateRBVelocity(float velocity)
		{
		}
	}
}
