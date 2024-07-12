using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using SLZ.SFX;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ChopperSequenceController_LongRun : MonoBehaviour
	{
		[Header("Animator")]
		public Animator animator;

		public GameObject chopper;

		public Rigidbody rotorRb;

		public Rigidbody tailRotorRb;

		public ConfigurableJoint mainJoint;

		public ConfigurableJoint rotorJoint;

		public ConfigurableJoint tailrotorJoint;

		public ObjectDestructible ObjectDestructible;

		public Transform rotorRayCaster;

		public GameObject rotorWahsObj;

		public ParticleSystem[] rotorWashParticles;

		public float rotorWashRange;

		public LayerMask layerMask;

		public float zeroRotorWashEmission;

		public float zeroRotorWashRadius;

		public ParticleSystem.MinMaxGradient zeroRotorWashAlpha;

		public float particleSmoothTime;

		public Transform windPoint;

		public float windForce;

		public ConfigurableJoint rampJoint;

		[SerializeField]
		private LayerMask layerFilter;

		private List<Rigidbody> filteredRBs;

		public PowerSource rotorDamagePower;

		public SimpleSFX kaxson;

		private bool hasWarningPlayed;

		[HideInInspector]
		public bool chopperDead;

		[Header("Turret")]
		public TurretHeadController turret;

		public Transform targetTransform;

		public TriggerRefProxy playerTRP;

		public Transform[] omniSpawnPos;

		public float fireCoolDown;

		[Header("Video")]
		public VideoURLSetter videoController;

		public float exitTimeOverride;

		[Header("Audio")]
		public AudioSource chopperAudioSource;

		public AudioLowPassFilter lpf;

		public AudioClip chopperFast;

		public AudioClip chopperSlow;

		private bool isSlowmoClip;

		public float volumeLerpTime;

		public float lowPassLerpTime;

		[Range(10f, 22000f)]
		public float cutoffFreqLow;

		[Range(10f, 22000f)]
		public float cutoffFreqHigh;

		[Header("AI")]
		[HideInInspector]
		public List<AgentLinkControl> omniAi;

		public bool omniRoam;

		private CancellationTokenSource lerpEnumerator;

		private float currentLerpVal;

		private float currentVolumeVal;

		private CancellationTokenSource targetPlayerCo;

		private static readonly int next;

		private static readonly int nextCaution;

		private float[] rotorWashEmissionCash;

		private float[] rotorWashRadiusCash;

		private Color[] rotorWashColorCash;

		private float rotorCastDist;

		private float currentRange;

		private float refVel;

		private float cashedMainDriveMaxForce;

		private float cashedMainSlerpDriveMaxForce;

		private static readonly int Speed;

		private CancellationTokenSource lerpBlend;

		private MarrowEntity agroEntity;

		private void Awake()
		{
		}

		public void STARTSEQUENCE(MarrowEntity entitiy)
		{
		}

		public void FADEIN()
		{
		}

		public void FADEOUT()
		{
		}

		public void STARTVIDEO()
		{
		}

		public void SPAWNOMNIS()
		{
		}

		public void AGROOMNIS()
		{
		}

		public void NEXTCAUTION()
		{
		}

		public void SECONDCAUTION()
		{
		}

		public void RAMPWINDBURST()
		{
		}

		private UniTaskVoid WindForceBurst()
		{
			return default(UniTaskVoid);
		}

		public void RAMPWIND()
		{
		}

		private UniTaskVoid WindForce()
		{
			return default(UniTaskVoid);
		}

		public void ENDSEQUENCE()
		{
		}

		public void AddAgent(AgentLinkControl agent)
		{
		}

		private void Start()
		{
		}

		private UniTaskVoid VideoTimmer()
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid LerpBlend(float fromCutoff, float toCutoff, float fromVol, float toVol, CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid TargetPlayer(CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid SpawnOmnis()
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid RotorPowerUpdate()
		{
			return default(UniTaskVoid);
		}

		public void ReceiveCollision(Collision collision)
		{
		}

		public void CHOPPERKILLED()
		{
		}

		private void Update()
		{
		}

		public ChopperSequenceController_LongRun()
			: base()
		{
		}
	}
}
