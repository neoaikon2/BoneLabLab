using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class PowerPuncher : MonoBehaviour
	{
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

		[SerializeField]
		private CollisionCollector _collisionCollector;

		private InteractableHost _host;

		private bool _fixedRan;

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
		private IEnumerator PopAnim()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		public void OnSignificantCollisionEnter(CollisionCollector.RelevantCollision collision)
		{
		}
	}
}
