using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.AI;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using SLZ.VFX;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class NPC_Objective : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public enum TowerMode
		{
			CHARGING = 0,
			DRAINING = 1,
			NONE = 2
		}
		public TowerMode towerMode;

		[SerializeField]
		private float energy;

		[SerializeField]
		private float initEnergy;

		public bool isEmpty;

		public bool isFull;

		private float chargeDelta;

		[SerializeField]
		private float energyPerc;

		[SerializeField]
		private GameObject energyBarObj;

		[SerializeField]
		private GameObject batteryBarObj;

		private Vector3 currScale;

		private Vector3 startBar;

		[SerializeField]
		private Vector3 endBar;

		public Action<NPC_Objective> OnObjectiveKeyed;

		public Action<NPC_Objective> OnObjectiveDestroyed;

		public Action<NPC_Objective> OnObjectiveCharged;

		public TriggerRefProxy proxy;

		public List<NPC_Data> npcList;

		public HashSet<NPC_Data> npcHash;

		[SerializeField]
		private ShockTrap shockTrap;

		[SerializeField]
		private float fireMult;

		[SerializeField]
		private float bluntMult;

		[Header("Events")]
		public UnityEvent ObjectiveModeStart;

		public UnityEvent OnDamageRec;

		public UnityEvent OnFullCharge;

		[SerializeField]
		[Header("Key")]
		private bool isKeyRequired;

		[SerializeField]
		private bool isKeyed;

		public KeyReceiver keyReceiver;

		[SerializeField]
		private Key batteryKey;

		[SerializeField]
		private ObjectiveBattery battery;

		public int tankIndex;

		[Header("Audio")]
		private ManagedAudioPlayer loopingASource;

		private IEnumerator loopingACoroutine;

		private bool _fadeActive;

		private bool loopingACanPlay;

		public float loopingAVolume;

		[SerializeField]
		private AudioClip loopingAClip;

		[SerializeField]
		private AudioClip explodeClip;

		[SerializeField]
		private AudioClip fullChargeClip;

		[SerializeField]
		private AudioClip[] damageClips;

		[SerializeField]
		private AudioClip batterySpawnClip;

		[SerializeField]
		private AudioClip batteryAlarmClip;

		[Header("VFX")]
		[SerializeField]
		private Spawnable blasterVoid;

		[SerializeField]
		private Spawnable blasterLightning;

		[SerializeField]
		private Spawnable blasterLightningNeg;

		[SerializeField]
		private Spawnable fizzler;

		public MeshFilter[] fizzlerMeshFilters;

		public MeshRenderer[] fizzlerMeshRenderer;

		[SerializeField]
		private LineRenderer lineRend;

		public DrawLine2Points drawPoints;

		[Header("UI")]
		[SerializeField]
		private TMP_Text energyText;

		[Header("DoorJoints")]
		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private Vector3 jointTarg;

		[Header("MagmaGate")]
		public Renderer towerRend;

		private MaterialPropertyBlock matPropBlock;

		private int emisColorID;

		public Color emissionColor;

		public float maxColorIntensity;

		private Coroutine laserRoutine;

		[SerializeField]
		private GameObject laserScalerParent;

		[SerializeField]
		private float maxLaserScale;

		[SerializeField]
		private float laserScaleTime;

		private float currIntensity;

		[SerializeField]
		private LightningStriker striker;

		[Header("ContainerYard")]
		[SerializeField]
		private GameObject puddleScalerObj;

		private Vector3 startPuddleScale;

		[SerializeField]
		private GameObject[] puddleFXObjs;

		[SerializeField]
		private GameObject explodeSphereObj;

		private float explosionForce;

		private float explosionRadius;

		private float expandDuration;

		public TweenParticleEmission particleHealth;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		[ContextMenu("TestAttack10")]
		public void TestAttack10()
		{
		}

		[ContextMenu("TestAttack100")]
		public void TestAttack100()
		{
		}

		private void UpdateDamage(Attack attack)
		{
		}

		private void Update()
		{
		}

		private void ChargeTick()
		{
		}

		private void DrainTick()
		{
		}

		private void ObjectiveDeath()
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}

		public void KeyRecieved(Key key)
		{
		}

		public void KeyRemoved()
		{
		}

		private void FullCharge()
		{
		}

		[ContextMenu("ExplodeCharger")]
		public void ExplodeCharger()
		{
		}
		private IEnumerator CoExploder()
		{
			return null;
		}

		[ContextMenu("FullChargeExplosion")]
		public void FullChargeExplosion()
		{
		}

		[ContextMenu("TEST_FX")]
		public void TestFX()
		{
		}

		[ContextMenu("ToggleJoint")]
		public void ToggleJoint()
		{
		}

		[ContextMenu("FadePumpEmission")]
		private void FadePumpEmission()
		{
		}
		private IEnumerator CoFadePumpEmission()
		{
			return null;
		}

		public void EnterAudioArea(bool enter = true)
		{
		}
		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}

		public void LightStrike()
		{
		}

		private void UpdateEmission()
		{
		}

		public void DefenseComplete()
		{
		}
		private IEnumerator CoFadeEmission()
		{
			return null;
		}

		private void LaserBlast()
		{
		}
		private IEnumerator CoLaser()
		{
			return null;
		}
	}
}
