using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Bonelab;
using SLZ.Combat;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : Health
{
	public delegate void PlayerDeathImminent(bool isDying);

	public delegate void PlayerDeath();

	public delegate void PlayerDamageReceived(float damageAmount);

	[CompilerGenerated]
	private sealed class _003CCoBrightenDeathSave_003Ed__89
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player_Health _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CendTime_003E5__3;

		private float _003ClerpVal_003E5__4;

		private float _003CstartShut_003E5__5;

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
		public _003CCoBrightenDeathSave_003Ed__89(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoUpdateHealthUI_003Ed__90
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player_Health _003C_003E4__this;

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
		public _003CCoUpdateHealthUI_003Ed__90(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoFadeVignette_003Ed__91
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player_Health _003C_003E4__this;

		private float _003CinnerValue_003E5__2;

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
		public _003CCoFadeVignette_003Ed__91(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoFadeDeathVignette_003Ed__92
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player_Health _003C_003E4__this;

		public float deathTime;

		private float _003Cshuteye_003E5__2;

		private float _003Ctimer_003E5__3;

		private float _003CstartTime_003E5__4;

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
		public _003CCoFadeDeathVignette_003Ed__92(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoRegenHealth_003Ed__93
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitSeconds;

		public Player_Health _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private float _003CstartHealth_003E5__3;

		private float _003CgoalHealth_003E5__4;

		private float _003CstartTime_003E5__5;

		private float _003Cendtime_003E5__6;

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
		public _003CCoRegenHealth_003Ed__93(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoLowPassFilter_003Ed__94
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool enableLow;

		private float _003CstartTime_003E5__2;

		private float _003CendTime_003E5__3;

		private float _003ClerpVal_003E5__4;

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
		public _003CCoLowPassFilter_003Ed__94(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoWaitAndReloadScene_003Ed__97
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCoWaitAndReloadScene_003Ed__97(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoWaitAndGoToRespawn_003Ed__98
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player_Health _003C_003E4__this;

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
		public _003CCoWaitAndGoToRespawn_003Ed__98(int _003C_003E1__state)
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

	private static ComponentCache<Player_Health> _cache;

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

	[Space(5f)]
	[Header("REACTION")]
	[Tooltip("Threshold of damage to cause a reaction")]
	public float thr_React;

	private bool reacting;

	[Tooltip("Spawn hero props?")]
	public bool spawnHeroProps;

	public Transform[] spawn_points;

	[Tooltip("FX for death")]
	public GameObject fx_death;

	public SceneManager boneworks_SceneManager;

	public Control_GlobalTime globalTimeControl;

	[Header("Regen & Imminent Death")]
	[SerializeField]
	private bool visDebug;

	private bool slowMoOnDeath;

	public bool deathIsImminent;

	private bool regenerating;

	private bool isFadingVignette;

	[HideInInspector]
	public bool isInstaDying;

	[HideInInspector]
	public bool displayHealthFX;

	[Tooltip("Time until regen starts after hit")]
	public float wait_Regen_t;

	[Tooltip("Time in seconds to regnerate health from 0 - maxHealth")]
	[Range(0.05f, 15f)]
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

	private Coroutine deathRoutine;

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

	public static ComponentCache<Player_Health> Cache => null;

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

	private void OnDestroy()
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

	private void Update()
	{
	}

	private void ResetVigMaterial()
	{
	}

	public void SetFullHealth()
	{
	}

	public void ToggleHealthFX()
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

	[IteratorStateMachine(typeof(_003CCoBrightenDeathSave_003Ed__89))]
	private IEnumerator CoBrightenDeathSave()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoUpdateHealthUI_003Ed__90))]
	private IEnumerator CoUpdateHealthUI()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoFadeVignette_003Ed__91))]
	private IEnumerator CoFadeVignette()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoFadeDeathVignette_003Ed__92))]
	private IEnumerator CoFadeDeathVignette(float deathTime)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoRegenHealth_003Ed__93))]
	private IEnumerator CoRegenHealth(float waitSeconds)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoLowPassFilter_003Ed__94))]
	private IEnumerator CoLowPassFilter(bool enableLow)
	{
		return null;
	}

	public void Death()
	{
	}

	public void TELEPORTONESECOND()
	{
	}

	[IteratorStateMachine(typeof(_003CCoWaitAndReloadScene_003Ed__97))]
	private IEnumerator CoWaitAndReloadScene()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoWaitAndGoToRespawn_003Ed__98))]
	public IEnumerator CoWaitAndGoToRespawn()
	{
		return null;
	}

	public void Reaction(float damage)
	{
	}

	public void STARTDATA()
	{
	}
}
