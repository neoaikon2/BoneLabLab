using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class BaseGameController : MonoBehaviour
	{
		public enum GameMode
		{
			LINEAR = 0,
			ARENA = 1,
			TIME_TRIAL = 2
		}

		public enum TimerMode
		{
			COUNT_UP = 0,
			COUNT_DOWN = 1,
			REALTIME = 2,
			COUNT_UP_REALTIME = 3
		}

		public enum EndMode
		{
			LOAD_NEXT = 0,
			RELOAD_CURRENT = 1,
			NONE = 2,
			EXPLICIT = 3
		}

		public enum DebugMode
		{
			VERBOSE = 0,
			MINIMAL = 1,
			NONE = 2
		}
		public string LevelKey;

		public GameMode gameMode;

		public TimerMode timerMode;

		public EndMode endMode;

		public DebugMode debugMode;

		[SerializeField]
		private LevelCrateReference explicitSceneCrate;

		protected bool isSessionOngoing;

		[SerializeField]
		[Header("Time Data")]
		private float timerValue;

		[SerializeField]
		protected TimeSpan tsTimerValue;

		[SerializeField]
		public string tsTimerString;

		[SerializeField]
		private float maxTime;

		[SerializeField]
		private float defaultMaxTime;

		[SerializeField]
		public bool isSlowTime;

		[SerializeField]
		private float delayedMaxTime;

		[SerializeField]
		private float defaultDelayedMaxTime;

		[SerializeField]
		private float delayedEndMaxTime;

		[SerializeField]
		private float defaultEndDelayedMaxTime;

		[Header("Stats")]
		[SerializeField]
		public int score;

		[SerializeField]
		public int enemiesKilled;

		[SerializeField]
		public int totalEnemiesKilled;

		[SerializeField]
		public int activeEnemyCount;

		[SerializeField]
		public int maxDeadDespawnLimit;

		[SerializeField]
		public int activeFriendlyCount;

		[SerializeField]
		public int friendlyRespawnAmount;

		public RigManager rigManager;

		public GameObject playerObject;

		public TriggerRefProxy playerProxy;

		public List<TMP_Text> modeTexts;

		public List<TMP_Text> timerTexts;

		public List<TMP_Text> aliveTexts;

		public List<TMP_Text> aliveFriendsTexts;

		public List<TMP_Text> killsTexts;

		public List<TMP_Text> totalKillsTexts;

		public List<TMP_Text> totalEnemiesTexts;

		public List<TMP_Text> collectiblesTotalTexts;

		public List<TMP_Text> collectiblesFoundTexts;

		private Coroutine timerRoutine;

		[Tooltip("Assuming all zones are the child of a single transform, will be used to grab all zone refs")]
		[SerializeField]
		private GameObject zoneParentObj;

		public List<Zone> zoneList;

		public List<ZoneDisplayEditor> zoneDisplayList;

		public Dictionary<Zone, ZoneDisplayEditor> zoneNPCLookup;

		public List<GameObject> nothingGOList;

		public List<ProfileSpawner> profileSpawnerList;

		public List<CrateSpawner> crateSpawnerList;

		[SerializeField]
		public ProfileSpawner safetyZoneSpawner;

		protected List<ProfileSpawner> removeSpawnerList;

		[HideInInspector]
		public bool isTrackingEnemies;

		[SerializeField]
		private bool isAutoDespawn;

		[SerializeField]
		private float despawnDelay;

		[SerializeField]
		[Tooltip("A list of all npcs that have been spawned since session began")]
		protected List<AIBrain> NPC_List;

		[Tooltip("A list of all living enemy NPC's")]
		[SerializeField]
		protected List<AIBrain> Alive_Enemy_List;

		[SerializeField]
		[Tooltip("A list of all dead enemy NPC's")]
		protected List<AIBrain> Dead_Enemy_List;

		[SerializeField]
		[Tooltip("A list of all the friendly npcs")]
		protected List<AIBrain> FriendlyNPC_List;

		[SerializeField]
		[Tooltip("A list of all living enemy NPC's")]
		protected List<AIBrain> Alive_Friendly_List;

		[SerializeField]
		[Tooltip("A list of all dead enemy NPC's")]
		protected List<AIBrain> Dead_Friendly_List;

		private int currFriendlyProxy;

		[SerializeField]
		protected List<TriggerRefProxy> friendlyProxyList;

		[SerializeField]
		protected List<NPC_Data> friendly_Data_List;

		[SerializeField]
		public List<NPC_Data> NPC_Data_List;

		[SerializeField]
		protected List<NPC_Data> dead_NPC_Data_List;

		[SerializeField]
		protected List<DeadData> despawnedDataList;

		[SerializeField]
		protected List<DeadData> despawnedDataWaveList;

		protected Dictionary<GameObject, NPC_Data> NPC_Data_Dict;

		protected Dictionary<ProfileSpawner, NPC_Data> NPC_Zone_Dict;

		public Action OnPlayerFound;

		public Action<NPC_Data> onNPCRegistration;

		public Action<NPC_Data> OnRegisteredNPCDeath;

		public BoneLeaderManager boneLeaderManager;

		public List<LinkData> linkList;

		public int crabletAgentID;

		[Tooltip("Session is initialized, timer routine starts")]
		[Header("SESSION EVENTS")]
		[Obsolete("Migrate Unity Event to Ult Event")]
		public UnityEvent onSessionBegin;

		[Tooltip("Session is initialized, timer routine starts")]
		public UltEvent sessionBegin;

		[Tooltip("Session is complete, timer routine ends")]
		[Obsolete("Migrate Unity Event to Ult Event")]
		public UnityEvent onSessionEnd;

		[Tooltip("Session is complete, timer routine ends")]
		public UltEvent sessionEnd;

		public StaticProfiles staticProfile;

		private bool isDevToolSpawned;

		public bool showUIData;

		public bool showPlayerData;

		public bool showEnemyDisplay;

		public bool showEnemyData;

		public bool showZoneData;

		public bool showDebugDisplay;

		public bool showWeaponsAmmo;

		public bool showEventData;

		public bool showLeaderboardData;

		public bool showCollectibles;

		public bool showArena;

		public bool showArenaProfile;

		public bool showArenaEvents;

		public bool showArenaAudio;

		public bool showArenaUI;

		public bool showArenaSpawning;

		public bool[] foldArray;

		public NPC_Data currNPC;

		public Texture soundIcon;

		public Texture settingsIcon;

		public Color zoneRectColor;

		public Mesh graveMesh;

		public static string profilePath;

		public string profileTitle;

		public float elapsedTime => 0f;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Start()
		{
		}

		private void OnLevelLoadGetPlayer()
		{
		}

		[ContextMenu("BeginSession")]
		public void BeginSession()
		{
		}

		[ContextMenu("EndSession")]
		public void EndSession()
		{
		}

		public void DoCompleteLevel()
		{
		}
		private IEnumerator CoDelayedStart()
		{
			return null;
		}
		private IEnumerator CoTimerUp()
		{
			return null;
		}
		private IEnumerator CoTimerUpRealtime()
		{
			return null;
		}
		private IEnumerator CoTimerDown()
		{
			return null;
		}
		private IEnumerator CoTimerRealtime()
		{
			return null;
		}
		private IEnumerator CoDelayedEnd()
		{
			return null;
		}

		private void UpdateTimeDisplay(bool showMilliscond = false)
		{
		}

		private void OnSlowTime(float slowStep)
		{
		}

		protected void ResetFriendlyProxyList()
		{
		}

		protected void CheckForProxyTarget(TriggerRefProxy proxy)
		{
		}

		protected TriggerRefProxy GetFriendlyProxy()
		{
			return null;
		}

		public void RegisterNPCBase(ProfileSpawner profileSpawner, AIBrain brain, EnemyProfile enemyProfile, bool isFriendly)
		{
		}

		public void OnNPC_DeathBase(AIBrain brain)
		{
		}

		protected void DespawnAllNPCs()
		{
		}

		public void KillAll()
		{
		}
		private IEnumerator CoDelayedDespawn(AIBrain brain, float seconds)
		{
			return null;
		}

		private void OnDespawn(GameObject despawnedObject)
		{
		}

		protected void UpdateNPCDisplay()
		{
		}

		public void KillVolumeNPCRemoval(GameObject npcObj)
		{
		}

		protected void CreateZoneSeeker(AIBrain brain)
		{
		}

		public void DevToolSpawn()
		{
		}

		public void SubmitScoreByType()
		{
		}

		private void LoadFXAndLevel(LevelCrateReference level, LevelCrateReference loadLevel)
		{
		}

		public void LOAD_HUB()
		{
		}

		public void WAITANDRELOADCURRENTLEVEL(float delay)
		{
		}
		private IEnumerator CoDelayedReload(float delay)
		{
			return null;
		}

		public void RELOADCURRENTLEVEL()
		{
		}

		public void LOADNEXTLEVEL()
		{
		}

		public void LOADEXPLICITLEVEL()
		{
		}

		[ContextMenu("GetAllLinkData")]
		public void GetAllLinkData()
		{
		}
	}
}
