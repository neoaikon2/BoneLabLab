using System;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Combat
{
	public class BluntWeapon : MonoBehaviour
	{
		[Serializable]
		public class BluntHotSpot
		{
			public InteractableHost m_Host;

			public Transform pointTran;

			public Collider pointCollider;

			[Tooltip("Area in millimeters squared of the tip")]
			[Range(0f, 1000f)]
			public float sharpness;

			public float damage;

			[HideInInspector]
			public InteractableHost _host;

			[HideInInspector]
			public Rigidbody rb => null;
		}

		public AudioMixerGroup outputMixer;

		public Transform sourceTran;

		public AudioClip[] hiltImpactSoft;

		public AudioClip[] hiltImpactHard;

		public AudioClip[] bladeImpactSoft;

		public AudioClip[] bladeImpactHard;

		public AudioClip[] fleshCut;

		public AudioClip[] cardboardCut;

		public AudioClip[] woodCut;

		public AudioClip[] metalCut;

		public Transform whooshTran;

		public AudioClip whooshLoop;

		public Collider[] hiltColliders;

		public float bluntDamageMult;

		public float nativeImpactVelocity;

		public float impactVelocityThresh;

		public float cutAccelThresh;

		private AudioSource source;

		private InteractableHost _host;

		private bool isWhooshing;

		private const float _lowPitchRange = 0.8f;

		private const float _highPitchRange = 1.2f;

		private const float _velToVol = 0.25f;

		private float _minVelSquared;

		private float _cooldownTime;

		public BluntHotSpot[] bluntHotSpots;

		public bool cooling => false;

		private Rigidbody rb => null;

		public void Initialize(Transform tran)
		{
		}

		public void CutEvent(Vector3 worldPos, float velocity, float accel, ImpactPropertiesVariables.Material iP)
		{
		}

		public void Whoosh(float velocitySqr)
		{
		}

		public void CollisionEnterSfx(Collision c, ImpactProperties iP, Rigidbody rb)
		{
		}

		public void CollisionStaySfx(Collision c)
		{
		}

		private void ProcessCollision(Collision c, bool isStay = false)
		{
		}

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}
	}
}
