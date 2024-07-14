using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using SLZ.Marrow.PuppetMasta;
using SLZ.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SLZ.Bonelab
{
	public class Player_Health : Health
	{
		public delegate void PlayerDeathImminent(bool isDying);

		public delegate void PlayerDeath();

		public delegate void PlayerDamageReceived(float damageAmount);
		public bool reloadLevelOnDeath;

		[Space(2f)]
		[Header("IMPACT")]
		[Tooltip("Can be damaged by physical impacts")]
		public bool damageFromImpact;

		[Tooltip("Modifier multiplier to collision")]
		public float mod_Impact;

		[Tooltip("Threshold of impact magnitude required to damage")]
		public float thr_Impact;

		[Tooltip("Can this use a mask to ignore damage")]
		public bool useMask;

		[Tooltip("Layer to Minimal Hit")]
		public LayerMask msk_Impact;

		[Tooltip("Amount of Minimal Mod")]
		public float mod_Minimal;

		[Tooltip("Spawnable hero props")]
		public GameObject[] prop_Hero;

		[Tooltip("Spawn hero props?")]
		public bool spawnHeroProps;

		public Transform[] spawn_points;

		[Tooltip("FX for death")]
		public GameObject fx_death;

		public SceneManager boneworks_SceneManager;

		[Header("Regen & Imminent Death")]
		[SerializeField]
		private bool visDebug;

		private bool slowMoOnDeath;

		private bool regenerating;

		private bool isFadingVignette;

		[HideInInspector]
		public bool isInstaDying;

		[Tooltip("Time until regen starts after hit")]
		public float wait_Regen_t;

		[Range(0.05f, 15f)]
		[Tooltip("Time in seconds to regnerate health from 0 - maxHealth")]
		public float totalRegenDuration;

		private float currentHealthRegenDuration;

		[Tooltip("Time player has (in seconds) to score damage after health reaches 0, if no attack is scored player dies")]
		public float deathTimeAmount;

		private float currDeathTime;

		[Tooltip("Time player has (in seconds) before instant death")]
		public float instaDeathTimeAmount;

		[Tooltip("Once player reached death state any additional hits will reduce deathTime left by this amount in seconds")]
		public float deathTimeReduction;

		private float routineTickRate;

		public AnimationCurve shutEyeCurve;

		private Coroutine vignetteRoutine;

		private Coroutine regenRoutine;

		private Coroutine lowPassAudioRoutine;

		public Color darkRed;

		public Color brightRed;

		private float highLPF;

		private float lowLPF;

		private float currLPF;

		public int playerDamageScore;

		public int playerDeathSaves;

		[Header("VisDebug Canvas")]
		public GameObject healthCanvasPrefab;

		public Transform uiTarget;

		public PlayerHealthCanvas healthCanvas;

		private Vector3 canvasOffset;

		private MaterialPropertyBlock matPropBlock;

		public GameObject Vignetter;

		private SkinnedMeshRenderer vigRend;

		private int shutEyesID;

		private int brightenID;

		private int innerID;

		private int outerID;

		private int colorID;

		public static event PlayerDeathImminent OnDeathImminent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event PlayerDeath OnPlayerDeath
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event PlayerDamageReceived OnPlayerDamageReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		public void MakeVignette()
		{
		}

		private void CreateHealthCanvas()
		{
		}

		private void Start()
		{
		}

		public void ToggleInstantDeathMode(bool toggleOn)
		{
		}

		public void OnPuppetDeath(PuppetMaster puppet)
		{
		}

		public override void OnReceivedDamage(Attack attack, PlayerDamageReceiver.BodyPart part)
		{
		}

		[ContextMenu("LfeSavingDamageDealt")]
		public void LifeSavingDamgeDealt()
		{
		}

		private void ResetVigMaterial()
		{
		}

		public void UpdateHealth(float perc)
		{
		}

		public override void SetFullHealth()
		{
		}

		private void PlayerDamageScore(float damage)
		{
		}

		public override void TAKEDAMAGE(float damage)
		{
		}

		[ContextMenu("Apply kill damage")]
		public void ApplyKillDamage()
		{
		}

		public void ShowHealthInstaDeathMode()
		{
		}

		public void StartHealthRegnerationAndVignette(float regenWait)
		{
		}
		private IEnumerator CoBrightenDeathSave()
		{
			return null;
		}
		private IEnumerator CoUpdateHealthUI()
		{
			return null;
		}
		private IEnumerator CoFadeVignette()
		{
			return null;
		}
		private IEnumerator CoFadeDeathVignette(float deathTime)
		{
			return null;
		}
		private IEnumerator CoRegenHealth(float waitSeconds)
		{
			return null;
		}
		private IEnumerator CoLowPassFilter(bool enableLow)
		{
			return null;
		}

		public override void Dying(float damage)
		{
		}

		public override void Death()
		{
		}

		public void TELEPORTONESECOND()
		{
		}
		private IEnumerator CoWaitAndReloadScene()
		{
			return null;
		}
		public IEnumerator CoWaitAndGoToRespawn()
		{
			return null;
		}

		public void STARTDATA()
		{
		}
	}
}
