using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class NooseBonelabIntro : MonoBehaviour
	{
		private enum NooseStage
		{
			Initial = 0,
			Reeling = 1,
			Locked = 2,
			Hanging = 3,
			Cut = 4
		}

		[CompilerGenerated]
		private sealed class _003CLoadFXAndLevel_003Ed__60
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NooseBonelabIntro _003C_003E4__this;

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
			public _003CLoadFXAndLevel_003Ed__60(int _003C_003E1__state)
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

		public PlayableDirector introCutscene;

		public RigManager rM;

		public Player_Health pH;

		private ConfigurableJoint _chestToKnot;

		private SpringJoint _minDistanceJoint;

		private InteractableHostManager _hostManager;

		public Rigidbody knotRb;

		public Rigidbody nooseLeftRb;

		public Rigidbody nooseRightRb;

		public Rigidbody nooseBottomRb;

		public float nooseOnToSceneReveal;

		public float sceneRevealToPlankDrop;

		public float plankDropTimer;

		public float damageTickRate;

		public float damagePerTick;

		public AudioClip nooseReveal;

		public AudioClip noosePutOn;

		public AudioClip nooseCut;

		public AudioMixerGroup audioMixerGroup;

		[SerializeField]
		private NooseStage _nooseStage;

		private bool _sideLeft;

		private float _nooseTimer;

		private bool _nooseBool;

		public bool _isHanging;

		private int _stageInt;

		private float _timeSinceLastDamageTick;

		public UnityEvent nooseOnEvent;

		public UnityEvent nooseOnAndHeldEvent;

		public UnityEvent daggerSpawnEvent;

		public UnityEvent nooseCutEvent;

		public UnityEvent nooseDeath;

		public ConfigurableJoint[] armPlatformJoints;

		private Quaternion _armJointInitial0;

		private Quaternion _armJointInitial1;

		private Quaternion _armJointInitial2;

		private Quaternion _armJointInitial3;

		private Quaternion _armJointInitial4;

		public Rigidbody dagger;

		private Vector3 _daggerInitV3;

		private Quaternion _daggerInitRot;

		private ConfigurableJoint _daggerJoint;

		[Header("Level Loader")]
		public LevelCrateReference level;

		public Spawnable vfxFadeOutSpawnable;

		public void AddVelocityToNoose(Vector3 force)
		{
		}

		private void OnEnable()
		{
		}

		public void ResetNoose()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private bool CheckRelativeToHead()
		{
			return false;
		}

		private float CheckReel()
		{
			return 0f;
		}

		private void CheckAndSetTargetSide()
		{
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		private void AttachNeck()
		{
		}

		private void ReelingNeck()
		{
		}

		private void LockedNeck()
		{
		}

		private void HangingSequence()
		{
		}

		public void NooseCut()
		{
		}

		public void Reveal()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadFXAndLevel_003Ed__60))]
		private IEnumerator LoadFXAndLevel()
		{
			return null;
		}

		private void LoadLevel()
		{
		}

		private void CutScene(bool play, bool turnOn)
		{
		}
	}
}
