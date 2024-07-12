using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using SLZ.Rig;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_Hub : MonoBehaviour
	{
		public const string OneTrueLevelKey = "Hub";

		public const string LevelKeyA = "Hub_A";

		public const string LevelKeyB = "Hub_B";

		public const string LevelKeyC = "Hub_C";

		public static readonly string[] PriorLevelsA;

		public static readonly string[] PriorLevelsB;

		public static readonly string[] PriorLevelsC;

		public const string VoidG114AmmoOffset = "SLZ.Bonelab.VoidG114AmmoOffset";

		public const string HubSpawnLocation = "SLZ.Bonelab.HubSpawnLocation";

		public const string ElevatorBroken = "SLZ.Bonelab.ElevatorBroken";

		public const string TacTrialKeyUnlocked = "SLZ.Bonelab.TacTrialKeyUnlocked";

		public const string ArenaKeyUnlocked = "SLZ.Bonelab.ArenaKeyUnlocked";

		public const string SandboxKeyUnlocked = "SLZ.Bonelab.SandboxKeyUnlocked";

		public const string ParkourKeyUnlocked = "SLZ.Bonelab.ParkourKeyUnlocked";

		public const string ExperimentalKeyUnlocked = "SLZ.Bonelab.ExperimentalKeyUnlocked";

		public const string ModKeyUnlocked = "SLZ.Bonelab.ModKeyUnlocked";

		public const string JimmyKeyUnlocked = "SLZ.Bonelab.JimmyKeyUnlocked";

		public const string TacTrialKeyPlaced = "SLZ.Bonelab.TacTrialKeyPlaced";

		public const string ArenaKeyPlaced = "SLZ.Bonelab.ArenaKeyPlaced";

		public const string SandboxKeyPlaced = "SLZ.Bonelab.SandboxKeyPlaced";

		public const string ParkourKeyPlaced = "SLZ.Bonelab.ParkourKeyPlaced";

		public const string ExperimentalKeyPlaced = "SLZ.Bonelab.ExperimentalKeyPlaced";

		public const string ModKeyPlaced = "SLZ.Bonelab.ModKeyPlaced";

		public const string JimmyKeyPlaced = "SLZ.Bonelab.JimmyKeyPlaced";

		public const string BatteryAPlaced = "SLZ.Bonelab.BatteryAPlaced";

		public const string BatteryBPlaced = "SLZ.Bonelab.BatteryBPlaced";

		public const string LabPoweredOn = "SLZ.Bonelab.LabPoweredOn";

		[Header("Hub reverts to the old hub key core unlocking progression behavior")]
		public bool useOldHubMode;

		[Header("References")]
		public Control_UI_ProgressBoard progressBoard;

		public GameObject[] sceneExitTriggers;

		public UI_LabModule[] labModuleUIs;

		[Header("Keys")]
		public MarrowEntity[] key_Modules;

		public MarrowEntity[] key_Inserted;

		public MarrowEntity battery1;

		public MarrowEntity battery2;

		public CrateSpawner battery1_Inserted;

		public CrateSpawner battery2_Inserted;

		public MarrowEntity jimmyKey;

		public MarrowEntity jimmyKey_Inserted;

		[Header("Key Bools")]
		public bool[] isKeyUnlock;

		public bool[] isKeyInserted;

		public bool isJimmyKeyUnlocked;

		public bool isJimmyKeyInserted;

		public bool isBattery1Inserted;

		public bool isBattery2Inserted;

		public bool isGateUnlock;

		public bool isAllInserted;

		public bool isGameFinished;

		public int keyCount;

		[HideInInspector]
		public int keyUnlock;

		public bool isLabPowered;

		[Header("Renderer")]
		public GameObject[] render_Lamp;

		public MeshRenderer[] render_LockLamp;

		public MeshRenderer[] bigDoors_LockLamp;

		public MeshRenderer[] render_StripLight;

		public MeshRenderer[] generator_Lamp;

		public MeshRenderer airlock_LockLamp;

		public MeshRenderer[] airlock_cycle_N_Lamps;

		public MeshRenderer[] airlock_cycle_M_Lamps;

		public MeshRenderer[] airlock_cycle_S_Lamps;

		public Material[] mat_Lamp;

		public Material[] mat_StripLight;

		[Header("Game Objects")]
		public GameObject[] lockBar;

		private ConfigurableJoint[] lockBarJoints;

		private Rigidbody[] lockBarRB;

		public GameObject[] keyStopperLocks;

		public GameObject[] bigDoors;

		public GameObject smallDoor;

		public Vector3 smallDoorOffSettings;

		public Vector3 smallDoorOnSettings;

		public GameObject doorStopper;

		public MarrowEntity BWBox;

		public GameObject flooring;

		public GameObject backUpBWBoxCollider;

		public BasicSeatTrigger seatTrigger;

		public GauntletElevator gauntletElevator;

		public MarrowEntity breakableDoorsGroup;

		public MarrowEntity workingDoorsGroup;

		public bool isInBWBoxVolume;

		public bool isBWBoxBroken;

		private bool isBWDoorOpen;

		[Header("AudioClips")]
		public AudioClip intoMusic;

		public AudioClip[] bwClunk;

		public AudioClip[] bwWarning;

		public AudioClip[] klaxon;

		public AudioClip[] radiation;

		public AudioClip[] barRetraction;

		public AudioClip[] doorSeal;

		public PrismaticSFX bwDoorPismatic;

		private AudioPlayer apMain;

		private AudioPlayer apKlaxon;

		private AudioPlayer apRadiation;

		public PowerSource generatorPower;

		public PowerSource slzSign;

		public PowerSource slzSignBypass;

		public ParticleSystem[] steamParticles;

		public Light klaxonLight;

		public Rigidbody klaxonRB;

		public ConfigurableJoint klaxonJoint;

		[Header("Locations")]
		public List<ResumePoint> hubSpawnPoints;

		[Header("Level Loader")]
		public LevelCrateReference longRun;

		public LevelCrateReference ascent;

		public LevelCrateReference loadScreenLevel;

		public Spawnable vfxFadeOutSpawnable;

		public InventorySaveFilter inventorySaveFilter;

		public RigManager rm;

		private int _loadedTeleportSpot;

		private CancellationTokenSource doorCycle;

		private CancellationTokenSource airlockCoroutine;

		private IEnumerator generatorStartCoroutine;

		private IEnumerator airlockBlinkLoop;

		private bool airLockExitCycle;

		private bool bigDoorsOpening;

		private bool bigDoorsClosing;

		private bool smallDoorsOpening;

		private bool smallDoorsClosing;

		private bool airLockOccupied;

		private bool inAirLockProxy;

		private bool hasPlayedAirlockProxy;

		private bool blockGeneratorDisable;

		private bool battery1Placed;

		private bool battery2Placed;

		public SceneChunk labFloorChunk;

		public SceneChunk airlockChunk;

		public SceneChunk funicularChunk;

		public UnityEvent bwDoorLocked;

		public UnityEvent quarantineDoorLocked;

		public UnityEvent quarantineDoorUnlocked;

		public UnityEvent generatorStart1;

		public UnityEvent generatorStart2;

		public UnityEvent generatorStart3;

		private AvatarCrateReference[] avatarCrates;

		public static string LevelKey
		{
			get
			{
				return null;
			}
		}

		public static string[] PriorLevels
		{
			get
			{
				return null;
			}
		}

		private static PlayerProgression p
		{
			get
			{
				return null;
			}
		}

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SceneStreamerCallback()
		{
		}

		public void DataRead()
		{
		}

		public void DataWrite()
		{
		}

		public void ELEVATORBREAKOUT()
		{
		}

		private void Teleport()
		{
		}

		private void SetupKeys()
		{
		}

		public void SETUPELEVATOR()
		{
		}

		public void UNLOCKKEY(int keyInt)
		{
		}

		public void KEYINSERTED(int keyInt)
		{
		}

		public void UNLOCKJIMMYKEY(bool fromSave = false)
		{
		}

		public void JIMMYKEYINSERTED(bool fromSave = false)
		{
		}

		public void BATTERYINSERTED(int i, bool fromSave = false)
		{
		}

		public void LABPOWERED()
		{
		}

		public void OPENBWDOOR()
		{
		}

		public IEnumerator BWBoxSequence()
		{
			return null;
		}

		public IEnumerator KlaxonLight()
		{
			return null;
		}

		public void ENTERBWBOXVOL()
		{
		}

		public void EXITBWBOXVOL()
		{
		}

		public void BWBOXDESTROYED()
		{
		}

		private IEnumerator BackUpYoinkLoad()
		{
			return null;
		}

		private void CheckTotal()
		{
		}

		private void DisplayKeys()
		{
		}

		public void CheckGeneratorStatus(bool startStop)
		{
		}

		private IEnumerator GeneratorStartSequence()
		{
			return null;
		}

		public void InAirLockProxyVolume(bool inOut = false)
		{
		}

		private void CheckAirLockOpenAnimStatus()
		{
		}

		private void GameDone()
		{
		}

		public void GOTOSCENE(int gameStage = 0)
		{
		}

		private int CountKeys()
		{
			return default(int);
		}

		public void AIRLOCKENTERNORTH()
		{
		}

		public void AIRLOCKENTERSOUTH()
		{
		}

		public void AIRLOCKOCCUPIED(bool b)
		{
		}

		public void AIRLOCKCYCLE()
		{
		}

		public void CANCELCYCLE()
		{
		}

		private UniTaskVoid AirlockEnter(int side)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid AirlockExitCycle()
		{
			return default(UniTaskVoid);
		}

		private UniTask OpenSmallDoor(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		private UniTask CloseSmallDoor(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		private UniTask OpenBigDoors(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		private UniTask CloseBigDoors(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		private IEnumerator BlinkAirLockCycleLight()
		{
			return null;
		}

		private void LoadFXAndLevel(LevelCrateReference level)
		{
		}

		private static void UpgradeHubInventoryToPush()
		{
		}

		public GameControl_Hub()
			: base()
		{
		}
	}
}
