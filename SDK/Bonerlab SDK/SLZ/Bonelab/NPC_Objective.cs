using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
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

		[CompilerGenerated]
		private sealed class _003CCoExploder_003Ed__76
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NPC_Objective _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003Cendtime_003E5__3;

			private float _003CexploderLerp_003E5__4;

			private Vector3 _003CendScale_003E5__5;

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
			public _003CCoExploder_003Ed__76(int _003C_003E1__state)
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
		private sealed class _003CCoFadePumpEmission_003Ed__81
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NPC_Objective _003C_003E4__this;

			private float _003Cstart_003E5__2;

			private float _003Cend_003E5__3;

			private float _003CfadeLerp_003E5__4;

			private float _003CstartIntensity_003E5__5;

			private float _003CstartPitch_003E5__6;

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
			public _003CCoFadePumpEmission_003Ed__81(int _003C_003E1__state)
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
		private sealed class _003CCoFadeEmission_003Ed__85
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NPC_Objective _003C_003E4__this;

			private float _003Cstart_003E5__2;

			private float _003Cend_003E5__3;

			private float _003CfadeLerp_003E5__4;

			private float _003CstartIntensity_003E5__5;

			private float _003CstartScale_003E5__6;

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
			public _003CCoFadeEmission_003Ed__85(int _003C_003E1__state)
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
		private sealed class _003CCoLaser_003Ed__87
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NPC_Objective _003C_003E4__this;

			private float _003Cstart_003E5__2;

			private float _003Cend_003E5__3;

			private float _003ClaserLerp_003E5__4;

			private Vector3 _003CcurrScale_003E5__5;

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
			public _003CCoLaser_003Ed__87(int _003C_003E1__state)
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

		[Header("Key")]
		[SerializeField]
		private bool isKeyRequired;

		[SerializeField]
		private bool isKeyed;

		public KeyReciever keyReciever;

		[SerializeField]
		private Key batteryKey;

		[SerializeField]
		private ObjectiveBattery battery;

		public int tankIndex;

		[SerializeField]
		[Header("Audio")]
		private AudioSource loopingASource;

		[SerializeField]
		private AudioMixerGroup audioGroup;

		[SerializeField]
		private AudioClip enableClip;

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
		private LineRenderer lineRend;

		[SerializeField]
		[Header("UI")]
		private TMP_Text energyText;

		[SerializeField]
		[Header("DoorJoints")]
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
		private GameObject magmaObj;

		[SerializeField]
		private float laserScaleTime;

		private float currIntensity;

		[SerializeField]
		private LightningStriker striker;

		[SerializeField]
		[Header("ContainerYard")]
		private GameObject puddleScalerObj;

		private Vector3 startPuddleScale;

		[SerializeField]
		private GameObject[] puddleFXObjs;

		[SerializeField]
		private GameObject explodeSphereObj;

		private float explosionForce;

		private float explosionRadius;

		private float expandDuration;

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

		private void UpdateDamage(float damage)
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

		[IteratorStateMachine(typeof(_003CCoExploder_003Ed__76))]
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

		[IteratorStateMachine(typeof(_003CCoFadePumpEmission_003Ed__81))]
		private IEnumerator CoFadePumpEmission()
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

		[IteratorStateMachine(typeof(_003CCoFadeEmission_003Ed__85))]
		private IEnumerator CoFadeEmission()
		{
			return null;
		}

		private void LaserBlast()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaser_003Ed__87))]
		private IEnumerator CoLaser()
		{
			return null;
		}
	}
}
