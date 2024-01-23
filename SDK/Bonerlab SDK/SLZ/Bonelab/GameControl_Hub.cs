using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.SceneStreaming;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.SaveData;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_Hub : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBWBoxSequence_003Ed__149
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

			private float _003CbarInterval_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CBWBoxSequence_003Ed__149(int _003C_003E1__state)
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
		private sealed class _003CKlaxonLight_003Ed__150
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

			private float _003CorginalIntensity_003E5__2;

			private float _003CsmoothTime_003E5__3;

			private float _003CvelRef_003E5__4;

			private float _003CalarmTime_003E5__5;

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
			public _003CKlaxonLight_003Ed__150(int _003C_003E1__state)
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
		private sealed class _003CBackUpYoinkLoad_003Ed__155
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CBackUpYoinkLoad_003Ed__155(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass169_0
		{
			public bool isDoneLoading;

			internal void _003CAirlockEnter_003Eb__0()
			{
			}

			internal void _003CAirlockEnter_003Eb__1()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAirlockEnter_003Ed__169
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

			private _003C_003Ec__DisplayClass169_0 _003C_003E8__1;

			public int side;

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
			public _003CAirlockEnter_003Ed__169(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass170_0
		{
			public bool isDoneLoading;

			internal void _003CAirlockExitCycle_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass170_1
		{
			public bool isDoneLoading;

			internal void _003CAirlockExitCycle_003Eb__1()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAirlockExitCycle_003Ed__170
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

			private _003C_003Ec__DisplayClass170_0 _003C_003E8__1;

			private _003C_003Ec__DisplayClass170_1 _003C_003E8__2;

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
			public _003CAirlockExitCycle_003Ed__170(int _003C_003E1__state)
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
		private sealed class _003COpenSmallDoorCoroutine_003Ed__174
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003COpenSmallDoorCoroutine_003Ed__174(int _003C_003E1__state)
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
		private sealed class _003CCloseSmallDoorCoroutine_003Ed__175
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CCloseSmallDoorCoroutine_003Ed__175(int _003C_003E1__state)
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
		private sealed class _003COpenDoorCoroutine_003Ed__177
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003COpenDoorCoroutine_003Ed__177(int _003C_003E1__state)
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
		private sealed class _003COpenDoorInterrupt_003Ed__178
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003COpenDoorInterrupt_003Ed__178(int _003C_003E1__state)
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
		private sealed class _003CCloseDoorCoroutine_003Ed__180
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CCloseDoorCoroutine_003Ed__180(int _003C_003E1__state)
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
		private sealed class _003CCloseDoorInterrupt_003Ed__181
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CCloseDoorInterrupt_003Ed__181(int _003C_003E1__state)
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

		public const string OneTrueLevelKey = "Hub";

		public const string LevelKeyA = "Hub_A";

		public const string LevelKeyB = "Hub_B";

		public const string LevelKeyC = "Hub_C";

		public static readonly string[] PriorLevelsA;

		public static readonly string[] PriorLevelsB;

		public static readonly string[] PriorLevelsC;

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

		public const string VoidG114AmmoOffset = "SLZ.Bonelab.HubSpawnLocation";

		[Header("References")]
		public Control_Player controlPlayer;

		public Control_UI_ProgressBoard progressBoard;

		public TriggerLasers rmFetcher;

		public GameObject[] sceneExitTriggers;

		[Header("Keys")]
		public GameObject[] key_Modules;

		public GameObject[] key_Inserted;

		public GameObject battery1;

		public GameObject battery2;

		public GameObject battery1_Inserted;

		public GameObject battery2_Inserted;

		public GameObject jimmyKey;

		public GameObject jimmyKey_Inserted;

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

		[Header("Renderer")]
		public GameObject[] render_Lamp;

		public MeshRenderer[] render_LockLamp;

		public MeshRenderer[] bigDoors_LockLamp;

		public MeshRenderer[] render_StripLight;

		public MeshRenderer airlock_LockLamp;

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

		public GameObject BWBox;

		public GameObject flooring;

		public GameObject backUpBWBoxCollider;

		public BasicSeatTrigger seatTrigger;

		public GauntletElevator gauntletElevator;

		public GameObject breakableDoorsGroup;

		public GameObject workingDoorsGroup;

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

		public AudioMixerGroup outputMixer;

		private AudioPlayer apMain;

		private AudioPlayer apKlaxon;

		private AudioPlayer apRadiation;

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

		private IEnumerator doorCycle;

		private IEnumerator airlockCoroutine;

		private bool bigDoorsOpening;

		private bool bigDoorsClosing;

		private bool smallDoorsOpening;

		private bool smallDoorsClosing;

		private bool airLockOccupied;

		private bool inAirLockProxy;

		private bool hasPlayedAirlockProxy;

		public bool labLoaded;

		public bool airlockLoaded;

		public bool funicularLoaded;

		public bool slzRoomLoaded;

		public Chunk northChunk;

		public Chunk northAndAirlockChunk;

		public Chunk airlockChunk;

		public Chunk southAndAirlockChunk;

		public Chunk southChunk;

		public UnityEvent activateCrane;

		public UnityEvent unlockSPA;

		public UnityEvent insertIronKey;

		public UnityEvent breakBoneBox;

		public UnityEvent bwDoorLocked;

		public UnityEvent quarantineDoorLocked;

		public UnityEvent quarantineDoorUnlocked;

		private AvatarCrateReference[] avatarCrates;

		public static string LevelKey => null;

		public static string[] PriorLevels => null;

		private static PlayerProgression p => null;

		private static PlayerUnlocks u => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void FETCHRIGMANAGER()
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

		public void UNLOCKJIMMYKEY()
		{
		}

		public void JIMMYKEYINSERTED()
		{
		}

		public void BATTERYINSERTED(int i)
		{
		}

		public void OPENBWDOOR()
		{
		}

		[IteratorStateMachine(typeof(_003CBWBoxSequence_003Ed__149))]
		public IEnumerator BWBoxSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CKlaxonLight_003Ed__150))]
		public IEnumerator KlaxonLight()
		{
			return null;
		}

		private void PlayAudioClip(AudioPlayer ap, AudioClip[] clip, float volume, float minDist, Transform pos, bool looping = false)
		{
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

		[IteratorStateMachine(typeof(_003CBackUpYoinkLoad_003Ed__155))]
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

		public void InAirLockProxyVolume(bool inOut = false)
		{
		}

		private void CheckAirLockOpenAnimStatus()
		{
		}

		public void COMPLETE()
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
			return 0;
		}

		public void AIRLOCKENTERNORTH()
		{
		}

		public void AIRLOCKENTERSOUTH()
		{
		}

		public void AIRLOCKOCCUPIED()
		{
		}

		public void AIRLOCKUNOCCUPIED()
		{
		}

		public void AIRLOCKCYCLE()
		{
		}

		[IteratorStateMachine(typeof(_003CAirlockEnter_003Ed__169))]
		private IEnumerator AirlockEnter(int side)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAirlockExitCycle_003Ed__170))]
		private IEnumerator AirlockExitCycle()
		{
			return null;
		}

		public void CANCELCYCLE()
		{
		}

		public void OpenSmallDoor()
		{
		}

		public void CloseSmallDoor()
		{
		}

		[IteratorStateMachine(typeof(_003COpenSmallDoorCoroutine_003Ed__174))]
		public IEnumerator OpenSmallDoorCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloseSmallDoorCoroutine_003Ed__175))]
		public IEnumerator CloseSmallDoorCoroutine()
		{
			return null;
		}

		public void OpenBigDoors()
		{
		}

		[IteratorStateMachine(typeof(_003COpenDoorCoroutine_003Ed__177))]
		private IEnumerator OpenDoorCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003COpenDoorInterrupt_003Ed__178))]
		private IEnumerator OpenDoorInterrupt()
		{
			return null;
		}

		public void CloseBigDoors()
		{
		}

		[IteratorStateMachine(typeof(_003CCloseDoorCoroutine_003Ed__180))]
		private IEnumerator CloseDoorCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCloseDoorInterrupt_003Ed__181))]
		private IEnumerator CloseDoorInterrupt()
		{
			return null;
		}

		public void OnLabLoaded()
		{
		}

		public void OnAirlockLoaded()
		{
		}

		public void OnFunicularLoaded()
		{
		}

		public void OnSLZRoomLoaded()
		{
		}

		public void OnLabUnloaded()
		{
		}

		public void OnAirlockUnloaded()
		{
		}

		public void OnFunicularUnloaded()
		{
		}

		public void OnSLZRoomUnloaded()
		{
		}

		private void LoadFXAndLevel(LevelCrateReference level)
		{
		}

		private static void UpgradeHubInventoryToPush()
		{
		}
	}
}
