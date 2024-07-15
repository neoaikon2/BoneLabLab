using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.AI;
using SLZ.Marrow.Pool;
using TMPro;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Arena_GameController : BaseGameController
	{
		public enum ArenaStartMode
		{
			ON_START = 0,
			ON_TRIGGER = 1,
			CUSTOM = 2,
			ON_TRIGGER_BELL = 3
		}

		public enum ArenaDifficulty
		{
			EASY = 0,
			MEDIUM = 1,
			HARD = 2,
			HARDER = 3,
			HARDEST = 4
		}

		public enum ArenaState
		{
			ACTIVE = 0,
			WAITING = 1,
			FAILED = 2,
			QUIT = 3,
			WIN = 4
		}		public TimeBender timeBender;

		public RoundProfileGroup assignedRoundProfile;

		public RoundProfileGroup survivalProfile;

		public RoundProfileGroup survivalProfileProjected;

		public List<RoundProfileGroup> roundProfileGroupList;

		public ArenaStartMode arenaStartMode;

		public ArenaDifficulty difficulty;

		public ArenaState arenaState;

		public GenGameControl_Trigger arenaStartTrigger;

		public GenGameControl_Trigger NPCEntranceTrigger;

		public GenGameControl_Spawner lootSpawner;

		public WeaponSpawner weaponSpawner;

		public GeoManager geoManager;

		[SerializeField]
		private int currGeo;

		[SerializeField]
		private int friendlySpawnCount;

		[SerializeField]
		private ProfileSpawner kingSpawner;

		[SerializeField]
		private GameObject[] friendlyTargetObjs;

		[SerializeField]
		private int currFriendlySpawn;

		private int currFriendlyTarg;

		[SerializeField]
		private Arena_Launcher launcher;

		[SerializeField]
		private int initLightAmmo;

		[SerializeField]
		private int initMedAmmo;

		[SerializeField]
		private int initHeavyAmmo;

		private CancellationTokenSource enemySpawnCTS;

		private Coroutine enemySpawnRoutine;

		private Coroutine arenaTimerRoutine;

		private Coroutine friendlySpawnRoutine;

		private Coroutine killComboRoutine;

		private bool isSpawning;

		private bool isWaveOngoing;

		public bool isPlayerReady;

		public bool isRung;

		private int currWaveIndex;

		private int currRoundIndex;

		private int maxConcurrentLimit;

		private int totalEnemyCount;

		private int currSpawner;

		[SerializeField]
		private float arenaTimerValue;

		[SerializeField]
		private float arenaStartDelay;

		private RoundProfile currentRound;

		private WaveProfile currentWave;

		[SerializeField]
		private int killScore;

		[SerializeField]
		private int comboMult;

		private float comboTimeVal;

		private float comboTimer;

		private int initPlayerAmmoVal;

		public TMP_Text arenaTimerText;

		public TMP_Text arenaRoundText;

		public TMP_Text arenaWaveText;

		public List<TMP_Text> arenaModeTexts;

		public List<TMP_Text> arenaDifficultyTexts;

		public TMP_Text comboTimerText;

		public TMP_Text comboMultText;

		public TMP_Text scoreText;

		public UnityEvent onPlayerReady;

		public UnityEvent onPlayerEnter;

		public UnityEvent onRoundBegin;

		public UnityEvent onRoundEnd;

		public UnityEvent onWaveBegin;

		public UnityEvent onWaveEnd;

		public UnityEvent onModeEnd;

		public UnityEvent onModeQuit;

		public UnityEvent OnReadyUpBell;

		public UnityEvent onRingBell;

		public UnityEvent onModeWin;

		public UltEvent playerReady;

		public UltEvent playerEnter;

		public UltEvent roundBegin;

		public UltEvent roundEnd;

		public UltEvent waveBegin;

		public UltEvent waveEnd;

		public UltEvent modeEnd;

		public UltEvent modeQuit;

		public UltEvent readyUpBell;

		public UltEvent ringBell;

		public UltEvent modeWin;

		public static Action OnSaveReady;

		public static Action<Vector3> OnCureNPC;

		[SerializeField]
		private AudioClip[] roundStartClips;

		[SerializeField]
		private AudioClip[] roundEndClips;

		[SerializeField]
		private AudioClip waveStartClip;

		[SerializeField]
		private AudioClip waveEndClip;

		[SerializeField]
		private AudioClip playerEnterClip;

		[SerializeField]
		private AudioClip greetingClip;

		[SerializeField]
		private AudioClip ammoClip;

		[SerializeField]
		private AudioClip failModeClip;

		[SerializeField]
		private AudioClip winModeClip;

		[SerializeField]
		private float musicVol;

		[SerializeField]
		private AudioClip[] loopingMusicClips;

		private int currClip;

		public Dictionary<GameObject, Arena_NPC_Data> arena_NPC_dict;

		public Dictionary<GameObject, NPC_Data> sublimationDict;

		public GameObject[] randToggleObjs;

		public HashSet<ProfileSpawner> spawnerHash;

		private Coroutine playerDistRoutine;

		private Vector3 currPlayerPos;

		private Vector3 lastPlayerPos;

		private float lastPlayerCheck;

		private float thresh;

		private float playerDistTick;

		public float totalPlayerDist;

		private bool nextWaveExists;

		private int totalHeadShots;

		private int projectilesShot;

		private int healthPackLimit;

		public int healthPackCount;

		[SerializeField]
		private List<NPC_Objective> allNPCObjectives;

		[SerializeField]
		private List<NPC_Objective> activeNPCObjectives;

		[SerializeField]
		private List<Arena_TriggeredSpawners> triggeredSpawnerList;

		private int currObjProxy;

		private int currProfile;

		public UnityEvent OnObjectiveInitiated;

		public UnityEvent OnObjectiveFailed;

		public UnityEvent OnObjectiveCompleted;

		public UnityEvent OnStackCompletion;

		public UltEvent ObjectiveInitiated;

		public UltEvent ObjectiveFailed;

		public UltEvent ObjectiveCompleted;

		public UltEvent StackCompletion;

		public int round => 0;

		public int wave => 0;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		public override void Start()
		{
		}

		public void OnPlayerSpawn()
		{
		}

		public void NPC_Enter(TriggerRefProxy proxy)
		{
		}

		public void OnArenaSessionBegin()
		{
		}

		public void NPC_Registration(NPC_Data data)
		{
		}

		public void FriendlyRegistration(NPC_Data data)
		{
		}

		public void OnRegisteredNPC_Death(NPC_Data data)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		public void ARENA_SwapSpawnerList(int id)
		{
		}

		public void ClearSpawnerList()
		{
		}

		public void AddZoneSpawners(Arena_TriggeredSpawners trigSpawners)
		{
		}

		public void RemovedZoneSpawners(Arena_TriggeredSpawners trigSpawners)
		{
		}

		public void ARENA_SetDifficulty(int diff)
		{
		}

		public void ARENA_ToggleDifficulty()
		{
		}

		public void ARENA_StartMatch()
		{
		}

		public void ARENA_CancelMatch()
		{
		}

		[ContextMenu("ForceStart_Test")]
		public void ForceStartMatchForTesting()
		{
		}

		public void ARENA_PlayerEnter()
		{
		}
		private IEnumerator CoKingEntrance(float waitSeconds)
		{
			return null;
		}

		public void ARENA_RingTheBell()
		{
		}

		public void ARENA_ResetTheBell()
		{
		}

		private void IncreaseChallengeDifficulty()
		{
		}

		public void ARENA_ChallengeResume(int resumeRound, bool projectedProfile)
		{
		}

		public void ARENA_ChallengeSelect(int sel)
		{
		}

		public void CancelCurrentChallenge()
		{
		}

		public void ARENA_CustomChallengeSelect(RoundProfileGroup customProfile)
		{
		}

		private void SetArenaState(ArenaState state)
		{
		}

		private void FailStateFX()
		{
		}

		private void WinStateFX()
		{
		}

		public void ToggleAgentLinking(bool enableLinking)
		{
		}

		private void SetupProtectMode()
		{
		}

		private void SetupCustomMode()
		{
		}

		public void ARENA_QuitChallenge()
		{
		}

		private void StartNextWave()
		{
		}

		public void StartNextProfile(int profile)
		{
		}

		private void StartPlayerDist()
		{
		}
		private IEnumerator CoPlayerDist()
		{
			return null;
		}

		private void StartSpawning()
		{
		}
		private UniTaskVoid SpawnEnemyLoop(CancellationToken ct)
		{
			return default(UniTaskVoid);
		}

		public void UpdateProfileEnemyCount(int concEnemyCount, bool immediateIncrease = false, int increaseRate = 1)
		{
		}

		private void SpawnHoiPoi(EnemyProfile profile)
		{
		}

		public void SpawnFailedHoiPoi(EnemyProfile profile)
		{
		}
		private IEnumerator CoSpawnFriendlyList(int fCount)
		{
			return null;
		}

		private void AssignFriendlyTargetPosition(AIBrain brain)
		{
		}
		private IEnumerator CoFriendlyArrival(AIBrain currBrain)
		{
			return null;
		}

		[ContextMenu("SpawnKing")]
		private void SpawnKing()
		{
		}

		[ContextMenu("CureAll")]
		public void StopSpawningAndCureAll()
		{
		}
		private IEnumerator CoCureAll()
		{
			return null;
		}

		private void UpdateArenaDisplay()
		{
		}

		private void CheckForWaveEnd()
		{
		}
		private IEnumerator CoEndOfWave()
		{
			return null;
		}

		private bool CheckProfileForNextWave()
		{
			return false;
		}

		private void FailProtectMode()
		{
		}

		public void PassEscapeMode()
		{
		}

		public void FailEscapeMode()
		{
		}
		private IEnumerator CoResetOnWaveCompleteOrFail()
		{
			return null;
		}
		private IEnumerator CoFriendlySublimation()
		{
			return null;
		}

		private void Sublimate(NPC_Data npcData, bool enableEffect)
		{
		}

		private void ClearNPCDataAndZoneLists()
		{
		}

		private void EndOfRound()
		{
		}

		public void ARENA_ObjectiveProfileCompleted()
		{
		}

		private void EndOfMode()
		{
		}

		private void UpdateChallengeCompletion()
		{
		}
		private IEnumerator CoKillCombo()
		{
			return null;
		}

		private void StopAndResetKillCombo()
		{
		}

		[ContextMenu("CLEAR SCORE")]
		public void ClearScore()
		{
		}

		private void CalculatePlayerScore()
		{
		}

		private void HEAD_SHOOTER()
		{
		}

		private void ProjectileShot()
		{
		}

		private void OnPlayerDeath()
		{
		}

		public void CalcScoreAndSubmitLeader()
		{
		}

		public void ARENA_SubmitScoreByType()
		{
		}

		private void PlayerDamage(float damageAmount)
		{
		}

		private void CreateNewWave(WaveProfile wave)
		{
		}

		private void CreateNewRound(RoundProfile prevRound)
		{
		}

		public void SpawnLoot()
		{
		}

		private void DespawnLootWeapons(bool despawnAll = false)
		{
		}

		[ContextMenu("TestToggle")]
		public void TestToggle()
		{
		}

		public void RandomToggle(bool active)
		{
		}
		private IEnumerator Co_TimerUp_Arena()
		{
			return null;
		}
		private IEnumerator Co_TimerDown_Arena(float seconds)
		{
			return null;
		}

		private void UpdateArenaTimeDisplay()
		{
		}

		private void PlayArenaAudio(AudioClip clip)
		{
		}

		public void ToggleNavMeshArea(string areaName, int areaValue)
		{
		}

		public void LOCK_NAVMESH_AREA(string areaName)
		{
		}

		public void UNLOCK_NAVMESH_AREA(string areaName)
		{
		}

		public void InvertNavMeshArea(string areaName)
		{
		}

		public void RewardAmmo(int cartridge, int amount)
		{
		}

		public void HealthPackCollected(GameObject go)
		{
		}

		public void SpawnHealthPackOnChance(NPC_Data npcData)
		{
		}

		[ContextMenu("SpawnLargeHealthPack")]
		public void SpawnLargeHealthPack(Vector3 spawnPoint)
		{
		}

		[ContextMenu("SpawnSmallHealthPack")]
		public void SpawnSmallHealthPack(Vector3 spawnPoint)
		{
		}
		private IEnumerator CoDelayedRespawn(NPC_Data data)
		{
			return null;
		}
		private IEnumerator CoSpawnObjectiveEnemies()
		{
			return null;
		}

		public void SpawnReplacement(NPC_Data data)
		{
		}

		protected NPC_Objective GetObjective()
		{
			return null;
		}

		[ContextMenu("StartObjective")]
		public void ObjectiveBlueKeyedTest()
		{
		}

		[ContextMenu("KeyObjectiveZero")]
		public void KeyObjectiveZero()
		{
		}

		[ContextMenu("KeyObjectiveOne")]
		public void KeyObjectiveOne()
		{
		}

		[ContextMenu("KeyObjectiveTwo")]
		public void KeyObjectiveTwo()
		{
		}

		public void OnObjectiveKeyed(NPC_Objective objective)
		{
		}

		public void OnObjectiveCharged(NPC_Objective objective)
		{
		}

		public void OnObjectiveDestruction(NPC_Objective objective)
		{
		}

		public void OnObjectiveKeyRemoved(NPC_Objective objective)
		{
		}

		public void AgroAllOnPlayer(NPC_Objective objective)
		{
		}

		public void AgroAllOnObjective(NPC_Objective objective)
		{
		}

		public void AssignObjectiveAgro(NPC_Data data)
		{
		}

		public void FailObjectiveMode()
		{
		}

		public void DelayedObjectiveStart()
		{
		}
		private IEnumerator CoDelayedObjectiveStart()
		{
			return null;
		}

		public void InitObjectiveMode()
		{
		}

		public void StartObjectiveRound()
		{
		}

		public void ProgressToNextObjectiveProfile()
		{
		}
		private IEnumerator CoObjectiveWait()
		{
			return null;
		}

		private void StartNextObjectiveProfile()
		{
		}

		public void InitObjectiveContainer()
		{
		}

		public void ProgressToNextProfile()
		{
		}

		private void ObjectiveBatteryGrab()
		{
		}
	}
}
